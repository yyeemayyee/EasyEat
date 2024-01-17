using System;
using System.Collections.Generic;
using System.Text;

namespace Easyeat.Domain
{
    public class Progress
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public string Date { get; set; }
        public int IdUserinfo { get; set; }
    }
}
