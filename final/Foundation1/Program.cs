using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new();
        Video v1 = new("Awesome Video Title", "GuyAwesome!", 300);
        v1.AddComment("Anon1", "First!");
        v1.AddComment("An0n2", "First!!  Edit: Dang I was too slow.");
        v1.AddComment("Fr33_M0n3y", "Click here for free money!");
        videos.Add(v1);

        Video v2 = new("Long Video Title", "GuyWhoTalksALot", 1900);
        v2.AddComment("Anon1", "First!");
        v2.AddComment("An0n2", "First!!  Edit: Dang second again.");
        v2.AddComment("Fr33_M0n3y", "Click here for free money!");
        videos.Add(v2);

        Video v3 = new("How to Beat the Thing!", "TutorialGuy", 1200);
        v3.AddComment("Anon1", "First!");
        v3.AddComment("An0n2", "First!!  Edit: Being first is impossible.");
        v3.AddComment("Fr33_M0n3y", "Has Been Banned");
        videos.Add(v3);

        foreach (Video v in videos)
        {
            v.Display();
        }
    }
}