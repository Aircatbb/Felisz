namespace Felisz
{
    class FoglalkoztatásHelye
    {
        public int ID { get; set; }
        public string FoglalkoztatóNeve { get; set; }
        public string Irsz { get; set; }
        public string Város { get; set; }
        public string Közterület { get; set; }
        public string KözterületJellege { get; set; }
        public string Házszám { get; set; }
        public string Megnevezés { get; set; }
        public override string ToString()
        {
            return Megnevezés;
        }
    }
}
