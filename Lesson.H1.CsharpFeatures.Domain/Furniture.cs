using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Lesson.H1.CsharpFeatures.Domain
{
    public class Furniture
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public FurnitureType Type { get; set; }
        public KnownColor Color {get; set;}

        public static List<Furniture> GetAll()
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

        public static List<Furniture> GetAllByType(FurnitureType type)
        {
            List<Furniture> allFurniture = Furniture.GetAll();

            //using loop
            //List<Furniture> filteredFurniture = new List<Furniture>();
            //foreach (Furniture furniture in allFurniture)
            //{
            //    if(furniture?.Type == type) filteredFurniture.Add(furniture);
            //}
            //return filteredFurniture;

            // using Linq
            return allFurniture.Where(f => f.Type == type).ToList();

        }


        public override string ToString()
        {
            return $"Meubelstuk nr. {Id}: {Type} - {Color} \t\t{Description}";
        }

    }

    public enum FurnitureType { Chair, Table, Closet, Seat }
}
