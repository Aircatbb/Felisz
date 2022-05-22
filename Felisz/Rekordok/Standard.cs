namespace Felisz
{
    class Standard
    {
        public string Megnevezés { get; set; }
        public string Kód { get; set; }
        public override string ToString()
        {
            return Megnevezés;
        }
    }
}
