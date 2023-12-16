using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational.Builder
{
    public class LaptopBuilderNum2 : LaptopBuilder
    {

        private readonly int _num = 2;

        public override void AddCPU()
        {
            Get().CPU = _num;
        }

        public override void AddGPU()
        {
            Get().GPU = _num;
        }

        public override void AddRAM()
        {
            Get().RAM = _num;
        }
    }
}
