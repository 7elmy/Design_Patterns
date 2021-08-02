using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Builder
{
    public class Laptop
    {
        public int CPU { get; set; }
        public int GPU { get; set; }
        public int RAM { get; set; }

        public override string ToString()
        {
            return $"CPU: {CPU}, GPU: {GPU}, RAM: {RAM}";
        }
    }
}
