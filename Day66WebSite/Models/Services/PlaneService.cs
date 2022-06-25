using Day66WebSite.Models.Dtos;
using Day66WebSite.Models.Services.Interfaces;
using Newtonsoft.Json;
using System.Diagnostics;

namespace Day66WebSite.Models.Services
{
    public class PlaneService : IPlaneService
    {
        private readonly HttpClient _httpClient;

        public PlaneService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<PlaneDto>> GetAllAsync()
        {
            Debug.Assert(_httpClient.BaseAddress != null);
            var uri = new Uri(_httpClient.BaseAddress, "/api/PlaneModels");
            var responceText = await _httpClient.GetStringAsync(uri);
            var planeResponceDto = JsonConvert.DeserializeObject<List<PlaneDto>>(responceText);
            return planeResponceDto;
        }
    }
}
