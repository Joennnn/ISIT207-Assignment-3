using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Task4.Models
{
    public class food
    {
        [ScaffoldColumn(false)]
        public int FoodID { get; set; }

        [Required, StringLength(100), Display(Name = "Name")]
        public string FoodName { get; set; }

        [Required, StringLength(10000), Display(Name = "Food Description"), DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public string ImagePath { get; set; }

        [Display(Name = "Price")]
        public double? UnitPrice { get; set; }

        public int? CategoryID { get; set; }

        public virtual category Category { get; set; }
    }
}