using System.Diagnostics;

namespace BethanysPieShop.Test;

public class ProductTests
{
        [Fact]
        public void UseProduct_Reduces_AmountInStock()
        {
            //Arrange
            Product product = new Product(1, "Sugar", "Lorem ipsum", new Price() { ItemPrice = 10, Currency = Currency.Euro }, UnitType.PerKg, 100);

            product.IncreaseStock(100);

            //Act
            product.UseProduct(20);

            //Assert
            Assert.Equal(80, product.AmountInStock);

        }
        [Fact]
        public void UseProduct_ItemsHigherThanStock_NoChangetoStock()
        {
            //Arrange
            Product product = new Product(1, "Sugar", "Lorem ipsum", new Price() { ItemPrice = 10, Currency = Currency.Euro }, UnitType.PerKg, 100);

            product.IncreaseStock(10);

            //Act
            product.UseProduct(100);

            //Assert
            Assert.Equal(10, product.AmountInStock);
        }
                [Fact]
        public void UseProduct_Reduces_AmountInStock_StockBelowTreshold()
        {

            Product product = new Product(1, "Sugar", "Lorem ipsum", new Price() { ItemPrice = 10, Currency = Currency.Euro }, UnitType.PerKg, 100);
            int increaseValue = 100;
            product.IncreaseStock(increaseValue);

            product.UseProduct(increaseValue - 1);

            Assert.False(product.IsBelowStockTreshold);
        }
}
