using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video v1 = new Video("Planting Cactus For Beginners", "Plantita", 350);
        v1.AddComment(new Comment("Melva", "Thank you for the tips"));
        v1.AddComment(new Comment("Susan", "This is really helpful" ));
        v1.AddComment(new Comment("Jun", "My cactus grown because of this"));
        videos.Add(v1);

        Video v2 = new Video("Trying the 1 Week Exercise Challenge", "ActiveLife", 645);
        v2.AddComment(new Comment("Rey", "Inspired to take on the challenge too"));
        v2.AddComment(new Comment("Nancy", "Would try to take on the challenge"));
        v2.AddComment(new Comment("Lynson", "Nice energy!"));
        videos.Add(v2);

        Video v3 = new Video("Vlog: Trip to Palawan", "Gino Hong", 900);
        v3.AddComment(new Comment("Mia", "I would love to take a trip as well"));
        v3.AddComment(new Comment("Rose", "Amazing vlog!"));
        v3.AddComment(new Comment("James", "Love this"));
        v3.AddComment(new Comment("Greg", "Palawan is so good"));
        videos.Add(v3);

        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}