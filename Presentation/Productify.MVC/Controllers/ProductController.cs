using Microsoft.AspNetCore.Mvc;
using Productify.Domain.Entities;
using Productify.Persistence.Contexts;

namespace Productify.MVC.Controllers
{
    public class ProductController : Controller
    {

        ProductifyDbContext context;

        public ProductController()
        {
            context = new();
        }

        public IActionResult GetAll()   //localhost:port/product/getall  controller ismi, action ismi :) view ismi metot ismiyle aynı olmalı yani getall olmalı :)
        {
            return View(context.Products.ToList());
        }

        public IActionResult AddProduct()
        {
            return View();
        }
    }
}
