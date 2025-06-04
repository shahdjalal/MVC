using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {

        ApplicationDbContext context = new ApplicationDbContext();
      
       
        public ViewResult Index()
        {
            var products = context.Products.ToList(); 
            return View(products); 
        }

        public ViewResult Details( int id)
        {
            Console.WriteLine($"product {id}");
            var products = context.Products.Find(id); 
            return View(products);
        }

        public ViewResult Create()
        {
           
            return View();
        }
    }
}
