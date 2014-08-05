﻿using Classifieds.Models;
using Classifieds.Models.SearchViewModels;
using Classifieds.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace Classifieds.Controllers
{
    [RequireHttps]
    public class HomeController : Controller
    {
        
        private ApplicationDbContext db = new ApplicationDbContext();

        public HomeController() { }

        public ActionResult Index()
        {
            AListingSearchModel  listingSearchModel = new ListingSearchViewModel();
            ViewBag.searchViewModel = listingSearchModel;
            return View(listingSearchModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}