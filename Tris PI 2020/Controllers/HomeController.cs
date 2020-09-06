using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using Tris_PI_2020.Services;
using Tris_PI_2020.ViewModels;

namespace Tris_PI_2020.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProductService productService;

        public HomeController()
        {
            productService = new ProductService();
        }

        public ViewResult Index()
        {
            ViewBag.Title = "Title from controller";
            TimeSpan doZvonka = DateTime.Parse("12:50") - DateTime.Now;
            return View(new HelloVM
            {
                Message = "Test message",
                DoZvonka = (int)doZvonka.TotalMinutes
            });

        }

        public ViewResult List()
        {
            return View(productService.GetAll());
        }

        [HttpGet]
        public ViewResult Search()
        {
            ViewBag.Categories = new List<SelectListItem> {
                    new SelectListItem { Value = "1", Text = "Клавиатуры"},
                    new SelectListItem { Value = "2", Text = "Мышки"},
                    new SelectListItem { Value = "3", Text = "Мониторы" }
                };

            return View();
        }

        [HttpPost]
        public ViewResult Search(SearchRequestData searchRequestData)
        {
            //Обработка запроса
            return View("ProcessedSearch", searchRequestData);
        }


    }
}
