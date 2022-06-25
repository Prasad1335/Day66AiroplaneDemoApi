
using Day66WebSite.Models.Dtos;

public interface IFlightService
{
    Task<List<FlightDto>> GetAllAsync();
}
