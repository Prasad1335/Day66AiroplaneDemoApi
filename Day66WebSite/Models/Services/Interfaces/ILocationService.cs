using Day66WebSite.Models.Dtos;

namespace Day66WebSite.Models.Services.Interfaces;

public interface ILocationService
{
    Task<LocationDto?> GetByIdAsync(int id);
    Task AddAsync(LocationDto locationDto);
    Task DeleteAsync(int id);
}
