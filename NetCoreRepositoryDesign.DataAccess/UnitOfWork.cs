using System;
using System.Collections.Generic;
using System.Text;
using NetCoreRepositoryDesign.DataAccess.Repositories.Abstract;
using NetCoreRepositoryDesign.DataAccess.Repositories.Concrete;

namespace NetCoreRepositoryDesign.DataAccess
{
    public class UnitOfWork:IUnitOfWork
    {
        private NcrdContext _context;
        public UnitOfWork(NcrdContext context)
        {
            _context = context;
            DepartmentRepository = new DepartmentRepository(context);
            PersonnelRepository = new PersonnelRepository(context);
        }

        public IDepartmentRepository DepartmentRepository { get; private set; }
        public IPersonnelRepository PersonnelRepository { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }


        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
