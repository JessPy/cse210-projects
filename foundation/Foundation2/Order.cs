using System.Collections.Generic;
using System.Text;

public class Order
{
    private List<(Product product, int quantity)> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _products = new List<(Product product, int quantity)>();
        _customer = customer;
    }

    public void AddProduct(Product product, int quantity)
    {
        _products.Add((product, quantity));
    }

    public decimal CalculateTotalCost()
    {
        decimal total = 0;

        foreach (var (product, quantity) in _products)
        {
            total += product.GetPrice() * quantity;
        }

        total += GetShippingCost();
        return total;
    }

    public string GetPackingLabel()
    {
        var sb = new StringBuilder();
        foreach (var (product, quantity) in _products)
        {
            sb.AppendLine($"{quantity} {product.GetName()} (ID: {product.GetProductId()})");
        }
        return sb.ToString();
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }

    private decimal GetShippingCost()
    {
        return _customer.LivesInUSA() ? 5 : 35;
    }
}
