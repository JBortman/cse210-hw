public class Customer
{

    Address add = new Address();
    private string _name;
    private string _address;
    private bool _inUSA;

    public void CustInfo(string name,string address, string city, string state, string country)
    {
        add.GetAddress(address, city, state, country);
        _address = add.FullAddress();
        _name = name;
    }

    public string CustAddress(){
        return _address;
    }

    public string CustName(){
        return _name;
    }

    public bool GetInUSA(){
        _inUSA = add.IfUSA();
        return _inUSA;
    }

}