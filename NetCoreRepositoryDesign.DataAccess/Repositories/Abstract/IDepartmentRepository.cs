using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using NetCoreRepositoryDesign.Entities.Concrete;

namespace NetCoreRepositoryDesign.DataAccess.Repositories.Abstract
{
    public interface IDepartmentRepository:IRepository<Department>
    {
        IEnumerable<Department> GetDepartmentsWithPersonnels(Expression <Func<Department,bool>> filter = null);
    }
}
