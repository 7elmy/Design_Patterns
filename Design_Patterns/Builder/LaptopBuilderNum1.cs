using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Builder
{
    public class LaptopBuilderNum1 : ILaptopBuilder
    {
        private Laptop Laptop;
        private readonly int _num = 1;

        public LaptopBuilderNum1()
        {
            Reset();
        }

        public void Reset()
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
            var laptop= Laptop;
            Reset();
            return laptop;
        }
    }
}
