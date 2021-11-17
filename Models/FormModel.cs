using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
namespace Lab3_test4.Models
{
    public class FormModel
    {
        [Display(Name = "Nazwa elementu")]
[Required]
        public string Name { get; set; }
        [Display(Name = "Opis elementu")]
        public string Description { get; set; }
        [Display(Name = "Element widoczny?")]
        public bool IsVisible { get; set; }
    }
}
