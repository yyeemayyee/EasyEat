using System;
using System.Collections.Generic;
using System.Text;

namespace Easyeat.Domain
{
    public class Dish
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Structure { get; set; }
        public string Numberofcalories { get; set; }
        public string Typeofdish { get; set; }
        public string Typeofdiet { get; set; }
        public string ImagePath { get; set; }
    }
}
