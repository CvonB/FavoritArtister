using FavoritArtister.Models;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics;
using System.IO.Pipelines;
using System.Net.NetworkInformation;
using System.Numerics;

namespace FavoritArtister.Controllers
{
    public class BandsController : Controller
    {

        BandService service;
        public BandsController()
        {
            service = new BandService();
        }

        [HttpGet(""), HttpGet("index"), HttpGet("bands")]
        public IActionResult Index()
        {

            var model = service.GetAllBands();


            return View(model);
        }

        [HttpGet("details/{BandId}")]
        public IActionResult details(int BandId)
        {
            var model = service.GetBandByID(BandId);
            return View(model);
        }
    }
}
