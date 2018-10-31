﻿using QRest.Core.Expressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace QRest.Core.Operations.Query
{
    public class WhereOperation : OperationBase
    {
        public override bool SupportsQuery => true;
        public override bool SupportsCall => true;

        public override Expression CreateCallExpression(Expression root, Expression context, IReadOnlyList<Expression> arguments)
        {
            if (arguments.Count != 1)
                throw new ExpressionCreationException();

            if (arguments[0].NodeType != ExpressionType.Lambda)
                throw new ExpressionCreationException();

            var lambda = (LambdaExpression)arguments[0];

            var exp = Expression.Call(typeof(Queryable), nameof(Queryable.Where), new Type[] { lambda.Parameters[0].Type }, context, lambda);

            return new NamedExpression(exp, NamedExpression.DefaultQueryResultName);
        }      
    }
}
