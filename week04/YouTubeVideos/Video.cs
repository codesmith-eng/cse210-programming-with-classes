using System;


public class Video
{
    public string _title;

    public string _author;

    public string _length;

    //creating list of comments for each video
    public List<Comment> _comment = new List<Comment>();

    //creating list to store videos instances
    public List<Video> _video = new List<Video>();




    public void displayAll()
    {
        foreach (Video theVideos in _video)
        {
            Console.WriteLine($"Author of the Song: {theVideos._author}");
            Console.WriteLine($"Title of the Song: {theVideos._title} ");
            Console.WriteLine($"Length of the Song: {theVideos._length}");
            Console.WriteLine($"Total comments: {GetCommentCount()}");
        }
    }


    public void theComments()
    {
        foreach (Comment theComments in _comment)
        {
            Console.WriteLine($"{theComments._name} -- {theComments._text}");
        }
        Console.WriteLine();
        Console.WriteLine("-------------------------------------");
        Console.WriteLine();
    }

    //this function returns the number of stored comment to the displayAll() to display it 
    public int GetCommentCount()
    {
        //using .Count method, The number of comment was counted and returned to the displayAll() for displaying
        return _comment.Count;
    }

}