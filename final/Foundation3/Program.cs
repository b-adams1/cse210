/*I don't think there is any exceeding/comment that needs to be made, but just in case, I didn't really do any excess creativity except for the details on the events!
~ Thanks! ~*/ 

using System;

class Program
{
    static void Main(string[] args)
    {
        Address addr1 = new Address("123 Main St", "New York", "NY", "USA");
        Address addr2 = new Address("45 E Broadwell St", "Los Angeles", "CA", "USA");
        Address addr3 = new Address("999 Park Ave", "Chicago", "IL", "USA");

        Lecture lecture = new Lecture(
            "Technology in the Classroom",
            "Lecture on proper use of technology in the common classroom",
            "April 10",
            "10:00 AM",
            addr1,
            "Dr. C.M. Puta",
            100
        );

        Reception reception = new Reception(
            "Jill and Jack's Wedding",
            "The wedding for Jill and Jack, including after-party",
            "June 12",
            "1:00 PM",
            addr2,
            "jill.hoveren@gmail.com"
        );

        OutdoorGathering outdoor = new OutdoorGathering(
            "Wilkonsen Family Reunion",
            "Food and games with the Wilkonsen Family",
            "August 29",
            "3:00 PM",
            addr3,
            "Sunny with light breeze"
        );

        Event[] events = new Event[] { lecture, reception, outdoor };

        foreach (Event e in events)
        {
            Console.WriteLine("----- STANDARD DETAILS -----");
            Console.WriteLine(e.GetStandardDetails());

            Console.WriteLine("\n----- FULL DETAILS -----");
            Console.WriteLine(e.GetFullDetails());

            Console.WriteLine("\n----- SHORT DESCRIPTION -----");
            Console.WriteLine(e.GetShortDescription());

            Console.WriteLine("\n============================\n");
        }
    }
}