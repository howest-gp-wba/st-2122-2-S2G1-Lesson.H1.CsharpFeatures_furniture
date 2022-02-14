using System;
using System.Drawing;

namespace Lesson.H1.CsharpFeatures.Domain
{
    public class Furniture
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public FurnitureType Type { get; set; }
        public KnownColor Color {get; set;}

    }

    public enum FurnitureType { Chair, Table, Closet, Seat }
}
