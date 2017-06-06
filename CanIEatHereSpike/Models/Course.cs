using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CanIEatHereSpike.Models
{
    public class Course
    {
        [Key]
        public int CourseID { get; set; }

        public string CourseType { get; set; }

        public virtual ICollection<FoodItem> FoodItems { get; set; }

    }
}