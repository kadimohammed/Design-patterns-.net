using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B__Builder
{
    public class Computer
    {
        public string Processor { get; set; }
        public int Memory { get; set; }
        public string Storage { get; set; }
        public string GraphicsCard { get; set; }

        public override string ToString()
        {
            return $"Processor: {Processor}, Memory: {Memory}GB, Storage: {Storage}, GraphicsCard: {GraphicsCard}";
        }
    }
}
