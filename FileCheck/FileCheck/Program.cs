using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = Path.Combine(System.Environment.CurrentDirectory, "chinacity.jpg");
            var result = FileTypeCheck.CheckImageTypeName(path);
            Console.WriteLine(result);
        }
    }
}
