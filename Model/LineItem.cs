
using System;
using System.Collections.Generic;

class LineItem
{
    public int Id { get; private set; }
    public int Quantity { get; private set; }
    public Product Product { get; private set; }

    public LineItem(int id, int quantity, Product product)
    {
        Id = id;
        Quantity = quantity;
        Product = product;
    }

    public double CalculateLineItemCost()
    {
        double unitCostAfterDiscount = Product.CalculateDiscountedPrice();
        return Quantity * unitCostAfterDiscount;
    }
}
