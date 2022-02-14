using System;
using System.Collections.Generic;
using System.Drawing;

namespace Lesson.H1.CsharpFeatures.Domain
{
    public class Furniture
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public FurnitureType Type { get; set; }
        public KnownColor Color {get; set;}

        public List<Furniture> GetAll()
        {
            return new List<Furniture>
            {
                new Furniture
                    {
                        Id = 1,
                        Type = FurnitureType.Chair,
                        Description = "Een gemakkelijke stoel",
                        Color = KnownColor.SaddleBrown
                    },
                new Furniture
                    {
                        Id = 2,
                        Type = FurnitureType.Seat,
                        Description = "Een lederen zetel",
                        Color = KnownColor.GreenYellow
                    },
                new Furniture
                    {
                        Id = 3,
                        Type = FurnitureType.Table,
                        Description = "Een plastieken tafel",
                        Color = KnownColor.White
                    },
            };
        }

    }

    public enum FurnitureType { Chair, Table, Closet, Seat }
}
