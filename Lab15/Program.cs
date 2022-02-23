using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    class Program
    {
        static void Main(string[] args)
        {
            ArithProgression aprogression = new ArithProgression();
            aprogression.SetStart(25);
            aprogression.SetStep(5);
            Console.WriteLine(aprogression.GetNext());
            Console.WriteLine(aprogression.GetNext());
            Console.WriteLine(aprogression.GetNext());
            aprogression.Reset();
            Console.WriteLine(aprogression.GetNext());
            Console.WriteLine(aprogression.GetNext());
            Console.WriteLine(aprogression.GetNext());
            
            Console.WriteLine();

            GeomProgression geomProgression = new GeomProgression();
            geomProgression.SetStart(2);
            geomProgression.SetStep(2);
            Console.WriteLine(geomProgression.GetNext());
            Console.WriteLine(geomProgression.GetNext());
            Console.WriteLine(geomProgression.GetNext());
            geomProgression.Reset();
            Console.WriteLine(geomProgression.GetNext());
            Console.WriteLine(geomProgression.GetNext());
            Console.ReadKey();
        }       
    }
}
