using System;
using System.Collections.Generic;
using System.Text;
using NetCoreRepositoryDesign.Business.Abstract;
using NetCoreRepositoryDesign.DataAccess;
using NetCoreRepositoryDesign.Entities.Concrete;

namespace NetCoreRepositoryDesign.Business.Concrete
{
    public class PersonnelService:IPersonnelService
    {
        private IUnitOfWork _unitOfWork;
        public PersonnelService(NcrdContext context)
        {
            _unitOfWork = new UnitOfWork(context);
        }

        public IEnumerable<Personnel> GetActivePersonnels()
        {
            //make some business works here!!! :)
            return _unitOfWork.PersonnelRepository.GetAll(x => x.IsActive == true);
        }

        public IEnumerable<Personnel> GetNewPersonnels()
        {
            //make some business works here!!! :)
            return _unitOfWork.PersonnelRepository.GetAll(x => x.IsActive == true && x.CreatedAt.Year == DateTime.Now.Year);
        }

        public void AddPersonnel(Personnel personnel)
        {
            _unitOfWork.PersonnelRepository.Add(personnel);
            _unitOfWork.Complete();
        }
    }
}
