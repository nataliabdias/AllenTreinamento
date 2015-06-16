using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sample.Models.ViewModel
{
    public class LoginViewModel
    {

        [Required(ErrorMessage = "Campo UserName é obrogatório")]
        public String UserName { get; set; }

        [Required(ErrorMessage = "Campo Password é obrogatório")]
        public String Password { get; set; }

    }
}