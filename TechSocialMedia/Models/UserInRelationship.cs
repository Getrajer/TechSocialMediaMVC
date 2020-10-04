using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMediaApp.Models
{
    public class UserInRelationship
    {
        //FK
        [StringLength(450)]
        public string UserId { get; set; }

        public bool InRelationship { get; set; }

        //If user wants to provide information with which other user person is in relationship with
        [StringLength(450)]
        public string WithWhoId { get; set; }

        [StringLength(100)]
        public string TypeOfRelatioship { get; set; }
    }
}
