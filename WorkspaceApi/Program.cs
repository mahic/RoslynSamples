using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.MSBuild;

namespace WorkspaceApi
{
    class Program
    {
        private static void Main(string[] args)
        {
            var workspace = MSBuildWorkspace.Create();
            var solution = workspace.OpenSolutionAsync(@"..\..\..\RoslynSamples.sln").Result;
            var project = solution.Projects.First();
            var document = project.Documents.First();

            var dictionary = new Dictionary<string, Compilation>();

            foreach (var p in solution.Projects)
            {
                var compilation = p.GetCompilationAsync().Result;
                
                foreach(var r in p.MetadataReferences)
                    Console.WriteLine(r.Display);
            }

            Console.Read();
        }
    }
}