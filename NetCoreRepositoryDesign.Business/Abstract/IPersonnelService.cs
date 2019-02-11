using NetCoreRepositoryDesign.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreRepositoryDesign.Business.Abstract
{
    public interface IPersonnelService
    {
        //this functions are sample! ;)
        IEnumerable<Personnel> GetActivePersonnels();
        IEnumerable<Personnel> GetNewPersonnels();
        void AddPersonnel(Personnel personnel);
    }
}
