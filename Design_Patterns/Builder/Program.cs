using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Builder
{

    class Program
    {
        static void Main(string[] args)
        {
            var director = new LaptopDirector();
            //we could implement another builder
            var laptop1 = new LaptopBuilderNum1();

            director.SetBuilder(laptop1);

            director.FullBuild();
            var res1 = laptop1.Build();
            Console.WriteLine(res1);

            director.BuildWithoutRAM();
            var res2 = laptop1.Build();
            Console.WriteLine(res2);

        }
    }

}
