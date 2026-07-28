using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<Video> videoList = new List<Video>(); // create a list to includ all the videos
        Video video1 = new Video("About The Book Of Mormon prophites", "President Dallin H. Oaks", 600); // create first video with its comments
        Comment c1 = new Comment("Moroni", "I have a book 10 Chapters.");
        Comment c2 = new Comment("Lehi", "I don't have a book but my sons have.");
        Comment c3 = new Comment("Nephi", "I have four books.");
// placced the comments inside first video
        video1.AddComment(c1);
        video1.AddComment(c2);
        video1.AddComment(c3);
// placed the first video inside the big list
        videoList.Add(video1);


        // second video
        Video video2 = new Video("About The Book Of Mormon", "President D. Todd Christofferson", 1200);
        
        Comment c4 = new Comment("Jacob", "I have a book 7 Chapters.");
        Comment c5 = new Comment("Enos", "I have a book 1 Chapter.");
        Comment c6 = new Comment("Jarom", "I have a book 1 Chapter.");
        video2.AddComment(c4);
        video2.AddComment(c5);
        video2.AddComment(c6);
        
        videoList.Add(video2);
        // third video
        Video video3 = new Video("About the books of the book of Mormon", "Elder Patrick Kearon", 450);
        
        Comment c7 = new Comment("Omni", "I have a book 1 Chapter.");
        Comment c8 = new Comment("Mosiah", "I have a book 29 Chapters..");
        Comment c9 = new Comment("Alma", "I have a book 63 Chapters..");
        
        video3.AddComment(c7);
        video3.AddComment(c8);
        video3.AddComment(c9);
        
        videoList.Add(video3);
        foreach (Video video in videoList)
        {
            video.DisplayVideoDetails();
        }
    }

}