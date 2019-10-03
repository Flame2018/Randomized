using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FOMapp.Pages
{
    public class IndexModel : PageModel
    {
        public string[] random { get; set; }
        public void OnGet()
        {
            random = new string[] { "Soil", "water bottles", "markets", "blazers", "Vine" };
        }
    }
}
