using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace BethanysPieShop
{
    public class BulkProduct : Product
    {
        public BulkProduct(int id, string name, string? description, Price price, int maxAmountInStock) : base(id, name, description, price, UnitType.PerKg, maxAmountInStock)
        {
        }
    }
}