using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using NetCoreRepositoryDesign.DataAccess;

namespace NetCoreRepositoryDesign.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        /*
         * This Controller directly communicate with DataAccess Layer and UnitOfWork without Business layer.
         */

        private IUnitOfWork _unitOfWork;
        public ValuesController(NcrdContext context)
        {
            _unitOfWork = new UnitOfWork(context);
        }

        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            //Test01 Get all with out filter
            //var lst = _unitOfWork.PersonnelRepository.GetAll();

            //Test02 Get all with filter
            //var lst = _unitOfWork.PersonnelRepository.GetAll(x => x.Id > 4);

            //Test03 Get with join
            //var lst = _unitOfWork.PersonnelRepository.GetPersonnelsWithDepartment();
            var lst = _unitOfWork.DepartmentRepository.GetDepartmentsWithPersonnels();
            return null;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
