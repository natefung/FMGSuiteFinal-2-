using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FMGSuiteFinal.Models
{
    [Table("Users")]
    public class Users
    {
        [Key]

        [Required(ErrorMessage = "Please enter in a valid email for the username")]
        [DisplayName("Username (Email)")]
        public string email { get; set; }

        [Required(ErrorMessage = "Please enter in a valid password")]
        [DisplayName("Password")]
        public string password { get; set; }
    }
}