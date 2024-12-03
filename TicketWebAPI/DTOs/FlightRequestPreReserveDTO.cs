namespace TicketWebAPI.DTOs
{
    public class PassengerInput
    {
        public string PassengerType { get; set; }
        public bool PersianName { get; set; }
        public bool EnglishName { get; set; }
        public bool NationalCode { get; set; }
        public bool PassportNumber { get; set; }
        public bool PassportExpiryDate { get; set; }
        public bool DateOfBirth { get; set; }
    }

    public class Request
    {
        public string SearchHistoryID { get; set; }
        public string RequestNumber { get; set; }
        public string CreateDate { get; set; }
        public string CreateBy { get; set; }
        public string Status { get; set; }
        public string TimeLimit { get; set; }
        public string SupplierName { get; set; }
        public int TotalFare { get; set; }
        public List<RequestFare> RequestFares { get; set; }
        public List<RequestPassenger> RequestPassengers { get; set; }
        public List<RequestFlight> RequestFlights { get; set; }
    }

    public class RequestFare
    {
        public string Type { get; set; }
        public int BaseFare { get; set; }
        public int Commission { get; set; }
        public int Markup { get; set; }
        public int PassengerCount { get; set; }
        public string PassengerType { get; set; }
        public int TotalFare { get; set; }
        public int Tax { get; set; }
        public int ServiceTax { get; set; }
    }

    public class RequestFlight
    {
        public string FlightNumber { get; set; }
        public string FlightNo { get; set; }
        public string DepartureDate { get; set; }
        public string DepartureTime { get; set; }
        public string? ArrivalTime { get; set; }
        public string FlightType { get; set; }
        public string CabinType { get; set; }
        public string SeatClass { get; set; }
        public string Baggage { get; set; }
        public string AirlinePnr { get; set; }
        public int StopQuantity { get; set; }
        public string Duration { get; set; }
        public Airline Airline { get; set; }
        public Aircraft Aircraft { get; set; }
        public Departure Departure { get; set; }
        public Arrival Arrival { get; set; }
    }

    public class RequestPassenger
    {
        public string PassengerType { get; set; }
    }

    public class FlightRequestPreReserveDTO
    {
        public Request Request { get; set; }
        public Member Member { get; set; }
        public Supplier Supplier { get; set; }
        public SearchHistory SearchHistory { get; set; }
        public List<PassengerInput> PassengerInput { get; set; }
    }



}
