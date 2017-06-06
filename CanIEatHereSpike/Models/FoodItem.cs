using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CanIEatHereSpike.Models
{
    public class FoodItem
    {
        [Key]
        public int FoodItemID { get; set; }
        public string FoodItemName { get; set; }
        public string ListIngredients { get; set; }
        public int FoodItemRating { get; set; }

        [ForeignKey("Course")]
        public int CourseID { get; set; }
        public virtual Course Course { get; set; }

        [ForeignKey("Review")]
        public int ReviewID { get; set; }
        public virtual Review Review { get; set; }
    }
}