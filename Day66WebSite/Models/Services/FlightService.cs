using System.Diagnostics;
using Day66WebSite.Models.Dtos;
using Newtonsoft.Json;

namespace Day66WebSite.Models.Services;

public class FlightService :  IFlightService
{
    private readonly HttpClient _httpClient;

    public FlightService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<FlightDto>> GetAllAsync()
    {
        Debug.Assert(_httpClient.BaseAddress != null);

        var uri = new Uri(_httpClient.BaseAddress, "/api/Flights");

        var responseText = await _httpClient.GetStringAsync(uri);

        var test1ResponseDto = JsonConvert.DeserializeObject<List<FlightDto>>(responseText);

        return test1ResponseDto;
    }

    public void Test2()
    {
        Debug.Assert(_httpClient.BaseAddress != null);

        var uri = new Uri(_httpClient.BaseAddress, "/api/Locations");

        //_httpClient.
    }

    public void Test3()
    {
        Debug.Assert(_httpClient.BaseAddress != null);

        var uri = new Uri(_httpClient.BaseAddress, "/api/Locations");

        //_httpClient.
    }
}
