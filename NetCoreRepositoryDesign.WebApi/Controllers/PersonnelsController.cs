using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCoreRepositoryDesign.Business.Abstract;
using NetCoreRepositoryDesign.Business.Concrete;
using NetCoreRepositoryDesign.DataAccess;

namespace NetCoreRepositoryDesign.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonnelsController : ControllerBase
    {
        /*
         * This Controller communicate with Business Layer then Businness Layer communicate with DataAccess(With UnitOfWork)
         */

        private IPersonnelService _personnelService;
        public PersonnelsController(IPersonnelService personnelService)
        {
            _personnelService = personnelService;
        }

        // GET api/personnels
        [HttpGet]
        public IActionResult Get()
        {
            //Test01
            //var lst = _personnelService.GetActivePersonnels();

            //Test02
            var lst = _personnelService.GetNewPersonnels();
            return null;
        }
    }
}