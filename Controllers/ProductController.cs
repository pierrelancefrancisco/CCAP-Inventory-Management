using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CCAP_Inventory_Management.Data;
using CCAP_Inventory_Management.Models;

namespace CCAP_Inventory_Management.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var list = _context.Products.ToList();
            return View(list);
        }

        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Products record)
        {
            var product = new Products()
            {
                ProductName = record.ProductName,
                SupplierName = record.SupplierName,
                Quantity = record.Quantity,
                Location = record.Location,
                Category = record.Category,
                Status = record.Status
            };
            _context.Products.Add(product);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }


        public IActionResult Edit(int? id)
        {
            if(id == null)
            {
                return RedirectToAction("Index");
            }
            var product = _context.Products.Where(i => i.ProductID == id).SingleOrDefault();
            if( product == null)
            {
                return RedirectToAction("Index");
            }
            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(int? id, Products record)
        {
            var product = _context.Products.Where(i => i.ProductID == id).SingleOrDefault();
            product.ProductName = record.ProductName;
            product.SupplierName = record.SupplierName;
            product.Quantity = record.Quantity;
            product.Location = record.Location;
            product.Category = record.Category;
            product.Status = record.Status;

            _context.Products.Update(product);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }



        public IActionResult Delete(int? id)
        {
            if(id == null)
            {
                return RedirectToAction("Index");
            }
            var product = _context.Products.Where(i => i.ProductID == id).SingleOrDefault();
            if(product == null)
            {
                return RedirectToAction("Index");
            }
            _context.Products.Remove(product);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}
