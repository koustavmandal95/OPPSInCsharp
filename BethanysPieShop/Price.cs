using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop
{
    public class Price
    {
        public double ItemPrice {get;set;}

        public Currency  Currency {get;set;}

        public override string ToString()
        {
            return $"{ItemPrice} {Currency}";
        }


    }
}