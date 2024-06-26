namespace SignalRApi.DAL
{
    public enum ECity
    {
        Baku = 1,
        Sumqayit = 2,
        Gence = 3,
        Ismayilli = 4,
        Kabala = 5
    }
    public class Visitor
    {
        public int VisitorID { get; set; }
        public ECity City { get; set; }
        public int CityVisitCount { get; set; }
        public DateTime VisitDate { get; set; }
    }
}
