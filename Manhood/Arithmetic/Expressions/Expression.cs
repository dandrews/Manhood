﻿using Manhood.Compiler;

namespace Manhood.Arithmetic
{
    internal abstract class Expression
    {
        public abstract double Evaluate(Parser parser, Interpreter ii);
    }
}