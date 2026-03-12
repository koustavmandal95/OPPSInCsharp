// See https://aka.ms/new-console-template for more information
using BethanysPieShop;

Product aproduct = new Product();
aproduct.ID= 100;
aproduct.Name = "Chocolate Cake";
aproduct.AmountInStock = 10;
Console.WriteLine(aproduct.DisplayDetailsFull());
