namespace TicketWebAPI.DTOs
{
    public class RequestPassengersDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PersianFirstName { get; set; }
        public string PersianLastName { get; set; }
        public PassengerTitleEnum PassengerTitle { get; set; }
        public DateTime DateOfBirth { get; set; }
        public PassengerTypeEnum PassengerType { get; set; }
        public string NationalCode { get; set; }
        public string PassportNumber { get; set; }
        public string PassportExpireDate { get; set; }
        public string Nationality { get; set; }
        public string CountryCode { get; set; }
        public string AreaCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string DocumentType { get; set; }
    }

    public enum PassengerTitleEnum
    {
        Mr = 0,
        Mrs = 1
    }

    public enum PassengerTypeEnum
    {
        Adt,
        Chd,
        Inf
    }
}
