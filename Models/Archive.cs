﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CCAP_Inventory_Management.Models
{
    public class Archive
    {
        [Key]
        public int ProductID { get; set; }

        [Required(ErrorMessage = "This is required")]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "This is required")]
        [Display(Name = "Quantity")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "This is required")]
        [Display(Name = "Supplier Name")]
        public string SupplierName { get; set; }

        [Required(ErrorMessage = "This is required")]
        [Display(Name = "Location")]
        public string Location { get; set; }

        public ProdCategory Category { get; set; }

        public ProdStatus Status { get; set; }

    }

    public enum ProdCategory
    {
        BagAndAccesories = 0,
        Ornaments = 1,
        Decor = 2,
        HolidayDecor = 3,
        HomeDecore = 4
    }

    public enum ProdStatus
    {
        Delivering = 0,
        Delivered = 1,
        NoInfo = 2
    }
}

