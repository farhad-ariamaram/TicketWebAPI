namespace TicketWebAPI.DTOs
{
    public class Aircraft
    {
        public string Code { get; set; }
        public string Manufacturer { get; set; }
        public string Name { get; set; }
    }

    public class Airline
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Logo { get; set; }
    }

    public class Arrival
    {
        public string RegionName { get; set; }
        public string Code { get; set; }
        public string ParentRegionName { get; set; }
        public ParentRegion? ParentRegion { get; set; }
    }

    public class Departure
    {
        public string RegionName { get; set; }
        public string Code { get; set; }
        public string ParentRegionName { get; set; }
        public ParentRegion? ParentRegion { get; set; }
    }

    public class DepartureFlight
    {
        public int FlightID { get; set; }
        public string FlightNo { get; set; }
        public string DepartureDate { get; set; }
        public string PersianDepartureDate { get; set; }
        public string DepartureTime { get; set; }
        public object ArrivalTime { get; set; }
        public int AdtPrice { get; set; }
        public int ChdPrice { get; set; }
        public int InfPrice { get; set; }
        public int Capacity { get; set; }
        public string FlightType { get; set; }
        public bool IsForeign { get; set; }
        public string Description { get; set; }
        public string SeatClass { get; set; }
        public string CabinType { get; set; }
        public bool Reservable { get; set; }
        public int DisplayMode { get; set; }
        public string Manufacturer { get; set; }
        public string UpdTime { get; set; }
        public Supplier Supplier { get; set; }
        public Airline Airline { get; set; }
        public Aircraft Aircraft { get; set; }
        public Departure Departure { get; set; }
        public Arrival Arrival { get; set; }
    }

    public class FlightOneway
    {
        public List<DepartureFlight> DepartureFlights { get; set; }
    }

    public class Supplier
    {
        public int SupplierID { get; set; }
        public string Name { get; set; }
        public string ManagerName { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Fax { get; set; }
        public string Logo { get; set; }
        public string Email { get; set; }
        public string PostalCode { get; set; }
        public string ManagerMobile { get; set; }
        public string LicenseNo { get; set; }
        public string CountryName { get; set; }
        public string CityName { get; set; }
        public string Address { get; set; }
        public string AgentName { get; set; }
        public string AgentMobile { get; set; }
        public string AgentEmail { get; set; }
        public string AgentPhone { get; set; }
        public string LatLang { get; set; }
        public string Website { get; set; }
        public Crawler? Crawler { get; set; }
    }


}
