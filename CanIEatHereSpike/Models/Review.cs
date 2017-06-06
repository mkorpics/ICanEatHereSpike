using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CanIEatHereSpike.Models
{
    public class Review
    {
        [Key]
        public int ReviewID;

        public string NumFoodOptions { get; set; }
        public int NumFoodOptionsRating { get; set; }
        public string GeneralComments { get; set; }
        public int OverallRating { get; set; }
        public DateTime PostDate { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }

        [ForeignKey("DietaryRestriction")]
        public int DietaryRestrictionID { get; set; }
        public virtual List<DietaryRestriction> DietaryRestriction { get; set; }

        [ForeignKey("Restaurant")]
        public int RestaurantID { get; set; }
        public virtual Restaurant Restuarant { get; set; }

        public virtual ICollection<FoodItem> FoodItems { get; set; }


}
}