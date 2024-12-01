using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> youtube = new List<Video>();

        Video video1 = new Video("If you're ambitious but lazy, please watch this...", "HIM");
        Comment comment1 = new Comment("CutieKiwi", "Needed this cause I`m writing exams and need motivation for studying");
        Comment comment2 = new Comment("Aemon9090", "Sometimes I thank the algorithm. This is exactly what I needed! ");
        Comment comment3 = new Comment("KitKatLover", "Bro, your video is actually life-changing.");
        video1.SetComment(comment1);
        video1.SetComment(comment2);
        video1.SetComment(comment3);
        youtube.Add(video1);

        Video video2 = new Video("I Tried the $1 Billion Dollar Side Hustle", "viyaura");
        Comment comment4 = new Comment("wolsgurl","Marketing is so hard to do and I don’t care what people say about it isn’t easy to understand or learn. This was a great video");
        Comment comment5 = new Comment("ArisTheMage","I jut watched a 17 minute ad and I’m all for it");
        Comment comment6 = new Comment("MoonLaden","girly not only promoted her products but also got a sponsorship, nice");
        video2.SetComment(comment4);
        video2.SetComment(comment5);
        video2.SetComment(comment6);
        youtube.Add(video2);
        
        Video video3 = new Video("What your College Major says about you", "Crystal");
        Comment comment7 = new Comment("kittycatcrunchie","My majors are never in these man, it's always just 'bio' but art gets like 5 separate majors");
        Comment comment8 = new Comment("Lola-Ella","English major here,  I am so shocked at how spot on you are lmao");
        video3.SetComment(comment7);
        video3.SetComment(comment8);
        youtube.Add(video3);

        foreach (Video video in youtube)
        {
            video.DisplayVideo();
            Console.WriteLine();
        }
    }
}