using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PeterGardinerAssignment4.Models
{
    public class Restaurant
    {
        //make getters and setters for each field
        public Restaurant(int rank)
        {
            RestaurantRank = rank;
        }
        
        
        public int RestaurantRank { get;  }
        [Required]
        public string RestaurantName { get; set; }
        public string? FavoriteDish { get; set; } = "it's all tasty!";
        [Required]
        public string Address { get; set; }
        public string? Phone { get; set; }
        public string? Link { get; set; } = "Coming Soon";

        // set list of restaurant objects
        public static Restaurant[] GetRestaruants()
        {
            Restaurant r1 = new Restaurant(1)
            {
                RestaurantName = "Joes",
                Address = "42 W 2189 N ",
                Phone = "801-785-8144",
            };

            Restaurant r2 = new Restaurant(2)
            {
                RestaurantName = "sue",
                Address = "41 W 2189 N ",
                Phone = "801-784-8144",
            };

            Restaurant r3 = new Restaurant(3)
            {
                RestaurantName = "billy bob's",
                FavoriteDish = "the sandwich",
                Address = "23s 34n",
                Phone = "323-232-2323",
                Link = "www.bilbob.com"
            };

            Restaurant r4 = new Restaurant(4)
            {
                RestaurantName = "yippe's",
                FavoriteDish = "gourmet bowl of cereal",
                Address = "3434n 2323e",
                Phone = "323-232-2324",
                Link = "www.bilbobyips.com"
            };

            Restaurant r5 = new Restaurant(5)
            {
                RestaurantName = "billy bob's sister",
                FavoriteDish = "burger",
                Address = "43w 2213n",
                Phone = "323-232-2325",
                Link = "www.bilbobsister.com"
            };

            return new Restaurant[] { r1, r2, r3, r4, r5};
        }
    }
}
