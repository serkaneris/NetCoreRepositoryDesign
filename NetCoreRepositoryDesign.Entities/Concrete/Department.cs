using NetCoreRepositoryDesign.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreRepositoryDesign.Entities.Concrete
{
    public class Department:BaseEntity,IEntity
    {
        public Department()
        {
            Personnels = new List<Personnel>();
        }

        //public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Personnel> Personnels { get; set; }
    }
}
