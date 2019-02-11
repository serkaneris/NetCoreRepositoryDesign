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
    public class PersonnelRepository:Repository<Personnel>,IPersonnelRepository
    {
        public PersonnelRepository(NcrdContext context) : base(context)
        {
        }

        public NcrdContext NcrdContext
        {
            get
            {
                return _context as NcrdContext;
            }
        }

        public IEnumerable<Personnel> GetPersonnelsWithDepartment(Expression<Func<Personnel, bool>> filter = null)
        {

            return filter == null ? NcrdContext.Personnels.Include("Department").ToList() : 
                NcrdContext.Personnels.Include("Department").Where(filter).ToList();
        }


    }
}
