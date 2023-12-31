﻿using Microsoft.AspNetCore.Mvc;
using Services;
using ServiceContracts;

namespace InversionOfControlDICoreMVC6.Controllers
{
  public class HomeController : Controller
  {
    private readonly ICitiesService _citiesService;

    //constructor
    public HomeController()
    {
      //create object of CitiesService class
      _citiesService = null; //new CitiesService();
    }

    [Route("/")]
    public IActionResult Index()
    {
      List<string> cities = _citiesService.GetCities();
      return View(cities);
    }
  }
}
