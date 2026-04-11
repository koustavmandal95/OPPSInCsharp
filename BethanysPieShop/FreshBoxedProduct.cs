using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop
{
    public class FreshBoxedProduct: BoxedProduct
    {
        public DateTime ExpiryDateTime {get;set;}
        public string? StorageInstructors {get;set;}
        public FreshBoxedProduct(int id, string name, string? description, Price price, UnitType unitType, int maxAmountInStock, int amountPerBox) :
                                base(id, name, description, price, maxAmountInStock, amountPerBox)
        {
            
        }
    }
}