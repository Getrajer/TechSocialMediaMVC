using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMediaApp.Models
{
    public class UserCoverImageComment
    {
        public int Id { get; set; }

        public int CoverId { get; set; }

        //Fk
        [StringLength(450)]
        public string CreatorsId { get; set; }

        [StringLength(600)]
        public string CommentTxt { get; set; }

        public int Likes { get; set; }
        public int Dislikes { get; set; }
        public DateTime TimeOfCreation { get; set; }
    }
}
