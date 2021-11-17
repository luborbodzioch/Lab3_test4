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
        [Display(Name = "Imie")]
        [Required]
        public string Name { get; set; }
        [Display(Name = "Ilosc powtorzen")]
        public int IloscP { get; set; }
    }
}
