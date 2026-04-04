using System.Diagnostics;

namespace BethanysPieShop.Test;

public class ProductTests
{
        [Fact]
        public void UseProduct_Reduces_AmountInStock()
        {
            //Arrange
            Product product = new Product(1, "Sugar", "Lorem ipsum", new Price() { ItemPrice = 10, Currency = Currency.Euro }, UnitType.PerKg, 100);

            Debug.WriteLine(product.AmountInStock);
            product.IncreaseStock(100);

            //Act
            product.UseProduct(20);

            //Assert
            Assert.Equal(80, product.AmountInStock);

        }
}
