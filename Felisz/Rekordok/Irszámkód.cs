namespace Felisz
{
    class Irszámkód
    {
        public string Irányítószám { get; set; }
        public string VárosIrsz { get; set; }

        public override string ToString()
        {
            return VárosIrsz;
        }
    }
}