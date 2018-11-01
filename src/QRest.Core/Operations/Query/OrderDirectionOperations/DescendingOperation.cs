﻿using QRest.Core.Expressions;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace QRest.Core.Operations.Query.OrderDirectionOperations
{
    public class DescendingOperation : OperationBase
    {
        public override Expression CreateExpression(ParameterExpression root, Expression context, IReadOnlyList<Expression> arguments)
        {
            if (arguments.Count != 0)
                throw new ExpressionCreationException();

            return new DescendingExpression(context);
        }
    }
}
