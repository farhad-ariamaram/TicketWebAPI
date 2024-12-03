namespace TicketWebAPI.DTOs
{
    public class FlightRequestReserveDTO
    {
        public Request Request { get; set; }
        public Member Member { get; set; }
        public Supplier Supplier { get; set; }
        public SearchHistory SearchHistory { get; set; }
    }
}
