using System;
using System.Collections.Generic;
using System.Text;

namespace Labs216.Gabdulkhaev.Strategiya
{
    abstract class Character
    {
        public int health_point { get; set; }
        public int damage { get; set; }
        public int speed { get; set; }
        public int zachita { get; set; }
    }
}
