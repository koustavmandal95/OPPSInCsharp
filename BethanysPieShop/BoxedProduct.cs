using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShop
{
    public class BoxedProduct : Product
    {
        private int amountPerBox;
        public int AmountPerBox
        {
            get => amountPerBox;
            set
            {
                if(value <0)
                    throw new ArgumentException("Amount per box cannot be negative");
                amountPerBox = value;
            }
        }
        
        public BoxedProduct(int id, string name, string? description, Price price, int maxAmountInStock, int amountPerBox) :
                           base(id, name, description, price, UnitType.PerBox, maxAmountInStock)
        {
            AmountPerBox = amountPerBox;
        }

        public override void UseProduct(int items)
        {
                       int smallestMultiple = 0;
           int batchSize;

           while (true)
           {
               smallestMultiple++;
               if (smallestMultiple * AmountPerBox > items)
               {
                   batchSize = smallestMultiple * AmountPerBox;
                   break;
               }
           }

           //use base method explicitly adding the base keyword
           base.UseProduct(batchSize);
        }

        public override void IncreaseStock()
        {
            AmountInStock += AmountPerBox;
        }

        public override void IncreaseStock(int amount)
        {
            int newStock = AmountInStock + amount + AmountPerBox;
            AmountInStock = Math.Min(newStock, maxItemsInStock);

            if (newStock > maxItemsInStock)
            {
                Log($"{CreateSimpleProductRepresentation} stock Overflow. {newStock - AmountInStock} items ordered that couldn't be stored");
            }
            UpdateStockThresholdStatus();
        }

        
        public override string DisplayDetailsFull()
        {
           StringBuilder sb = new StringBuilder();
           sb.Append("Boxed Product\n");
           sb.Append($"{ID} {Name} \n{Description}\n{Price}\n{AmountInStock} item(s) in stock");

           if (IsBelowStockTreshold)
           {
               sb.Append("\n!!STOCK LOW!!");
           }

           return sb.ToString();
        }
        

        /*
        public void UseBoxedProduct(int items)
        {
           DecreaseStock(0, "sample");

           int smallestMultiple = 0;
           int batchSize;

           while (true)
           {
               smallestMultiple++;
               if (smallestMultiple * AmountPerBox > items)
               {
                   batchSize = smallestMultiple * AmountPerBox;
                   break;
               }
           }

           base.UseProduct(batchSize);//use base method explicitly adding the base keyword
        }
        */
    }
}