using System;

class Program
{
    static void Main(string[] args)
    {
        //creating an first instance of the video class
        Video video1 = new Video();

        video1._author = "Moses";
        video1._title = "Praise to God";
        video1._length = "400 seconds";
        //adding the 1st instance to the video list in the Video class
        video1._video.Add(video1);

        //creating 3 instances of the Comment class
        Comment comment1 = new Comment();
        Comment comment2 = new Comment();
        Comment comment3 = new Comment();

        //passing values to the instances of the Comment class created
        comment1._name = "John";
        comment1._text = "I love this song";

        comment2._name = "Craig";
        comment2._text = "This song is spirit filled";

        comment3._name = "Paul";
        comment3._text = "This song is a hit";

        //Adding the comments to the Comment List created in the Video class
        video1._comment.Add(comment1);
        video1._comment.Add(comment2);
        video1._comment.Add(comment3);

        video1.displayAll();
        video1.theComments();


        // ----------------2nd instance--------------------------------------------------
        //creating an 2nd instance of the video class
        Video video2 = new Video();

        video2._author = "Daniel";
        video2._title = "Glory to God";
        video2._length = "350 seconds";
        //adding the 1st instance to the video list in the Video class
        video2._video.Add(video2);

        //creating 3 instances of the Comment class
        Comment comment4 = new Comment();
        Comment comment5 = new Comment();
        Comment comment6 = new Comment();

        //passing values to the instances of the Comment class created
        comment4._name = "Michelle";
        comment4._text = "This song is great";

        comment5._name = "Tope";
        comment5._text = "One of the best songs so far";

        comment6._name = "Samson";
        comment6._text = "All Glory to God";

        //Addingthe comments to the Comment List created in the Video class
        video2._comment.Add(comment4);
        video2._comment.Add(comment5);
        video2._comment.Add(comment6);

        video2.displayAll();
        video2.theComments();

        // -----------3rd instance ----------------------------
        Video video3 = new Video();

        video3._author = "Lekan";
        video3._title = "Have Faith";
        video3._length = "500 seconds";
        //adding the 1st instance to the video list in the Video class
        video3._video.Add(video3);

        //creating 3 instances of the Comment class
        Comment comment7 = new Comment();
        Comment comment8 = new Comment();
        Comment comment9 = new Comment();

        //passing values to the instances of the Comment class created
        comment7._name = "Favour";
        comment7._text = "I love this song, its inspiring";

        comment8._name = "Dammy";
        comment8._text = "This song is reviving";

        comment9._name = "Lola";
        comment9._text = "What a great song";

        //Addingthe comments to the Comment List created in the Video class
        video3._comment.Add(comment7);
        video3._comment.Add(comment8);
        video3._comment.Add(comment9);

        video3.displayAll();
        video3.theComments();
    }
}