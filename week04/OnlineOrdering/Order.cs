using System.Reflection.Emit;

public class Order
{
    // Variables
    private List<Product> _products;
    private Customer _customer;

    // Constructors
    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    // Methods
    public float TotalPrice()
    {
        float orderTotal = 0;
        // Calculate total of all the products in the order
        foreach (Product product in _products)
        {
            orderTotal += product.ProductTotalPrice();
        }

        // Determine shipping cost (USA or international)
        if (_customer.CustomerInUSA())
        {
            orderTotal += 5;
        }
        else
        {
            orderTotal += 35;
        }

        return orderTotal;
    }

    public string GeneratePackingLabel()
    {
        string packingLabel = "Packing List:\n";
        foreach (Product product in _products)
        {
            packingLabel += $"{product.GetProductName()}  (ID:  {product.GetProductID()})\n";
        }
        return packingLabel;
    }

    public string GenerateShippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetName()}\n{_customer.GetAddress()}";
    }
}