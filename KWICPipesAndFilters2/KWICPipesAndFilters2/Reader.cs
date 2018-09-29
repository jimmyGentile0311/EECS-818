using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KWICPipesAndFilters2
{
    public class Reader : IOperation<string>
    {
        public IEnumerable<string> Execute(IEnumerable<string> input)
        {
            Console.Title = "Pipes and Filters Pattern in .NET";
            Console.WriteLine("Enter the path of the file:");
            return File.ReadLines(Console.ReadLine());
        }
    }
}

