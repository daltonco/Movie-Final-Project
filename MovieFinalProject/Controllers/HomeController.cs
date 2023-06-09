﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieFinalProject.Models;
using System.Diagnostics;

namespace MovieFinalProject.Controllers
{
    public class HomeController : Controller
    {
        private MovieContext context { get; set; }

        public HomeController(MovieContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            var movies = context.Movies.Include(m => m.Genre)
                .OrderBy(m => m.Name).ToList();
            return View(movies);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        
        public IActionResult AboutEthan()
        {
            return View();
        }

        public IActionResult AboutColton()

        {
            return View();
        }

        public IActionResult AboutRishabh()

        {
            return View();
        }
    }
}