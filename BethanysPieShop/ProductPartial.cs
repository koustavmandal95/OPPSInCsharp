using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop
{
    public partial class Product
    {
        public static int StockThresold = 5;

        public static void ChangeStockThresold(int newStockThresold)
        {
            // we will only allow this to go through if the value is > 0
            if(newStockThresold > 0)
                StockThresold = newStockThresold;
        }
        internal void UpdateLowStock()
        {
            if (AmountInStock < StockThresold)
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