using System;
using Lesson.H1.CsharpFeatures.Domain;
using System.Collections.Generic;

namespace Lesson.H1.CsharpFeatures.WebApp.ViewModels
{
    public class FurnitureListViewModel
    {
        public List<Furniture> Furnitures { get; set; }

        public int Count { get; set; }

        public string QuoteOfTheDay { get; set; }
    }
}
