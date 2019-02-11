using System;
using System.Collections.Generic;
using System.Text;
using NetCoreRepositoryDesign.DataAccess.Repositories.Abstract;

namespace NetCoreRepositoryDesign.DataAccess
{
    public interface IUnitOfWork:IDisposable
    {
        IDepartmentRepository DepartmentRepository { get;}
        IPersonnelRepository PersonnelRepository { get; }

        int Complete();
        
    }
}
