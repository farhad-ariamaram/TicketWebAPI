using Microsoft.AspNetCore.Mvc;
using TicketWebAPI.DTOs;

namespace TicketWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightRequestController : ControllerBase
    {
        [HttpPost("Revalidate/{ApiKey}")]
        public IActionResult Revalidate(string ApiKey, [FromBody] UserDTO userDTO)
        {
            if (string.IsNullOrEmpty(ApiKey)) { return BadRequest(); }
            if (ApiKey != "68003d3d-83de-4b39-a7c0-7b55c1adcc59") { return BadRequest(); }

            var res = new FlightRequestRevalidate();
            res.SessionID = "2aa35fb1-240e-43f9-bddd-a747b5985c9e";
            res.Member = new Member
            {
                Username = "username",
                Balance = 37100,
                Mobile = "09123456789",
                Email = "email@hiholiday.ir"
            };
            res.SearchHistory = new SearchHistory
            {
                SearchHistoryID = "2aa35fb1-240e-43f9-bddd-a747b5985c9e",
                AdultCount = 1,
                ChildCount = 0,
                InfantCount = 0,
                DepartureCode = "IKA",
                ArrivalCode = "DXB",
                DepartureDate = "2019-06-26T08=00=00",
                CabinType = "C",
                CreateBy = "username",
                TripType = "OneWay",
                Manufacturer = "HiHolidayApi",
                SearchType = "Flight",
                Status = "Revalidate"
            };
            res.Flight = new Flight
            {

                FlightID = 115685512,
                FlightNo = "061",
                DepartureDate = "2019-06-26T08=00=00",
                PersianDepartureDate = "۱۳۹۸/۴/۵",
                DepartureTime = "8=00 AM",
                ArrivalTime = "09=30",
                AdtPrice = 3007200,
                ChdPrice = 2324700,
                InfPrice = 308000,
                Capacity = 9,
                FlightType = "System",
                Commission = 0,
                Description = "",
                SeatClass = "C",
                Reservable = true,
                DisplayMode = 0,
                Manufacturer = "PYA",
                Supplier = new Supplier
                {
                    Name = "های هالیدی",
                    Logo = "",
                    Website = "www.hiholiday.ir",
                    Crawler = new Crawler
                    {
                        Url = "https=//HiHoliday.ir"
                    }
                },
                Airline = new Airline
                {
                    Name = "ماهان ایر",
                    Code = "W5",
                    Logo = "https=//storage.hiholiday.ir/File/AirlineLogo/W5.png"
                },
                Aircraft = new Aircraft
                {
                    Code = "310",
                    Manufacturer = "Airbus",
                    Name = "A310"
                },
                Departure = new Departure
                {
                    RegionName = "فرودگاه امام خمینی",
                    Code = "IKA",
                    ParentRegion = new ParentRegion
                    {
                        RegionName = "تهران"
                    }
                },
                Arrival = new Arrival
                {
                    RegionName = "فرودگاه دبی",
                    Code = "DXB",
                    ParentRegion = new ParentRegion
                    {
                        RegionName = "دبی"
                    }
                }
            };

            return Ok(res);
        }

        [HttpPost("PreReserve/{ApiKey}/{SessionID}")]
        public IActionResult PreReserve(string ApiKey, string SessionID)
        {
            if (string.IsNullOrEmpty(ApiKey)) { return BadRequest(); }
            if (ApiKey != "68003d3d-83de-4b39-a7c0-7b55c1adcc59") { return BadRequest(); }
            if (SessionID != "2aa35fb1-240e-43f9-bddd-a747b5985c9e") { return BadRequest(); }

            var res = new FlightRequestPreReserveDTO();
            res.Request = new Request
            {
                SearchHistoryID = "2aa35fb1-240e-43f9-bddd-a747b5985c9e",
                RequestNumber = "55666296620",
                CreateDate = "2019-06-20T23=25=06",
                CreateBy = "---",
                Status = "PreReserve",
                TimeLimit = "2019-06-20T23=30=06",
                SupplierName = "های هالیدی",
                TotalFare = 3007200,
                RequestFares = new List<RequestFare>
                {
                    new RequestFare
                    {
                      Type= "Sale",
                      BaseFare= 3007200,
                      Commission= 0,
                      Markup= 0,
                      PassengerCount= 1,
                      PassengerType= "Adt",
                      TotalFare= 3007200,
                      Tax= 0,
                      ServiceTax= 0
                    }
                },
                RequestPassengers = new List<RequestPassenger>
                {
                    new RequestPassenger{PassengerType = "Adt"}
                },
                RequestFlights = new List<RequestFlight>
                {
                    new RequestFlight
                    {
                        FlightNumber= "061",
                        FlightNo= "061",
                        DepartureDate= "2019-06-26T08=00=00",
                        DepartureTime= "8=00 AM",
                        ArrivalTime= null,
                        FlightType= "System",
                        CabinType= "I",
                        SeatClass= "C",
                        Baggage= "",
                        AirlinePnr= "",
                        StopQuantity= 0,
                        Duration= "",
                        Airline= new Airline {
                            Name= "ماهان ایر",
                            Code= "W5",
                            Logo= "http=//storage.hiholiday.ir/File/AirlineLogo/W5.png"
                        },
                        Aircraft= new Aircraft {
                            Code= "310",
                            Manufacturer= "Airbus",
                            Name= "A310"
                        },
                        Departure= new Departure {
                            RegionName= "فرودگاه امام خمینی",
                            Code= "IKA",
                            ParentRegion= new ParentRegion {
                                RegionName= "تهران"
                            }
                        },
                            Arrival= new Arrival {
                            RegionName= "فرودگاه دبی",
                            Code= "DXB",
                            ParentRegion= new ParentRegion {
                                RegionName= "دبی"
                            }
                        }
                    }
                }
            };
            res.Member = new Member
            {
                Username = "----",
                Balance = 37100,
                Mobile = "09123456789",
                Email = "mail@hiholiday.ir"
            };
            res.Supplier = new Supplier
            {
                Name = "های هالیدی",
                ManagerName = "",
                Website = "www.hiholiday.ir",
                Phone1 = "021-26654653",
                Phone2 = "021-26654653",
                Fax = "",
                Email = "sales@hiholiday.ir",
                PostalCode = "",
                ManagerMobile = "",
                LicenseNo = "",
                CountryName = "ایران",
                CityName = "تهران",
                Address = "شهرک غرب میدان کتاب آسمان 12 پلاک 36 طبقه 4",
                AgentName = "",
                AgentMobile = "09353303023",
                AgentPhone = "021-26654653",
                AgentEmail = "",
                Logo = "",
                LatLang = ""
            };
            res.SearchHistory = new SearchHistory
            {
                SearchHistoryID = "2aa35fb1-240e-43f9-bddd-a747b5985c9e",
                AdultCount = 1,
                ChildCount = 0,
                InfantCount = 0,
                DepartureCode = "IKA",
                ArrivalCode = "DXB",
                DepartureDate = "2019-06-26T08=00=00",
                CabinType = "C",
                CreateBy = "iman",
                CreateDate = "2019-06-20T22=32=00",
                TripType = "OneWay",
                Manufacturer = "HiHolidayApi",
                SearchType = "Flight",
                Status = "PreReserve"
            };
            res.PassengerInput = new List<PassengerInput>();
            res.PassengerInput.Add(new PassengerInput
            {
                PassengerType = "Adt",
                PersianName = false,
                EnglishName = true,
                NationalCode = true,
                PassportNumber = false,
                PassportExpiryDate = false,
                DateOfBirth = false
            });
            res.PassengerInput.Add(new PassengerInput
            {
                PassengerType = "Chd",
                PersianName = false,
                EnglishName = true,
                NationalCode = true,
                PassportNumber = false,
                PassportExpiryDate = false,
                DateOfBirth = false
            });
            res.PassengerInput.Add(new PassengerInput
            {
                PassengerType = "Inf",
                PersianName = false,
                EnglishName = true,
                NationalCode = true,
                PassportNumber = false,
                PassportExpiryDate = false,
                DateOfBirth = true
            });
            return Ok(res);
        }

        [HttpPost("Book/{ApiKey}/{RequestNumber}")]
        public IActionResult Book(string ApiKey, string RequestNumber, [FromBody] List<RequestPassengersDTO> requestPassengersDTO)
        {
            if (string.IsNullOrEmpty(ApiKey)) { return BadRequest(); }
            if (ApiKey != "68003d3d-83de-4b39-a7c0-7b55c1adcc59") { return BadRequest(); }
            if (RequestNumber != "55666296620") { return BadRequest(); }

            var res = new List<FlightRequestBookDTO>();
            res.Add(new FlightRequestBookDTO
            {
                FirstName = "test",
                LastName = "test",
                PersianFirstName = "تست",
                PersianLastName = "تست",
                PassengerTitle = "Mr",
                DateOfBirth = "1983-01-01",
                PassengerType = "Adt",
                NationalCode = "1630028304",
                PassportNumber = "",
                PassportExpireDate = "",
                Nationality = "IR",
                AreaCode = "21",
                CountryCode = "98",
                PhoneNumber = "44044269",
                Email = "office@hiholiday.ir",
                DocumentType = "NIC"
            });

            return Ok(res);
        }

        [HttpPost("Reserve/{ApiKey}/{RequestNumber}")]
        public IActionResult Reserve(string ApiKey, string RequestNumber)
        {
            if (string.IsNullOrEmpty(ApiKey)) { return BadRequest(); }
            if (ApiKey != "68003d3d-83de-4b39-a7c0-7b55c1adcc59") { return BadRequest(); }
            if (RequestNumber != "55666296620") { return BadRequest(); }

            var res = new FlightRequestReserveDTO();
            res.Request = new Request
            {
                SearchHistoryID = "2aa35fb1-240e-43f9-bddd-a747b5985c9e",
                RequestNumber = "55666296620",
                CreateDate = "2019-06-20T23=25=06",
                CreateBy = "---",
                Status = "PreReserve",
                TimeLimit = "2019-06-20T23=30=06",
                SupplierName = "های هالیدی",
                TotalFare = 3007200,
                RequestFares = new List<RequestFare>
                {
                    new RequestFare
                    {
                      Type= "Sale",
                      BaseFare= 3007200,
                      Commission= 0,
                      Markup= 0,
                      PassengerCount= 1,
                      PassengerType= "Adt",
                      TotalFare= 3007200,
                      Tax= 0,
                      ServiceTax= 0
                    }
                },
                RequestPassengers = new List<RequestPassenger>
                {
                    new RequestPassenger{PassengerType = "Adt"}
                },
                RequestFlights = new List<RequestFlight>
                {
                    new RequestFlight
                    {
                        FlightNumber= "061",
                        FlightNo= "061",
                        DepartureDate= "2019-06-26T08=00=00",
                        DepartureTime= "8=00 AM",
                        ArrivalTime= null,
                        FlightType= "System",
                        CabinType= "I",
                        SeatClass= "C",
                        Baggage= "",
                        AirlinePnr= "",
                        StopQuantity= 0,
                        Duration= "",
                        Airline= new Airline {
                            Name= "ماهان ایر",
                            Code= "W5",
                            Logo= "http=//storage.hiholiday.ir/File/AirlineLogo/W5.png"
                        },
                        Aircraft= new Aircraft {
                            Code= "310",
                            Manufacturer= "Airbus",
                            Name= "A310"
                        },
                        Departure= new Departure {
                            RegionName= "فرودگاه امام خمینی",
                            Code= "IKA",
                            ParentRegion= new ParentRegion {
                                RegionName= "تهران"
                            }
                        },
                            Arrival= new Arrival {
                            RegionName= "فرودگاه دبی",
                            Code= "DXB",
                            ParentRegion= new ParentRegion {
                                RegionName= "دبی"
                            }
                        }
                    }
                }
            };
            res.Member = new Member
            {
                Username = "----",
                Balance = 37100,
                Mobile = "09123456789",
                Email = "mail@hiholiday.ir"
            };
            res.Supplier = new Supplier
            {
                Name = "های هالیدی",
                ManagerName = "",
                Website = "www.hiholiday.ir",
                Phone1 = "021-26654653",
                Phone2 = "021-26654653",
                Fax = "",
                Email = "sales@hiholiday.ir",
                PostalCode = "",
                ManagerMobile = "",
                LicenseNo = "",
                CountryName = "ایران",
                CityName = "تهران",
                Address = "شهرک غرب میدان کتاب آسمان 12 پلاک 36 طبقه 4",
                AgentName = "",
                AgentMobile = "09353303023",
                AgentPhone = "021-26654653",
                AgentEmail = "",
                Logo = "",
                LatLang = ""
            };
            res.SearchHistory = new SearchHistory
            {
                SearchHistoryID = "2aa35fb1-240e-43f9-bddd-a747b5985c9e",
                AdultCount = 1,
                ChildCount = 0,
                InfantCount = 0,
                DepartureCode = "IKA",
                ArrivalCode = "DXB",
                DepartureDate = "2019-06-26T08=00=00",
                CabinType = "C",
                CreateBy = "iman",
                CreateDate = "2019-06-20T22=32=00",
                TripType = "OneWay",
                Manufacturer = "HiHolidayApi",
                SearchType = "Flight",
                Status = "PreReserve"
            };

            return Ok(res);
        }
    }
}
