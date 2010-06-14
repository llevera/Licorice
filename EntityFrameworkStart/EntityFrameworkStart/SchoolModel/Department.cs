using System;

namespace SchoolModel
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public Decimal Budget { get; set; }
        public DateTime StartDate { get; set; }
        public int Administrator { get; set; }
    }
}
