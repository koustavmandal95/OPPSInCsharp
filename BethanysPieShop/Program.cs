// See https://aka.ms/new-console-template for more information
using System;

using BethanysPieShop;

long before = GC.GetTotalMemory(true);
Product aproduct = new Product(100, "Chocolate Cake");
long after = GC.GetTotalMemory(true);

aproduct.AmountInStock = 10;
Console.WriteLine(aproduct.DisplayDetailsFull());


Console.WriteLine($"Approx bytes allocated: {after - before}");