using SpecificationPattern_Medium.Models;
using System.Linq.Expressions;

namespace SpecificationPattern_Medium
{
    public class MinimumAgeSpecification : Specification<Person>
    {
        public override Expression<Func<Person, bool>> ToExpression()
        {
            return x => x.Age >= 18;
        }
    }
}
