using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using RencontreContemporainesAPI.Models.Base;

namespace RencontreContemporainesAPI.Models
{
    public class User : BaseEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
        [NotMapped] 
        public string Token { get; set; }
    }
}