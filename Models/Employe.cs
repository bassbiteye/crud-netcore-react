using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TpGl2021Core.Models
{
    public class Employe
    {
        [Key]
        [ScaffoldColumn(false)]
        public int EmployeeID { get; set; }
        [Display(Name = "Nom prénom"), MaxLength(160), Required(ErrorMessage = "*")]
        public string Name { get; set; }
        [Display(Name = "Age"), Required(ErrorMessage = "*")]
        public int Age { get; set; }
        [Display(Name = "Etat"), MaxLength(30), Required(ErrorMessage = "*")]
        public string State { get; set; }
        [Display(Name = "Pays"), MaxLength(30), Required(ErrorMessage = "*")]
        public string Country { get; set; }

    }
}
