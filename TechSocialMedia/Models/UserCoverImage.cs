using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMediaApp.Models
{
    public class UserCoverImage
    {
        public int Id { get; set; }

        [Required]
        [StringLength(600)]
        public string ImagePath { get; set; }

        [StringLength(600)]
        public string Description { get; set; }

        public int Likes { get; set; }
        public int Dislikes { get; set; }

        //Fk
        [StringLength(450)]
        public string UserId { get; set; }
    }
}
