using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;


namespace MyInventory.Models
{
    public class Item
    {
        [Key]
        public int SupplierId { get; set; }
        [Required(ErrorMessage = "Required.")]
        [Display(Name = "Company Name")]
        public string CompanyName { get; set; }
        public string Representative { get; set; }

        [DataType(DataType.MultilineText)]
        public string Code { get; set; }

        [Required(ErrorMessage = "Required.")]
        public string Address { get; set; }

        [Display(Name = "Date Added")]
        public DateTime DateAdded { get; set; }
        [Display(Name = "Date Modified")]
        public DateTime? DateModified { get; set; }
        [Display(Name = "Supplier Type")]
        public ItemType Type { get; set; }





    }

    public enum ItemType
    {
        Local =1,
        International = 2
    }


}
