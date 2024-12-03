namespace TicketWebAPI.DTOs
{
    public class Flight
    {
        public int FlightID { get; set; }
        public string FlightNo { get; set; }
        public string DepartureDate { get; set; }
        public string PersianDepartureDate { get; set; }
        public string DepartureTime { get; set; }
        public string ArrivalTime { get; set; }
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
        public int? Commission { get; set; }
        public string Manufacturer { get; set; }
        public bool UpdStatus { get; set; }
        public string UpdTime { get; set; }
        public Supplier Supplier { get; set; }
        public Airline Airline { get; set; }
        public Aircraft Aircraft { get; set; }
        public Departure Departure { get; set; }
        public Arrival Arrival { get; set; }
    }

    public class CheckFlight
    {
        public Result Result { get; set; }
        public Flight Flight { get; set; }
    }



}
