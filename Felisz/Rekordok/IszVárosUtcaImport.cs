namespace Felisz
{
    //Irányítószám, város, utcanevek letöltéséhez az openstreetmap-ról
    class IszVárosUtcaImport
    {
        public string irányítószám { get; set; }
        public string város { get; set; }
        public string közterület { get; set; }
    }
}