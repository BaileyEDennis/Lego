using System;
using Lego.Figures;
namespace Lego
{
    class Program
    {
        static void Main(string[] args)
        {
            ConstructionWorker worker1 = new ConstructionWorker(false, "Male", "Yellow Vest", "Cargo Pants", "A pipe wrench, A welder");
            worker1.Inspect();
            worker1.SpecialAttack();
        }
    }
}
