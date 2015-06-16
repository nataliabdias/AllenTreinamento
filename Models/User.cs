using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Sample.Models
{
    public class User
    {
        public User()
        {
            this.CriationDate = DateTime.Now;
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "Campo UserName é obrogatório")]
        public String UserName { get; set; }

        [Required(ErrorMessage = "Campo Nome é obrogatório")]
        public String Name { get; set; }

        [Required(ErrorMessage = "Campo Email é obrogatório")]
        public String Email { get; set; }

        [Required(ErrorMessage = "Campo Password é obrogatório")]
        public String Password { get; set; }

        public DateTime CriationDate { get; set; }

        [Required(ErrorMessage = "Perfil é obrogatório")]
        public String Perfil { get; set; }
    }
}