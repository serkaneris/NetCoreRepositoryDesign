using NetCoreRepositoryDesign.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreRepositoryDesign.Entities.Concrete
{
    public class Personnel:BaseEntity,IEntity
    {
        public Personnel()
        {
            Department = new Department();
        }

        //public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
