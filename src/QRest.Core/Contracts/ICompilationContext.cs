﻿using QRest.Core.Terms;
using System;
using System.Linq.Expressions;

namespace QRest.Core.Contracts
{
    public interface ICompilationContext
    {
        LambdaExpression Assemble(TermSequence term, Type root, Type context);
    }
}
