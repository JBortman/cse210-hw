public class Lectures : Event {

    private string _speaker;
    private string _capacity;

        public Lectures(string title, string description, string date, string time, string type, string speaker, string capacity) : base(title,description,date,time,type)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public string GetLectureInfo(){
        return $"FULL DESCRIPTION:\n{_type}: {_title}\n{_description}\n{_date} | {_time}\n{_address}\nSpeaker: {_speaker}\nMax Capacity: {_capacity}";
    }

}