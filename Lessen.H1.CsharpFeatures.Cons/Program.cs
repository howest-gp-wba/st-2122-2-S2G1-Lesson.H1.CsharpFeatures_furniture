using Lesson.H1.CsharpFeatures.Domain;
using System;
using System.Drawing;

namespace Lessen.H1.CsharpFeatures.Cons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Furniture myChair = new Furniture
            {
                Id = 1,
                Type = FurnitureType.Chair,
                Description = "Een gemakkelijke stoel",
                Color = KnownColor.SaddleBrown
            };

            Console.WriteLine($"Meubelstuk nr. {myChair.Id}: {myChair.Type} - {myChair.Color} \t\t{myChair.Description}");
        }
    }
}
