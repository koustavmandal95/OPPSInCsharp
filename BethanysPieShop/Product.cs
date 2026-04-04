using System.ComponentModel;
using System.Data.Common;
using System.Text;

namespace BethanysPieShop
{
    public partial class Product
    {

        private int id;
        private string name = String.Empty;
        private string? description;
        private readonly int maxItemsInStock = 100;         
        private bool isBelowStockThresold = false;

        public UnitType UnitType {get; set;}

        public int AmountInStock {get; set;}

        public bool IsBelowStockTreshold { get; private set;}

        public Price Price {get;set;}

        public int ID
        {
            get { return id ;}
            set { id = value; }
        }
        public string Name
        {
            get {return name;}
            set
            {
                name = value.Length > 50 ? value[..50] : value;
            }
        }
        public string? Description
        {
            get {return description;}
            set
            {
                if(value == null)
                {
                    description = string.Empty;
                }
                else
                {
                    description = value.Length > 250 ? value[..50] : value;
                }
            }
        }

        
        public Product(int id): this(id, string.Empty)
        {
            
        }

        public Product(int id, string name)
        {
            ID = id;
            Name = name;
        }

        public Product(int id, string name, string? description, Price price, UnitType unitType)
            : this(id, name)
        {
            Description = description;
            UnitType = unitType;
            Price = price;

            if (AmountInStock < 10)
            {
                IsBelowStockTreshold = true;
            }
        }
        public Product(int id, string name, string? description, Price price, UnitType unitType,
                        int maxAmountInStock_in)
        {
            ID = id;
            Name = name;
            Description = description;
            Price = price;
            UnitType = unitType;
            maxItemsInStock = maxAmountInStock_in;

            UpdateLowStock();
        }

        public void UseProduct(int items)
        {
            if (items <= AmountInStock)
            {
                AmountInStock -= items;
                UpdateLowStock();
                Log($"Amount in stock updated. Now {AmountInStock} items in stock");
            }
            else
            {
                Log($"Not enough items on stock for {CreateSimpleProductRepresentation()}. {AmountInStock} available but {items} requested");
            }
        }

        public void IncreaseStock()
        {
            AmountInStock++;
        }

        public void IncreaseStock(int amount)
        {
            int newStock = AmountInStock + amount;
            AmountInStock = Math.Min(newStock, maxItemsInStock);

            if (newStock > maxItemsInStock)
            {
                Log($"{CreateSimpleProductRepresentation} stock Overflow. {newStock - AmountInStock} items ordered that couldn't be stored");
            }
            UpdateStockThresholdStatus();
        }

        private void UpdateStockThresholdStatus()
        {
            IsBelowStockTreshold = AmountInStock <= StockThresold;
        }

        private void DecreaseStock(int items, string reason)
        {
            if(items <= AmountInStock)
            {
                AmountInStock -= items;
    
            }
            else
            {
                AmountInStock = 0;
            }   
            UpdateLowStock();
            Log(reason);
        }

        public string DisplayDetailsShort()
        {
            return $"{ID}. {name} \n {AmountInStock} items in stock";
        }

        public string DisplayDetailsFull()
        {
            return DisplayDetailsFull("");
        }

        public string DisplayDetailsFull(string extraDetails)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{ID} \n {name} \n {description}\n {Price}\n {AmountInStock} item(s) in stock");
            sb.Append(extraDetails);
            
            if(isBelowStockThresold)
            {
                sb.Append("\n !! STOCK NOW !!");
            }
            return sb.ToString();
        }
    }
}