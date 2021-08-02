using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Builder
{
    class LaptopBuilderNum2
    {
        private Laptop Laptop;
        private readonly int _num = 2;

        public LaptopBuilderNum2()
        {
            Laptop = new Laptop();
        }
        public void AddCPU()
        {
            Laptop.CPU = _num;
        }

        public void AddGPU()
        {
            Laptop.GPU = _num;
        }

        public void AddRAM()
        {
            Laptop.RAM = _num;
        }

        public Laptop Build()
        {
            return Laptop;
        }
    }
}
