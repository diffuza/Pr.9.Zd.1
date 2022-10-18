using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication4
{
    class Program
    {
        static void Main()
        {
            for (int i = 1; i <= 100; i++)
                Console.WriteLine(i + " " + Convert.ToDouble(i * 0.453));
        }
    }
}
