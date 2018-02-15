﻿using QRest.Core.Expressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace QRest.Core.Operations.Aggregations
{
    public class CountOperation : OperationBase
    {
        public override bool SupportsQuery => true;

        public override Expression CreateQueryExpression(ParameterExpression root, Expression context, ParameterExpression argumentsRoot, IReadOnlyList<Expression> arguments)
        {
            if (arguments.Count != 0)
                throw new ExpressionCreationException();            

            var exp = Expression.Call(typeof(Queryable), nameof(Queryable.Count), new Type[] { argumentsRoot.Type }, context);

            return new NamedExpression(exp, nameof(Queryable.Count));
        }
    }
}
