using System;

namespace NQuery.Algebra
{
    internal sealed class AlgebraIsNullExpression : AlgebraExpression
    {
        private readonly AlgebraExpression _expression;

        public AlgebraIsNullExpression(AlgebraExpression expression)
        {
            _expression = expression;
        }

        public override AlgebraKind Kind
        {
            get { return AlgebraKind.IsNullExpression; }
        }

        public AlgebraExpression Expression
        {
            get { return _expression; }
        }
    }
}