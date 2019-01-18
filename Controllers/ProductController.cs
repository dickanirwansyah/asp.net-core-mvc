using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcTest.Models;

namespace MvcTest.Controllers 
{   
    [Route("product")]
    public class ProductController : Controller 
    {

        private DataContext db = new DataContext();

        [Route("index")]
        [Route("")]
        [Route("~/")]
        public IActionResult Index()
        {   
            /** list product */
            ViewBag.product = db.Products.ToList();
            return View();
        }

        [HttpGet]
        [Route("Add")]
        public IActionResult Add()
        {
            return View("Add");
        }

        [HttpPost]
        [Route("Add")]
        public IActionResult ActionAdd(Product requestProduct)
        {
            db.Products.Add(requestProduct);
            db.SaveChanges();
            /** return index */
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("Delete/{Id}")]
        public IActionResult Delete(int Id)
        {
            Product product = db.Products.Find(Id);
            db.Products.Remove(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("Edit/{Id}")]
        public IActionResult Edit(int Id)
        {
            return View("Edit", 
                db.Products.Find(Id));
        }

        [HttpPost]
        [Route("Edit/{Id}")]
        public IActionResult ActionEdit(int Id, Product requestProduct)
        {
            db.Entry(requestProduct).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}