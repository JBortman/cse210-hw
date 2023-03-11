public class SaveLoad : Goal{

private string _filename;

public void Save(List<string> list, int points){
    Console.Write("Please enter the name of your text file: ");
    _filename = Console.ReadLine();

    using (StreamWriter outputFile = new StreamWriter(_filename))
    {
        outputFile.WriteLine(points);
        foreach(string i in list){
            outputFile.WriteLine(i);
        }
    }
}

public int Load(List<string> list){
    list.Clear();
    _userPoints = 0;
    Console.Write("Please enter the filename you wish to load: ");
    _filename = Console.ReadLine();

    string[] lines = System.IO.File.ReadAllLines(_filename);

    _userPoints = int.Parse(lines[0]);
    foreach(string i in lines.Skip(1)){
    //Console.WriteLine(i); //FOR TROUBLESHOOTING
    list.Add(i);
    }
    return _userPoints;
}

}