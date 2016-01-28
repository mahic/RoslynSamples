using System;
using Microsoft.CodeAnalysis.Emit;

namespace EmitApi
{
    public class CompilationException : Exception
    {
        public CompilationException(EmitResult compileResult) : base(CreateMessage(compileResult))
        {
        }

        private static string CreateMessage(EmitResult compileResult)
        {
            return "Compile failed" + string.Join(Environment.NewLine, compileResult.Diagnostics);
        }
    }
}