public class Event
{

    Address add = new Address();
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected string _address;
    protected string _type;

    public Event(string title, string description, string date, string time, string type)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _type = type;
    }

    public void GetAddress(){
        _address = add.GetAddress(_type);
    }

    public string StandardDesc(){
        return $"STANDARD DESCRIPTION:\n{_title}\n{_description}\n{_date} | {_time}\n{_address}";
    }

    public string ShortDesc()
    {
         return $"SHORT DESCRIPTION:\n{_type} Event: {_title} - {_date}";
    }
}