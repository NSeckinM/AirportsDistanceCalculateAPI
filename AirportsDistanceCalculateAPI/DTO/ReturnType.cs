using AirportsDistanceCalculateAPI.Model;

namespace AirportsDistanceCalculateAPI.DTO
{
    public class ReturnType
    {
        public AirportInfo Airport1 { get; set; }
        public AirportInfo Airport2 { get; set; }
        public double DistanceBetweenAirportsAsMile { get; set; }


    }
}
