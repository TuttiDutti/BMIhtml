using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using WebApplication2.Models;

namespace WebApplication2.Pages
{
    public class IndexModel : PageModel
    {
         
        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            return RedirectToPage("Welcome");
        }
    }
}
