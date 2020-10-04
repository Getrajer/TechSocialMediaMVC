using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMediaApp.Models
{
    public class UserProfileImage
    {
        public int Id { get; set; }

        //Fk
        [StringLength(450)]
        public string UserId { get; set; }

        [Required]
        [StringLength(600)]
        public string ImagePath { get; set; }

        [StringLength(450)]
        public string ImageDescription { get; set; }

        public int Likes { get; set; }
        public int Dislikes { get; set; }

        public DateTime TimeOfCreation { get; set; }
    }
}
 