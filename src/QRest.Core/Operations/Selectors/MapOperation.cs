﻿using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using QRest.Core.Contracts;

namespace QRest.Core.Operations.Selectors
{
    public class MapOperation : OperationBase
    {
        public override string Key { get; } = "map";

        public override Expression CreateExpression(ParameterExpression root, Expression context, IReadOnlyList<Expression> arguments, IAssemblerContext assembler)
        {            
            var expression = arguments.Any() ? assembler.CreateContainer(arguments) : context;
            return expression;
        }
    }
}