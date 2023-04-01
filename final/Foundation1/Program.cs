using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> _videos = new List<string>{};
        Console.Clear();
        //-----Video 1-----------------------------------
        Video vid1 = new Video();
        Comment com1 = new Comment();

        vid1._title = "How to Tie a Shoe";
        vid1._author = "Wil Layne";
        vid1._seconds = 240;

        com1._commName = "Timmy Turner";
        com1._commText = "First";
        vid1._comments.Add(com1.MakeComment());

        com1._commName = "Danny Phantom";
        com1._commText = "What size shoe are you?";
        vid1._comments.Add(com1.MakeComment());

        com1._commName = "Patrick Star";
        com1._commText = "I dont where shoose";
        vid1._comments.Add(com1.MakeComment());

        vid1._commCount = vid1.CountComments();

        _videos.Add(vid1.VideoInfo());

        //-----Video 2-----------------------------------
        Video vid2 = new Video();
        Comment com2 = new Comment();
        vid2._title = "Tips While Visiting France";
        vid2._author = "Jaques Gusteau ";
        vid2._seconds = 500;

        com2._commName = "Carl Wheezer";
        com2._commText = "Excuse me mister, are you going to finish that croissant?";
        vid2._comments.Add(com2.MakeComment());

        com2._commName = "Eugene Fitzherbert";
        com2._commText = "Do the French use frying pans the same way we do?";
        vid2._comments.Add(com2.MakeComment());

        com2._commName = "Bim Turton";
        com2._commText = "This looks like a good palce to make a movie!";
        vid2._comments.Add(com2.MakeComment());

        com2._commName = "Jimmy Neutron";
        com2._commText = "Did you know french fries are not actually French?";
        vid2._comments.Add(com2.MakeComment());

        vid2._commCount = vid2.CountComments();

        _videos.Add(vid2.VideoInfo());

        //-----Video 3-----------------------------------
        Video vid3 = new Video();
        Comment com3 = new Comment();
        vid3._title = "Review of the Hairy Potter Series";
        vid3._author = "K.J. Bowling ";
        vid3._seconds = 1800;

        com3._commName = "Nebille Smallbottom";
        com3._commText = "...Why is it always me?";
        vid3._comments.Add(com3.MakeComment());

        com3._commName = "Don Weazle";
        com3._commText = "Gizard's chess was my favorite part!";
        vid3._comments.Add(com3.MakeComment());
        
        com3._commName = "Larry Popper";
        com3._commText = "I wish Hogshorts School of Clay-craft and Pottery was real :(";
        vid3._comments.Add(com3.MakeComment());

        vid3._commCount = vid3.CountComments();

        _videos.Add(vid3.VideoInfo());

        //-----Display videos & comments-----------------
        foreach(string v in _videos){
            Console.WriteLine(v);
            Console.WriteLine("--------------------");
        }
    }
}