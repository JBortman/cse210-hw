public class Reference{

private string _book;
private int _chapter;
private int _verse;
private int _endVerse;

public string FullReference(string _book, int _chapter, int _verse)
{
    
    string fullRef = $"{_book} {_chapter}:{_verse}";
    return fullRef;
}

public string FullReference(string _book, int _chapter, int _verse, int _endVerse)
{
    string fullRef = $"{_book} {_chapter}:{_verse}-{_endVerse}";
    return fullRef;
}


}