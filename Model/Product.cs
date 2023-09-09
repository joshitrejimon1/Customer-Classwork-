﻿
using System;
using System.Collections.Generic;

class Product
{
    public int Id { get; }
    public string Name { get; }
    public double Price { get; }
    public double DiscountPercent { get; }

    public Product(int id, string name, double price, double discountPercent)
    {
        Id = id;
        Name = name;
        Price = price;
        DiscountPercent = discountPercent;
    }

    public double CalculateDiscountedPrice()
    {
        return Price - (Price * DiscountPercent / 100);
    }
}
