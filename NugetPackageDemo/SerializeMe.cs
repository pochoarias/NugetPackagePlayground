using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NugetPackagDemo
{
    public class SerializeMe
    {
        public int Count { get; set; }
        public string  Foo { get; set; }
        public string Bar { get; set; }

        public SerializeMe()
        {
            Count = 0;
            Foo = "";
            Bar = "";

        }

        public SerializeMe(int count = 0, string foo = "", string bar ="")
        {
            Count = count;
            Foo = foo;
            Bar = bar;
        }

        public override string ToString()
        {
            return $"Count: {Count}, Foo: {Foo}, Boo: {Bar}";
        }
    }
}
