using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Bon_appetit.Models
{
    public class User
    {

        public int UserId { get; set; }
        [BindProperty]
        public String password { get; set; }
        [BindProperty]

        public String UserName { get; set; }
        [EmailAddress]
        public String EMail { get; set; }
        [BindProperty]

        public String? Adress { get; set; }
        [Phone]
        [BindProperty]

        public double PhoneNumber { get; set; }
    }
}
