using Day66WebSite.Models.Dtos;

namespace Day66WebSite.Models.Services.Interfaces
{
    public interface IPlaneService
    {
        Task<List<PlaneDto>> GetAllAsync();
    }
}
