#if NETFRAMEWORK
using Newtonsoft.Json;
#elif NET5_0_OR_GREATER
using System.Text.Json;
#endif
using System;

namespace NugetPackagDemo
{
    public static class NugetPackageExample
    {
        public static void NugetPackageTester()
        {
            var serialize = new SerializeMe()
            {
                Bar = "BAR",
                Foo = "FOO",
                Count = 999
            };


#if NETFRAMEWORK
            Console.WriteLine("Using nuget package as NetFramework 4.8");
            var jsonString = JsonConvert.SerializeObject(serialize,Formatting.Indented);
            Console.WriteLine(jsonString);
#elif NET5_0_OR_GREATER
            Console.WriteLine("Using nuget package as .Net 5.0");
            var jsonString = JsonSerializer.Serialize(serialize, new JsonSerializerOptions { WriteIndented = true });
            Console.WriteLine(jsonString);
#endif
        }
    }
}
