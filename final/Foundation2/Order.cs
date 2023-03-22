public class Order
{

    Product prod = new Product();
    Customer cust = new Customer();
    private string _custName;
    private string _custAddress;
    private string[] numbers;
    private double _total;
    private bool _shipConfirm;
    private double _shipping;
    private List<string> _products = new List<string> { };
    private List<string> _packing = new List<string> { };

    //-----Get Customer Info----------------------------------------------
    public void GetCustomerInfo(string name, string address, string city, string state, string country)
    {
        cust.CustInfo(name, address, city, state, country);
        _custAddress = cust.CustAddress();
        _custName = cust.CustName();
        _shipConfirm = cust.GetInUSA();
    }

    //-----Get Shipping---------------------------------------------------
    public void ConfirmShipping()
    {
        if (_shipConfirm == true)
        {
            _shipping = 5;
        }
        else
        {
            _shipping = 35;
        }
    }

    //-----Add Product to list--------------------------------------------
    public void AddProduct(string name, string id, double price, int quantity)
    {
        _products.Add(prod.GetInfo(name, id, price, quantity));
        _packing.Add($"{name} - {id} ({quantity})");
    }

    //-----Calculate Total------------------------------------------------
    public void GetTotal()
    {
        foreach (string i in _products)
        {
            numbers = i.Split(",");
            _total += Math.Round(double.Parse(numbers[4]), 2);
        }
        ConfirmShipping();
        _total += _shipping;
        Console.WriteLine($"Shipping Cost: ${_shipping}\nTotal Cost: ${_total}");
    }

    //-----Labels---------------------------------------------------------
    public string ShippingLabel()
    {
        return $"Ship to:\n{_custName}\n{_custAddress}"+"\n";
    }

    public string PackingLabel(){
        return "Products in Package:\n"+String.Join("\n",_packing);
    }




}