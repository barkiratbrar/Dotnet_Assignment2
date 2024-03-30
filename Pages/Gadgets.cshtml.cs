using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TechTrendsShowcase.Models;

namespace TechTrendsShowcase.Pages
{
    public class GadgetsModel : PageModel
    {
        public IEnumerable<Gadget> Gadgets { get; private set; }

        public void OnGet([FromServices] GadgetService gadgetService)
        {
            Gadgets = gadgetService.GetGadgets();
        }
    }

}
