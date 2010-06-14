using System;
using System.Data.Objects.DataClasses;

namespace EntityFrameworkStart.SchoolModel
{
    public class Department 
    {
        public int DepartmentId { get; set; }
        public String Name { get; set; }
        public Decimal Budget { get; set; }
        public DateTime StartDate { get; set; }
        public int? Administrator { get; set; }
    }
}