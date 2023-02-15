public class Assignment
{

private string _studentName;
private string _topic;

public void GetSummary(string name, string topic)
{
    _studentName = name;
    _topic = topic;
    Console.WriteLine($"{name} - {topic}");
}

}