﻿using System;

using Stringes.Tokens;

namespace Manhood.Arithmetic.Parselets
{
    internal class NumberParselet : IPrefixParselet
    {
        public Expression Parse(Parser parser, Token<MathTokenType> token)
        {
            return new NumberExpression(Double.Parse(token.Value));
        }
    }
}