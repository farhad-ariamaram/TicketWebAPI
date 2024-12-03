namespace TicketWebAPI.DTOs
{
    public class Crawler
    {
        public string Url { get; set; }
    }

    public class Member
    {
        public string Username { get; set; }
        public int Balance { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
    }

    public class FlightRequestRevalidate
    {
        public string SessionID { get; set; }
        public Flight Flight { get; set; }
        public Member Member { get; set; }
        public SearchHistory SearchHistory { get; set; }
    }

    public class SearchHistory
    {
        public string SearchHistoryID { get; set; }
        public int AdultCount { get; set; }
        public int ChildCount { get; set; }
        public int InfantCount { get; set; }
        public string DepartureCode { get; set; }
        public string ArrivalCode { get; set; }
        public string DepartureDate { get; set; }
        public string CabinType { get; set; }
        public string CreateBy { get; set; }
        public string TripType { get; set; }
        public string CreateDate { get; set; }
        public string Manufacturer { get; set; }
        public string SearchType { get; set; }
        public string Status { get; set; }
    }

}
