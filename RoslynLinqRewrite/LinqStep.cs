﻿using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoslynLinqRewrite
{
    class LinqStep
    {
        public Lambda Lambda { get; set; }

        public LinqStep(string methodName, IReadOnlyList<ExpressionSyntax> arguments, InvocationExpressionSyntax invocation = null)
        {
            this.MethodName = methodName;
            this.Arguments = arguments;
            this.Invocation = invocation;
        }
        public string MethodName { get; }
        public IReadOnlyList<ExpressionSyntax> Arguments { get; }
        public InvocationExpressionSyntax Invocation { get; }

        public override string ToString()
        {
            return MethodName;
        }
    }
}
