using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntityFrameworkStart;
using NUnit;
using NUnit.Framework;

namespace EntityFrameworkStartTests
{
    [TestFixture]
    public class DepartmentFixture
    {
        [Test]
        public void WhenDepartmentSaved_ThenItCanBeFetched()
        {
            SchoolContext context = new SchoolContext();

            var departments = context.Departments.Where(x => x.Budget > 100);

            Assert.That(departments.Count(), Is.GreaterThan(0) );
        }
    }
}
