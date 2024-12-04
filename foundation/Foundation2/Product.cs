public class Product
{
    private string _name;
    private string _productId;
    private decimal _price;

    public Product(string name, string productId, decimal price)
    {
        _name = name;
        _productId = productId;
        _price = price;
    }

    public string GetName() => _name;

    public string GetProductId() => _productId;

    public decimal GetPrice() => _price;
}
