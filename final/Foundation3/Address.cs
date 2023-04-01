public class Address {

    private string _address;
    public string GetAddress(string type){
        switch (type)
        {
            case "Lecture":
                _address = "123 Thatonestreet Ave";
                break;

            case "Outdoor":
                _address = "7734 Mountain Pass";
                break;

            case "Reception":
                _address = "1001 Firehouse Ave";
                break;
        }
        return _address;
    }

}