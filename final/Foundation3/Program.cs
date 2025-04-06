using System;

class Program
{
    static void Main(string[] args)
    {
        List<Event> events = new();

        LectureEvent lecture = new LectureEvent
        ("C3PO vs R2D2", "Best Robot in Starwars", "5/4/2025", "9:00am", "445 11th Ave,New York City,NY,USA", "John Doe", 100);
        events.Add(lecture);

        ReceptionEvent reception = new ReceptionEvent
        ("Wedding", "Leia Organa to wed Han Solo", "3/14/2025", "7:00pm",
        "Near the Sheild Genorator,Forest of Endor,Continent of Endor,Planet of Endor", "NotMyBrother.com");
        events.Add(reception);

        GatheringEvent gathering = new GatheringEvent
        ("FanX", "Salt Lake City FanX Con", "09/26/25", "10:00am",
        "100 S W Temple St,Salt Lake City,UT,USA", "Cloudy");
        events.Add(gathering);

        foreach (Event e in events)
        {
            string basedetails = e.GetBaseDetails();
            string full = e.GetFullDetails();
            string shortdetails = e.GetShortDetails();

            Console.WriteLine($"{basedetails}\n\n{full}\n\n{shortdetails}");
            Console.WriteLine("=====================\n");

        }
    }
}