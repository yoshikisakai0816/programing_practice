using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton
{
    internal class CSingleton2
    {
        // private variable
        private static CSingleton2 _cSingleton2Instance = new CSingleton2();

        // puropay
        public static CSingleton2 Instance => _cSingleton2Instance;

        // constracta
        private CSingleton2() { }
    }
}
