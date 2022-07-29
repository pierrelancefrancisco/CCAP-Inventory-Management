using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using CCAP_Inventory_Management.Data;
using CCAP_Inventory_Management.Models;

namespace CCAP_Inventory_Management.Controllers
{
    public class IncomingController : Controller
    {
        private readonly ApplicationDbContext _context;

        public IncomingController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var list = _context.Incoming.ToList();
            return View(list);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(OutGoing record)
        {
            var Incoming = new Incoming()
            {
                IncomingProductName = record.IncomingProductName,
                IncomingSupplierName = record.IncomingSupplierName,
                IncomnigQuantity = record.IncomnigQuantity,
                IncomingLocation = record.IncomingLocation,
                IncomingCategory = record.IncomingCategory,
                IncomingStatus = record.IncomingStatus
            };
            _context.OutGoings.Add(Incoming);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var Incoming = _context.Incoming.Where(i => i.IncomngProductID == id).SingleOrDefault();
            if (Incoming == null)
            {
                return RedirectToAction("Index");
            }
            return View(Incoming);
        }

        [HttpPost]
        public IActionResult Edit(int? id, OutGoing record)
        {
            var Incoming = _context.Incoming.Where(i => i.IncomngProductID == id).SingleOrDefault();
            IncomingProductName = record.IncomingProductName,
                IncomingSupplierName = record.IncomingSupplierName,
                IncomnigQuantity = record.IncomnigQuantity,
                IncomingLocation = record.IncomingLocation,
                IncomingCategory = record.IncomingCategory,
                IncomingStatus = record.IncomingStatus

            _context.Incoming.Update(Incoming);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var Incoming = _context.Incoming.Where(i => i.IncomngProductID == id).SingleOrDefault();
            if (Incoming == null)
            {
                return RedirectToAction("Index");
            }
            _context.Incoming.Remove(Incoming);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
