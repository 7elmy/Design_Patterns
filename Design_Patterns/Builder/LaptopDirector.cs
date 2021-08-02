using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Builder
{
   public class LaptopDirector
    {
        private ILaptopBuilder LaptopBuilder;
        public void SetBuilder(ILaptopBuilder laptopBuilder)
        {
            LaptopBuilder = laptopBuilder;
        }
        
        public void FullBuild()
        {
            LaptopBuilder.AddCPU();
            LaptopBuilder.AddGPU();
            LaptopBuilder.AddRAM();
        }

        public void BuildWithoutRAM()
        {
            LaptopBuilder.AddCPU();
            LaptopBuilder.AddGPU();
        }


    }
}
