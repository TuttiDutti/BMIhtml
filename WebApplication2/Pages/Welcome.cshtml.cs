
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Pages
{
    public class WelcomeModel : PageModel
    {
        public Person person { get; set; }
        public void OnGet()
        {

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult OnPost(Person person)
        {
            string _firstName = Request.Form["firstName"];
            string _gender = Request.Form["gender"];
            string _email = Request.Form["email"];
            string _height = Request.Form["height"];
            string _weight = Request.Form["weight"];
            string _age = Request.Form["age"];
            string _bmi = Request.Form["bmi"];


            if (person.unit == "m")
                person.bmi = person.weight / (person.height * person.height);
            if (person.unit == "cm")
            {
                float x = person.height / 100;
                person.bmi = person.weight / (x * x);
            }

            person.bmi = (float)Math.Round(person.bmi, 1);




            if (ModelState.IsValid)
            {
                return RedirectToPage("Result", person);
            }
            else return Page();

        }
    }
}
