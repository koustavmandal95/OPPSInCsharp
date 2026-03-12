using System.Text;

namespace BethanysPieShop
{
    public class Product
    {

        private int id;
        private string name = String.Empty;
        private string? description;
        private readonly int maxItemsInStock = 100;

         
        private bool isBelowStockThresold = false;

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

        public UnitType UnitType {get; set;}

        public int AmountInStock {get; set;}

        public bool IsBelowStockTreshold { get; private set;}


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
        private void UpdateLowStock()
        {
            if (AmountInStock < 10)
            {
                isBelowStockThresold = true;
                Log($"Product {CreateSimpleProductRepresentation()} is below stock thresold. Only {AmountInStock} items left in stock");
            }
        }

        public void IncreaseStock()
        {
            AmountInStock++;
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
            StringBuilder sb = new StringBuilder();
            sb.Append($"{ID} {name} \n {description}\n{AmountInStock} item(s) in stock");

            if(isBelowStockThresold)
            {
                sb.Append("\n !! STOCK NOW !!");
            }
            return sb.ToString();
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