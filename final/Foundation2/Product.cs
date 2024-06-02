using System;



public class Product
{
    private string _name;
    private string _Id;
    private double _price;
    private int _quantity;

    public Product(string name, string Id, double price, int quantity)
    {
        _name = name;
        _Id = Id;
        _price = price;
        _quantity = quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetProductId()
    {
        return _Id;
    }

    public int GetTotalCost()
    {
        return (int)(_price * _quantity);
    }
}