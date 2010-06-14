﻿using System.Data.Objects;
using EntityFrameworkStart.SchoolModel;

namespace EntityFrameworkStart
{
    public class SchoolContext : ObjectContext
    {
        public SchoolContext()
            : base( "name=SchoolEntities",
                   "SchoolModelStoreContainer")
        {
            Departments = CreateObjectSet<Department>();
        }

        public ObjectSet<Department> Departments{ get; set;}
    }
}