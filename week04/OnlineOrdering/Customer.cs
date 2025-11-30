public class Customer
{
    // Variables
    private string _name;
    private Address _address;

    // Constructors
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Methods
    public string GetName()
    {
        return _name;
    }

    public string GetAddress()
    {
        return _address.FullAddress();
    }

    public bool CustomerInUSA()
    {
        return _address.InUSA();
    }
}