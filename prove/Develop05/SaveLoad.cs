public class SaveLoad {

private string _filename;

public void Save(int points, List<string> list){
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

public void Load(int points, List<string> list){
    Console.Write("Please enter the filename you wish to load: ");
    _filename = Console.ReadLine();

    string[] lines = System.IO.File.ReadAllLines(_filename);

    points = int.Parse(lines[0]);
    foreach(string i in lines.Skip(1)){
    //Console.WriteLine(i); //FOR TROUBLESHOOTING
    list.Add(i);
    }
}

}