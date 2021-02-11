using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TopRestaurants.Models
{
    public class Top5 //Constructer to set the rank upon initializing
    {
        public Top5(int r)
        {
            rank = r;
        }
        [Required]
        public int rank { get; } //read only
        [Required]
        public string name { get; set; }
        public string? fav_dish { get; set; } = "It's all tasy!";
        [Required]
        public string address { get; set; }
        public string? phone { get; set; }
        public string? link { get; set; } = "Coming soon.";

        public static Top5[] GetRestaurant() 
        {
            Top5 r1 = new Top5(1)
            {
                name = "Cheesecake Factory",
                fav_dish = "Cheesecake",
                address = "Murray Utah",
                phone = "(555) 555-555",
                link = "https://www.thecheesecakefactory.com/?gclsrc=aw.ds&"
            };
            Top5 r2 = new Top5(2)
            {
                name = "Tucanos Brazilian Grill",
                address = "545 E University Pkwy, Orem, UT 84097",
                phone = "(801) 224-4774",
                link = "https://www.tucanos.com/"
            };
            Top5 r3 = new Top5(3)
            {
                name = "Greek-n-Go",
                fav_dish = "Classic Gyro",
                address = "1523 N Canyon Rd Provo, UT 84604",
                phone = "(555) 555-555",
            };
            Top5 r4 = new Top5(4)
            {
                name = "Silver Dish",
                fav_dish = "Pad Thai",
                address = "278 W Center St, Provo, UT 84601, US",
                phone = "(801) 373-9540",
                link = "https://silverdishthaicuisine.com/"  
            };
            Top5 r5 = new Top5(5)
            {
                name = "Red Fuego",
                fav_dish = "Red Fuego Bowl",
                address = "824 E 800th N St, Orem, UT 84097",
                phone = "(801) 960-9095"
            };

            return new Top5[] { r1, r2, r3, r4, r5 };
        }
    }
}
