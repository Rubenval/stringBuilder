using System;
using stringBuilder.Entities;

namespace stringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Comments c1 = new Comments("Have a nice trip!");
            Comments c2 = new Comments("Wow that's awesome!");
            Post p1 = new Post(
                DateTime.Parse("21/06/2018 12:05:44"),
                "Traveling to New Zeland",
                "I'm going to visit this wonderful country!",
                12);
            p1.AddComment(c1);
            p1.AddComment(c2);

            c1 = new Comments("Tenha uma boa viagem!");
            c2 = new Comments("Ótimo país!");
            Post p2 = new Post(
                DateTime.Parse("22/06/2018 12:05:44"),
                "Traveling to New Zeland",
                "I'm going to visit this wonderful country!",
                12);
            p2.AddComment(c1);
            p2.AddComment(c2);

            Console.WriteLine(p1);
            Console.WriteLine();
            Console.WriteLine(p2);
            Console.ReadLine();
        }
    }
}
