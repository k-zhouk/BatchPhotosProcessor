using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Reflection;

namespace BatchPhotosProcessor
{
    internal class BatchPhotosProcessor
    {
        static void Main(string[] args)
        {
            // Getting the version of the program
            string appVerion = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            Console.WriteLine($"{Environment.NewLine}******************** Batch Photos Processer (ver. {appVerion}) ********************{Environment.NewLine}");
        }
    }
}
