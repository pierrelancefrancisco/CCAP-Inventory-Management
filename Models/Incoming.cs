using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CCAP_Inventory_Management.Models
{
    public class Incoming
    {
        [Key]
        public int IncomngProductID { get; set; }

        [Required(ErrorMessage = "This is required")]
        [Display(Name = "Product Name")]
        public string IncomingProductName { get; set; }


        [Required(ErrorMessage = "This is requried")]
        [Display(Name = "Quantity")]
        public int IncomnigQuantity { get; set; }

        [Required(ErrorMessage = "This is required")]
        [Display(Name = "Supplier Name")]
        public string IncomingSupplierName { get; set; }

        [Required(ErrorMessage = "This is required")]
        [Display(Name = "Location")]
        public string IncomingLocation { get; set; }

        [Display(Name ="Category")]
        public IncomingProductCat IncomingCategory { get; set; }

        [Display(Name = "Status")]
        public IncomingStat IncomingStatus { get; set; }

        public enum IncomingProductCat
        {
            BagAndAccessories = 0,
            Ornaments = 1,
            Decor = 2,
            HolidayDecor = 3,
            HomeDecore = 4
        }
        
        public enum IncomingStat
        {
            Delivering = 0,
            Delivered = 1,
            NoInfo = 2
        }

    }
}
