using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CCAP_Inventory_Management.Data;
using CCAP_Inventory_Management.Models;

namespace CCAP_Inventory_Management.Controllers
{
    public class ArchiveController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ArchiveController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var list = _context.Archives.ToList();
            return View(list);
        }
    }
}
