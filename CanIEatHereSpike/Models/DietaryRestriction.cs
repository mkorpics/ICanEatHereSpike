using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CanIEatHereSpike.Models
{
    public class DietaryRestriction
    {
        [Key]
        public int DietaryRestrictionID { get; set; }

        public string DietType { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }
    }
}