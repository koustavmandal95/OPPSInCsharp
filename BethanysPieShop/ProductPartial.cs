using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop
{
    public partial class Product
    {
        private void UpdateLowStock()
        {
            if (AmountInStock < 10)
            {
                isBelowStockThresold = true;
                Log($"Product {CreateSimpleProductRepresentation()} is below stock thresold. Only {AmountInStock} items left in stock");
            }
        }
        private static void Log(string message)
        {
            Console.WriteLine(message);
        }
        private string CreateSimpleProductRepresentation()
        {
            return $"Product {ID} - {name}";
        }

    }
}