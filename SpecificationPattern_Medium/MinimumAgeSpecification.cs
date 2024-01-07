using SpecificationPattern_Medium.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

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
