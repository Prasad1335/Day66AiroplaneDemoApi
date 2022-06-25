using Day66WebSite.Models.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Day66WebSite.Controllers
{
    public class PlaneController : Controller
    {
        private readonly IPlaneService _planeServices;

        public PlaneController(IPlaneService planeServices)
        {
            _planeServices = planeServices;
        }
        public async Task<IActionResult> Index()
        {
            var planes = await _planeServices.GetAllAsync();
            return View(planes);
        }
    }
}
