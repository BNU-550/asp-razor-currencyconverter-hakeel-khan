using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorCurrencyConverter.Pages
{
    public class ConverterModel : PageModel
    {
        public void OnGet()
        {
        }

        public static class CurrencyConverter
        {
            static double Convert(double value, CurrencyChoice currency) {
                double returnAmount = 0;
                if (currency == CurrencyChoice.GBP)
                {
                    returnAmount =  value * 1.18;
                }
                if (currency == CurrencyChoice.EUR)
                {
                    returnAmount =  value / 1.18;
                }

                return returnAmount;
            }

        }


        enum CurrencyChoice
        {
            GBP,

            EUR
        }
    }
}
