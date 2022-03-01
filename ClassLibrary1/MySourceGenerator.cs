using System;
using Microsoft.CodeAnalysis;

namespace ClassLibrary1
{
    [Generator]
    public class MySourceGenerator : ISourceGenerator
    {
        public void Initialize(GeneratorInitializationContext context)
        {
            Console.WriteLine("Initializing generator...");
        }

        public void Execute(GeneratorExecutionContext context)
        {
            Console.WriteLine("Executing generator...");
        }
    }
}
