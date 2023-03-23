public class Video {

    public string _title;
    public string _author;
    public int _seconds;
    public int _commCount;
    public List<string> _comments = new List<string>{};

    public string VideoInfo(){
        return $"{_title} - {_author}\n{_seconds} seconds\n{_commCount} comments\n{GetComments()}";
    }
    public int CountComments(){
        foreach(string c in _comments){
            _commCount = _commCount + 1;
        }
        return _commCount;
    }

    public string GetComments(){
        return String.Join("\n",_comments);
    }


}