using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace WebApplication2.Models
{
    public class Calculator
    {
        //[Required(ErrorMessage = "To pole jest wymagane")]
        [Display(Name = "Wzrost")]
        public float height { get; set; }

       // [Required(ErrorMessage = "To pole jest wymagane")]
        [Display(Name = "Jednostka miary")]
        public string unit { get; set; }

       // [Required(ErrorMessage = "To pole jest wymagane")]
        [Display(Name = "Waga")]
        public float weight { get; set; }

        [Display(Name = "BMI")]
        public float bmi { get; set;}
    } 
}
