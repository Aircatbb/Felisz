using System;
using System.Xml;

namespace Felisz
{
    class XMLImport
    {
        public static void XMLTest()
        {

            /*
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("http://hrportal.hu/rss/hirek.xml");
            XmlNodeList itemNodes = xmlDoc.SelectNodes("//rss/channel/item");
            foreach (XmlNode itemNode in itemNodes)
            {
                XmlNode titleNode = itemNode.SelectSingleNode("title");
                XmlNode dateNode = itemNode.SelectSingleNode("pubDate");
                if ((titleNode != null) && (dateNode != null))
                    Console.WriteLine(dateNode.InnerText + ": " + titleNode.InnerText);
            }
            */

            XmlDocument xmlDoc2 = new XmlDocument();
            xmlDoc2.Load(@"C:\Users\balazs.bognar\abevjava\import\pelda.xml");
            XmlNodeList itemNodes2 = xmlDoc2.SelectNodes("//nyomtatvanyok");
            foreach (XmlNode itemNode2 in itemNodes2)
            {
                Console.WriteLine(itemNode2.InnerText);


                XmlNode titleNode2 = itemNode2.SelectSingleNode("mezo");
                if ((titleNode2 != null))
                    Console.WriteLine(titleNode2.InnerText);
            }


            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(@"C:\Users\balazs.bognar\abevjava\import\pelda.xml");



            Console.WriteLine(xmlDoc.DocumentElement);

            XmlNodeList titleNodes = xmlDoc.SelectNodes("//abev");
            foreach (XmlNode titleNode in titleNodes)
                Console.WriteLine(titleNode.InnerText);



        }



    }
}
