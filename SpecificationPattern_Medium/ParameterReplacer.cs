using System.Linq.Expressions;

namespace SpecificationPattern_Medium
{
    class ParameterReplacer : ExpressionVisitor
    {
        private readonly ParameterExpression _parameter;
        public ParameterReplacer(ParameterExpression parameter)
            => _parameter = parameter;
        protected override Expression VisitParameter(ParameterExpression node)
            => base.VisitParameter(_parameter);
    }
}
