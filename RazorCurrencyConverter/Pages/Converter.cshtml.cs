using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorCurrencyConverter.Pages
{
    enum CurrencyChoice
    {
        GBP,

        EUR
    }

    public class ConverterModel : PageModel
    {
        [BindProperty]
        public string Value{ get; set; }
        public void OnGet()
        {

        }

        public void OnPost()
        {
            decimal amount = Convert.ToDecimal(Value);
            amount = amount * 1.18m;
            ViewData["Message"] = $"amount in Euros is = {amount}";
        }

    }
}
