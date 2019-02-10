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
            Departmant = new Departmant();
        }

        //public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int DepartmantId { get; set; }
        public Departmant Departmant { get; set; }
    }
}
