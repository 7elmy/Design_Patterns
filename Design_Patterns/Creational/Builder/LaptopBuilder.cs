using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational.Builder
{
    public abstract class LaptopBuilder
    {
        private Laptop Laptop;
        public LaptopBuilder()
        {
            Reset();
        }
        private void Reset()
        {
            Laptop = new Laptop();
        }
        public Laptop Build()
        {
            var laptop = Get();
            Reset();
            return laptop;
        }

        protected Laptop Get()
        {
            return Laptop;
        }
        public abstract void AddCPU();
        public abstract void AddGPU();
        public abstract void AddRAM();
    }
}
