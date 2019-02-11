using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using NetCoreRepositoryDesign.Entities.Concrete;

namespace NetCoreRepositoryDesign.DataAccess.Repositories.Abstract
{
    public interface IPersonnelRepository:IRepository<Personnel>
    {
        IEnumerable<Personnel> GetPersonnelsWithDepartment(Expression<Func<Personnel, bool>> filter = null);
    }
}
