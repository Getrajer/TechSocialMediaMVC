using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMediaApp.Models
{
    public class UserInformation
    {
        //FK
        [StringLength(450)]
        public string UserId { get; set; }

        [Required]
        [StringLength(450)]
        public string Gender { get; set; }

        [StringLength(500)]
        public string ProfileDescription { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        [StringLength(40)]
        public string PhoneNumber { get; set; }

        [StringLength(56)]
        public string Country { get; set; }

        [StringLength(100)]
        public string City { get; set; }

        [StringLength(600)]
        public string FavoriteMovies { get; set; }

        [StringLength(600)]
        public string FavoriteBooks { get; set; }

        [StringLength(600)]
        public string FavoriteFood { get; set; }
    }
}
