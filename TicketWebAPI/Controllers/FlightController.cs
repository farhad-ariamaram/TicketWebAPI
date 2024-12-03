using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using TicketWebAPI.DTOs;

namespace TicketWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightController : ControllerBase
    {
        [HttpGet("regions/{ApiKey}")]
        public IActionResult Regions(string ApiKey)
        {
            if (string.IsNullOrEmpty(ApiKey)) { return BadRequest(); }
            if (ApiKey != "68003d3d-83de-4b39-a7c0-7b55c1adcc59") { return BadRequest(); }

            var res = new FlightRegionDTO();
            res.Result = new Result { Code = 0, Message = "", Type = "Success" };
            res.Regions = new List<Region>();

            res.Regions.Add(new Region
            {
                RegionID = 514,
                RegionName = "Mehrabad International Airport",
                FaRegionName = "فرودگاه مهرآباد",
                Code = "THR",
                ParentRegion = new ParentRegion
                {
                    RegionID = 107,
                    RegionName = "Tehran",
                    FaRegionName = "تهران",
                    Code = "THR",
                    Parent = null,
                    Type = null
                },
                Type = new DTOs.Type
                {
                    TypeID = 41,
                    TypeTitle = "Airport"
                }
            });

            res.Regions.Add(new Region
            {
                RegionID = 515,
                RegionName = "Ahwaz International Airport",
                FaRegionName = "فرودگاه اهواز",
                Code = "AWZ",
                ParentRegion = new ParentRegion
                {
                    RegionID = 108,
                    RegionName = "Ahvaz",
                    FaRegionName = "اهواز",
                    Code = "AWZ",
                    Parent = null,
                    Type = null
                },
                Type = new DTOs.Type
                {
                    TypeID = 41,
                    TypeTitle = "Airport"
                }
            });

            res.Regions.Add(new Region
            {
                RegionID = 516,
                RegionName = "Kish international airport",
                FaRegionName = "فرودگاه خلیج فارس کیش",
                Code = "KIH",
                ParentRegion = new ParentRegion
                {
                    RegionID = 64,
                    RegionName = "Kish",
                    FaRegionName = "کیش",
                    Code = "KIH",
                    Parent = null,
                    Type = null
                },
                Type = new DTOs.Type
                {
                    TypeID = 41,
                    TypeTitle = "Airport"
                }
            });

            return Ok(res);
        }

        [HttpGet("oneway/{ApiKey}/{DepartureCode}/{ArrivalCode}/{DepartureDate}/{Capacity:int}/{pageSize:int}/{PageNumber:int}")]
        public IActionResult Oneway(string ApiKey)
        {
            if (string.IsNullOrEmpty(ApiKey)) { return BadRequest(); }
            if (ApiKey != "68003d3d-83de-4b39-a7c0-7b55c1adcc59") { return BadRequest(); }

            var res = new FlightOneway();
            res.DepartureFlights = new List<DepartureFlight>();
            res.DepartureFlights.Add(new DepartureFlight
            {
                FlightID = 113897065,
                FlightNo = "962",
                DepartureDate = "2019-07-23T10=35=00",
                PersianDepartureDate = "۱۳۹۸/۵/۱",
                DepartureTime = "10=35 AM",
                ArrivalTime = null,
                AdtPrice = 380000,
                ChdPrice = 285000,
                InfPrice = 38000,
                Capacity = 9,
                FlightType = "",
                IsForeign = false,
                Description = "",
                SeatClass = "Y",
                CabinType = "Y",
                Reservable = true,
                DisplayMode = 2,
                Manufacturer = "MS",
                UpdTime = "2019-06-06T13=08=00",
                Supplier = new Supplier
                {
                    SupplierID = 2380,
                    Name = "آسمان پرواز ایرانیان",
                    Logo = "https=//storage.hiholiday.ir/File/SupplierLogo/2380.png",
                    Website = "https=//www.markazetour.com"
                },
                Airline = new Airline
                {
                    Name = "ایران ایرتور",
                    Code = "B9",
                    Logo = "https=//storage.hiholiday.ir/File/AirlineLogo/B9.png"
                },
                Aircraft = new Aircraft
                {
                    Code = "M82",
                    Manufacturer = "McDonnell Douglas",
                    Name = "MD-82"
                },
                Departure = new Departure
                {
                    RegionName = "فرودگاه مهرآباد",
                    Code = "THR",
                    ParentRegionName = "تهران"
                },
                Arrival = new Arrival
                {
                    RegionName = "فرودگاه شهید هاشمی نژاد مشهد",
                    Code = "MHD",
                    ParentRegionName = "مشهد"
                }
            });

            res.DepartureFlights.Add(new DepartureFlight
            {
                FlightID = 114600934,
                FlightNo = "962",
                DepartureDate = "2019-07-23T10=35=00",
                PersianDepartureDate = "۱۳۹۸/۵/۱",
                DepartureTime = "10=35 AM",
                ArrivalTime = null,
                AdtPrice = 380000,
                ChdPrice = 287100,
                InfPrice = 44210,
                Capacity = 9,
                FlightType = "",
                IsForeign = false,
                Description = "نماینده انحصاری ایران ایرتور با اطمینان خرید کنید .",
                SeatClass = "Y",
                CabinType = "Y",
                Reservable = true,
                DisplayMode = 0,
                Manufacturer = "SPS",
                UpdTime = "2019-06-06T12=09=00",
                Supplier = new Supplier
                {
                    SupplierID = 2380,
                    Name = "آسمان پرواز ایرانیان",
                    Logo = "http=//storage.hiholiday.ir/File/SupplierLogo/2380.png",
                    Website = "https=//markazetour.ir"
                },
                Airline = new Airline
                {
                    Name = "ایران ایرتور",
                    Code = "B9",
                    Logo = "http=//storage.hiholiday.ir/File/AirlineLogo/B9.png"
                },
                Aircraft = new Aircraft
                {
                    Code = "M82",
                    Manufacturer = "McDonnell Douglas",
                    Name = "MD-82"
                },
                Departure = new Departure
                {
                    RegionName = "فرودگاه مهرآباد",
                    Code = "THR",
                    ParentRegionName = "تهران"
                },
                Arrival = new Arrival
                {
                    RegionName = "فرودگاه شهید هاشمی نژاد مشهد",
                    Code = "MHD",
                    ParentRegionName = "مشهد"
                }
            });

            return Ok(res);
        }

        [HttpGet("CheckFlight/{ApiKey}/{FlightID:int}")]
        public IActionResult CheckFlight(string ApiKey, int FlightID)
        {
            if (string.IsNullOrEmpty(ApiKey)) { return BadRequest(); }
            if (ApiKey != "68003d3d-83de-4b39-a7c0-7b55c1adcc59") { return BadRequest(); }
            if (FlightID != 114318050) { return NotFound(); }

            var res = new CheckFlight();
            res.Result = new Result { Code = 0, Message = "", Type = "Success" };
            res.Flight = new Flight
            {
                FlightID = 114318050,
                FlightNo = "022",
                DepartureDate = "2019-06-08T05=25=00",
                PersianDepartureDate = "۱۳۹۸/۳/۱۸",
                DepartureTime = "5=25 AM",
                ArrivalTime = "",
                AdtPrice = 180000,
                ChdPrice = 135000,
                InfPrice = 50000,
                Capacity = 4,
                FlightType = "",
                IsForeign = false,
                Description = "",
                SeatClass = "B",
                CabinType = "B",
                Reservable = true,
                DisplayMode = 0,
                Manufacturer = "MS",
                UpdStatus = true,
                UpdTime = "2019-06-01T20=54=00",
                Supplier = new Supplier
                {
                    SupplierID = 2,
                    Name = "تک ستاره پاسداران",
                    Logo = "http=//storage.hiholiday.ir/File/SupplierLogo/2.png",
                    Website = "http=//www.tksp24.com"
                },
                Airline = new Airline
                {
                    Name = "کاسپین ایر",
                    Code = "IV",
                    Logo = "http=//storage.hiholiday.ir/File/AirlineLogo/Caspian.png"
                },
                Aircraft = new Aircraft
                {
                    Code = "BOE",
                    Manufacturer = "Boeing",
                    Name = "بوئینگ"
                },
                Departure = new Departure
                {
                    RegionName = "فرودگاه مهرآباد",
                    Code = "THR",
                    ParentRegionName = "تهران"
                },
                Arrival = new Arrival
                {
                    RegionName = "فرودگاه شهید هاشمی نژاد مشهد",
                    Code = "MHD",
                    ParentRegionName = "مشهد"
                }
            };
            return Ok(res);
        }
    }
}
