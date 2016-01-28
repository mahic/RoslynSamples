using System;
using System.IO;
using Microsoft.CodeAnalysis.CSharp;

namespace NNUG_Roslyn
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var source = File.ReadAllText("C.cs");
            var tree = SyntaxFactory.ParseCompilationUnit(source);

            Console.Read();
        }
    }
}