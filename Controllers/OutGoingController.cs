using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using CCAP_Inventory_Management.Data;
using CCAP_Inventory_Management.Models;

namespace CCAP_Inventory_Management.Controllers
{
    public class OutGoingController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OutGoingController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var list = _context.OutGoings.ToList();
            return View(list);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(OutGoing record)
        {
            var outgoing = new OutGoing()
            {
                OutGoingProductName = record.OutGoingProductName,
                OutGoingSupplierName = record.OutGoingSupplierName,
                OutGoingQuantity = record.OutGoingQuantity,
                OutGoingLocation = record.OutGoingLocation,
                OutGoingCategory = record.OutGoingCategory,
                OutGoingStatus = record.OutGoingStatus
            };
            _context.OutGoings.Add(outgoing);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var outgoing = _context.OutGoings.Where(i => i.OutGoingProductID == id).SingleOrDefault();
            if (outgoing == null)
            {
                return RedirectToAction("Index");
            }
            return View(outgoing);
        }

        [HttpPost]
        public IActionResult Edit(int? id, OutGoing record)
        {
            var outgoing = _context.OutGoings.Where(i => i.OutGoingProductID == id).SingleOrDefault();
            outgoing.OutGoingProductName = record.OutGoingProductName;
            outgoing.OutGoingSupplierName = record.OutGoingSupplierName;
            outgoing.OutGoingQuantity = record.OutGoingQuantity;
            outgoing.OutGoingLocation = record.OutGoingLocation;
            outgoing.OutGoingCategory = record.OutGoingCategory;
            outgoing.OutGoingStatus = record.OutGoingStatus;

            _context.OutGoings.Update(outgoing);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var outgoing = _context.OutGoings.Where(i => i.OutGoingProductID == id).SingleOrDefault();
            if(outgoing == null)
            {
                return RedirectToAction("Index");
            }
            _context.OutGoings.Remove(outgoing);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
