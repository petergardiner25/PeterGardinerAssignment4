using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PeterGardinerAssignment4.Models
{
    public class ApplicationResponse
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string RName { get; set; }
        [Required]
        public string FavDish { get; set; }
        [RegularExpression(@"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}", ErrorMessage ="Invalid Phone Number")]
        public string PhoneNumber { get; set; }
    }
}
