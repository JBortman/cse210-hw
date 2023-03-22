public class Product {

private string _name;
private string _id;
private double _price;
private int _quantity;
private double _total;

public string GetInfo(string name, string id, double price, int quantity) {
    _name = name;
    _id = id;
    _price = price;
    _quantity = quantity;
    _total = _price * _quantity;
    return $"{_name},{_id},{_price},{_quantity},{_total}";
}

// public void PrintTest() {
//     Console.WriteLine($"{_name}, {_id}, {_price}, {_quantity}, {_total}");
// } FOR TROUBLESHOOTING PURPOSES

}