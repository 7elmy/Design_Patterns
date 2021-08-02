using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Builder
{
    public interface ILaptopBuilder
    {
        public void AddCPU();
        public void AddGPU();
        public void AddRAM();
    }
}
