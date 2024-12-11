using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace J__Template
{
    internal class TextFileProcessor : FileProcessor
    {
        protected override void ProcessData()
        {
            Console.WriteLine("Processing text file data...");
        }
    }
}
