using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework3;
using NUnit.Framework;

namespace Test
{
    [TestFixture]
    class BasicReaderTest
    {
        [Test]
        public void ReadDataFromFileTest()
        {
            BasicReader reader = new BasicReader(); // as method is not static we need to initialize it first as reader.
            string output = reader.ReadFileIntoString();
            Console.WriteLine(output);
            //Trace.Write(output);


        }

    }
}
