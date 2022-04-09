namespace Felisz
{
    class Városkód
    {
        public string Város { get; set; }
        public string VárosIrsz { get; set; }

        public override string ToString()
        {
            return VárosIrsz;
        }
    }
}
