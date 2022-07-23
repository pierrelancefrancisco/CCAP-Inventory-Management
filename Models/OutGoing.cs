using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CCAP_Inventory_Management.Models
{
    public class OutGoing
    {
        [Key]
        public int OutGoingProductID { get; set; }

        [Required(ErrorMessage = "This is required")]
        [Display(Name = "Product Name")]
        public string OutGoingProductName { get; set; }


        [Required(ErrorMessage = "This is requried")]
        [Display(Name = "Quantity")]
        public int OutGoingQuantity { get; set; }

        [Required(ErrorMessage = "This is required")]
        [Display(Name = "Supplier Name")]
        public string OutGoingSupplierName { get; set; }

        [Required(ErrorMessage = "This is required")]
        [Display(Name = "Location")]
        public string OutGoingLocation { get; set; }

        [Display(Name ="Category")]
        public OutGoingProductCat OutGoingCategory { get; set; }

        [Display(Name = "Status")]
        public OutGoingStat OutGoingStatus { get; set; }

        public enum OutGoingProductCat
        {
            BagAndAccessories = 0,
            Ornaments = 1,
            Decor = 2,
            HolidayDecor = 3,
            HomeDecore = 4
        }
        
        public enum OutGoingStat
        {
            Delivering = 0,
            Delivered = 1,
            NoInfo = 2
        }

    }
}
