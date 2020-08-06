using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Protests.Core.Repositories;
using Protests.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Protests.Api.Controllers
{
    [Route("api/drivers")]
    public class DriverController : BaseController
    {
        private readonly IDriverRepository driverRepository;
        private readonly IMapper mapper;
        public DriverController(
            IDriverRepository driverRepository,
            IMapper mapper
        )
        {
            this.driverRepository = driverRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Driver>> GetAll([FromQuery] string search)
        {
            var drivers = this.driverRepository.GetAll(search);
            return Ok(drivers);
        }

        [HttpPost]
        public ActionResult<IEnumerable<Driver>> CreateDriver(Driver driver)
        {
            var drivers = this.driverRepository.Create(driver);
            return Ok(drivers);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(long id)
        {
            this.driverRepository.Delete(id);
            return Ok(new { success = true });
        }
    }
}