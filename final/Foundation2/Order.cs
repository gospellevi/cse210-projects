using System;



public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    
    public int GetTotalPrice()
    {
    int total = 0;
    foreach (var product in _products)
    {
        total += product.GetTotalCost();
    }

    // Using the ternary operator technique
    // total += _customer.IsCustomerUSA() ? 5 : 35;
    // return total;

    if (_customer.IsCustomerUSA())
    {
        total += 5;
    }
    else
    {
        total += 35;
    }

    return total;
    }

    public string DisplayPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product product in _products)
        {
            label += $"{product.GetName()} (ID: {product.GetProductId()})\n";
        }
        return label;
    }

    public string DisplayShippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetName()}\n{_customer.GetAddress().DisplayStreetAddress()}";
    }
}