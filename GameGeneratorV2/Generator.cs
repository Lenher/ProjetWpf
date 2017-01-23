using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameGenerator
{
    public class Generator
    {

        public static void Main(string[] args)
        {
            EngineGenerator gen = new EngineGenerator();
            gen.CreateFileJson();
        }
    }
}
