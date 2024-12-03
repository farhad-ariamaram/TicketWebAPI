namespace TicketWebAPI.DTOs
{
    public class FlightRegionDTO
    {
        public Result Result { get; set; }
        public List<Region> Regions { get; set; }
    }

    public class Region
    {
        public int RegionID { get; set; }
        public string RegionName { get; set; }
        public string FaRegionName { get; set; }
        public string Code { get; set; }
        public ParentRegion? ParentRegion { get; set; }
        public Type? Type { get; set; }
    }

    public class ParentRegion
    {
        public int RegionID { get; set; }
        public string RegionName { get; set; }
        public string FaRegionName { get; set; }
        public string Code { get; set; }
        public ParentRegion? Parent { get; set; }
        public Type? Type { get; set; }
    }

    public class Type
    {
        public int TypeID { get; set; }
        public string TypeTitle { get; set; }
    }

    public class Result
    {
        public string Type { get; set; }
        public string Message { get; set; }
        public int Code { get; set; }
    }

}
