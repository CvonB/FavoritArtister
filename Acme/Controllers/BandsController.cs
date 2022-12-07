﻿using FavoritArtister.Models;
using Microsoft.AspNetCore.Mvc;

namespace FavoritArtister.Controllers
{
    public class BandsController : Controller
    {

        BandService service;
        public BandsController() { 
            service = new BandService();
        }

        [HttpGet(""), HttpGet("index"), HttpGet("bands")]
        public IActionResult Index()
        {
            var model = service.GetAllBands();
            return View(model);
        }

        [HttpGet("details/{BandId}")]
        public IActionResult bandPage(int BandId)
        {
            var model = service.GetBandByID(BandId);
            return Content(model.Description);
        }
    }
}
