public class Product
{
    // Variables
    private string _product;
    private int _productID;
    private float _productPrice;
    private int _productQuantity;

    // Constructors
    public Product(string product, int productID, float productPrice, int quantity)
    {
        _product = product;
        _productID = productID;
        _productPrice = productPrice;
        _productQuantity = quantity;
    }

    // Methods
    public string GetProductName()
    {
        return _product;
    }

    public int GetProductID()
    {
        return _productID;
    }

    public float ProductTotalPrice()
    {
        return _productQuantity * _productPrice;
    }
}