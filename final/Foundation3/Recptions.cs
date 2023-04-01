public class Receptions : Event {

    private string _email;

        public Receptions(string title, string description, string date, string time, string type, string email) : base(title, description, date, time, type)
    {
        _email = email;
    }

    public string GetReceptionInfo()
    {
        return $"FULL DESCRIPTION:\n{_type}: {_title}\n{_description}\n{_date} | {_time}\n{_address}\nRSVP at {_email}";
    }

}