using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace WebApplication2.Models
{
    public class Person
    {
        [Required(ErrorMessage = "To pole jest wymagane")]
        [Display(Name = "Imię")]
        [RegularExpression(@"^[a-zA-Z]+$")]
        [StringLength(15, ErrorMessage = "Name length can't be more than 15.")]
        public string? firstName { get; set; }

        [Required(ErrorMessage = "To pole jest wymagane")]
        [Display(Name = "Płeć")]
        public string gender { get; set; } = null!;

        [EmailAddress(ErrorMessage = "Nieprawidłowy adres email")]
        [Display(Name = "Email")]
        public string email { get; set; }
        
        [Display(Name = "Wiek")]
        [Range(1, 120, ErrorMessage = "Proszę wprowadźić liczbę z przedziału od 1 do 120")]
        public int age { get; set; }

        [Display(Name = "Wzrost")]
        public float height { get; set; }

        [Required(ErrorMessage = "To pole jest wymagane")]
        [Display(Name = "Jednostka miary")]
        public string unit { get; set; }

        [Required(ErrorMessage = "To pole jest wymagane")]
        [Display(Name = "Waga")]
        public float weight { get; set; }

        [Display(Name = "BMI")]
        public float bmi { get; set; }
    }
}
