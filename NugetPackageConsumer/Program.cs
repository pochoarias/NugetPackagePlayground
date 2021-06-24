using NugetPackagDemo;
using System;

namespace NugetPackageConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Using nuget packages");
            NugetPackageExample.NugetPackageTester();
        }
    }
}
