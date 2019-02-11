using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Microsoft.EntityFrameworkCore;
using NetCoreRepositoryDesign.DataAccess.Repositories.Abstract;
using NetCoreRepositoryDesign.Entities.Concrete;

namespace NetCoreRepositoryDesign.DataAccess.Repositories.Concrete
{
    public class DepartmentRepository:Repository<Department>,IDepartmentRepository
    {
        public DepartmentRepository(NcrdContext context) : base(context)
        {
            
        }

        public NcrdContext NcrdContext
        {
            get
            {
                return _context as NcrdContext;
            }
        }

        public IEnumerable<Department> GetDepartmentsWithPersonnels(Expression<Func<Department, bool>> filter = null)
        {
            return filter == null ? NcrdContext.Departments.Include("Personnels").ToList():
                NcrdContext.Departments.Include("Personnels").Where(filter).ToList();
        }
    }
}
