using NetCoreRepositoryDesign.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreRepositoryDesign.Entities.Concrete
{
    public class Departmant:BaseEntity,IEntity
    {
        public Departmant()
        {
            Personnels = new List<Personnel>();
        }

        //public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Personnel> Personnels { get; set; }
    }
}
