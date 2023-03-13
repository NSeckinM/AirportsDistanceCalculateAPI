using AirportsDistanceCalculateAPI.DTO;
using System.Threading.Tasks;

namespace AirportsDistanceCalculateAPI.Interfaces
{
    public interface IAirportService
    {
        Task<ReturnType> CalculateDistance(string Iata1, string Iata2);


    }
}
