using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational.Builder
{
    public class LaptopDirector
    {

        public Laptop FullBuild(LaptopBuilder laptopBuilder)
        {
            laptopBuilder.AddCPU();
            laptopBuilder.AddGPU();
            laptopBuilder.AddRAM();

            return laptopBuilder.Build();
        }

        public Laptop BuildWithoutRAM(LaptopBuilder laptopBuilder)
        {
            laptopBuilder.AddCPU();
            laptopBuilder.AddGPU();

            return laptopBuilder.Build();
        }


    }
}
