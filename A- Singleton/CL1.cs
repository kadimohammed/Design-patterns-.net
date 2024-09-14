using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A__Singleton
{
    internal class CL1
    {
        public int a { get; set; }
        public int b { get; set; }

        private static CL1 instance { get; set; } = null!;

        private CL1()
        {

        }
        public static CL1 GetInstance()
        {
            if (instance == null)
            {
                instance = new CL1();
            }
            return instance;
        }

        public override string ToString()
        {
            return "a= " + a + "\nb=" + b;
        }
    }
}
