using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TopRestaurants.Models
{
    public class Submissions
    {
        [Required(ErrorMessage = "Name Required!")]
        public string name { get; set; }
        [Required(ErrorMessage = "Restaurant Name Required!")]
        public string restaurant_name { get; set; }
        public string favorite_dish { get; set; } //?? "Its all tasty!
        [Required(ErrorMessage = "Phone Number Required!")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
                   ErrorMessage = "Entered phone format is not valid.")]
        public string phone { get; set; }
    }
}
