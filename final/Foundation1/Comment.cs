public class Comment {

    public string _commName;
    public string _commText;

    public string MakeComment(){
        return $"{_commName}: {_commText}";
        }

}