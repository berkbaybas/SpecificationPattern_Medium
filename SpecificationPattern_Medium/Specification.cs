using System.Linq.Expressions;

namespace SpecificationPattern_Medium
{
    public abstract class Specification<T>
    {
        public abstract Expression<Func<T, bool>> ToExpression();
        public bool IsSatisfiedBy(T entity)
        {
            Func<T, bool> predicate = ToExpression().Compile();
            return predicate(entity);
        }

        public Specification<T> And(Specification<T> specification)
            => new AndSpecification<T>(this, specification);
        public Specification<T> Or(Specification<T> specification)
            => new OrSpecification<T>(this, specification);
        public Specification<T> NotEqual(Specification<T> specification)
            => new NotEqualSpecification<T>(this, specification);
        public Specification<T> Equal(Specification<T> specification)
            => new EqualSpecification<T>(this, specification);
    }
}
