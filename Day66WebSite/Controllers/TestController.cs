using Day66WebSite.Models.Services;
using Microsoft.AspNetCore.Mvc;

namespace Day66WebSite.Controllers
{
    public class TestController : Controller
    {
        private readonly IFlightService _testService;

        public TestController(IFlightService testService)
        {
            _testService = testService;
        }

        public async Task<IActionResult> TestFlights()
        {
            var flights = await _testService.GetAllAsync();

            return View(flights);
        }
    }
}
