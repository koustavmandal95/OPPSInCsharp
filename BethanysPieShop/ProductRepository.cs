using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop
{
    public class ProductRepository
    {
        private string productFileLocation  = String.Empty;

        public ProductRepository()
        {
            string projectRoot = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, @"..\..\.."));
            productFileLocation = Path.Combine(projectRoot, "Resources", "Product.txt");
        }
        public bool CheckForExistingProductFile()
        {
            string projectRoot = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, @"..\..\.."));
            productFileLocation = Path.Combine(projectRoot, "Resources", "Product.txt");

            return File.Exists(productFileLocation); 
        }

        public List<Product> LoadProductsFromFile()
        {
            List<Product> products = new List<Product>();
            string [] allFileInformation  = File.ReadAllLines(productFileLocation);

            foreach(string constructorParameters in allFileInformation)
            {
                string [] productSplits = constructorParameters.Split(';');

                int productId = ParseIntOrDefault(productSplits[0], 0);
                string name = productSplits[1];
                string description = productSplits[2];
                int maxItemsInStock = ParseIntOrDefault(productSplits[3], 100);
                int itemPrice = ParseIntOrDefault(productSplits[4], 0);
                Currency currency = ParseEnumOrDefault(productSplits[5], Currency.Dollar);
                UnitType unitType = ParseEnumOrDefault(productSplits[6], UnitType.PerItem);

                 Product product = new Product(productId, name, description, 
                                        new Price() { ItemPrice = itemPrice, Currency = currency }, unitType, maxItemsInStock); 
                products.Add(product);

            }
            return products;
        }

        private static int ParseIntOrDefault(string input, int defaultValue) => int.TryParse(input, out int value) ? value : defaultValue;

        private static TEnum ParseEnumOrDefault<TEnum>(string input, TEnum defaultValue) where TEnum : struct => Enum.TryParse(input, out TEnum value) ? value : defaultValue;

    }
}
