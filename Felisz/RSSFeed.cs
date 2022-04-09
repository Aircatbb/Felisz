using System.Collections.Generic;
using System.ServiceModel.Syndication;
using System.Threading;
using System.Xml;

namespace Felisz
{
    class RSSFeed
    {

        public static List<RSSPost> postok = new List<RSSPost>();
        public static int RSSCounter = -1;
        public static RSSPost RSSPostLekérése()
        {


            Thread threadRSSLetöltés = new Thread(new ThreadStart(RSSLetöltése));
            threadRSSLetöltés.Name = "RSS Letöltése";
            threadRSSLetöltés.Start();
            //RSSLetöltése();

            if (Properties.Settings.Default.RSSUrl != "")
            {
                RSSCounter++;
                if (RSSCounter < postok.Count)
                {
                    RSSPost rP = new RSSPost();
                    rP.Cím = postok[RSSCounter].Cím;
                    rP.Dátum = postok[RSSCounter].Dátum;
                    rP.Url = postok[RSSCounter].Url;
                    return rP;
                }
                else
                {
                    if (threadRSSLetöltés.ThreadState != ThreadState.Running)
                    {
                        postok.Clear();
                        RSSPostLekérése();
                    }
                    RSSCounter = 0;
                    return null;
                }
            }
            else
            {
                return null;
            }

        }

        private static void RSSLetöltése()
        {

            if (postok.Count == 0 && Properties.Settings.Default.RSSUrl != "")
            {
                string url = Properties.Settings.Default.RSSUrl;
                var reader = XmlReader.Create(url);
                var feed = SyndicationFeed.Load(reader);
                var posts = feed.Items;
                foreach (var entry in posts)
                {
                    RSSPost p = new RSSPost();
                    p.Cím = entry.Title.Text;
                    p.Dátum = entry.PublishDate;
                    p.Url = entry.Links[0].Uri;
                    postok.Add(p);
                }
                RSSCounter = -1;
                reader.Close();

            }


        }
    }
}
