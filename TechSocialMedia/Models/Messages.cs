using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMediaApp.Models
{
    public class Messages
    {
        public int Id { get; set; }

        [StringLength(450)]
        public string SenderId { get; set; }

        [StringLength(450)]
        public string RecieverID { get; set; }

        [Required]
        [StringLength(600)]
        public string MessageTxt { get; set; }

        public DateTime TimeSent { get; set; }
    }
}
