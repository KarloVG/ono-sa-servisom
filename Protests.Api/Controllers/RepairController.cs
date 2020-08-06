using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Protests.Core.Repositories;
using Protests.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Protests.Api.Controllers
{
    [Route("api/repairs")]
    public class RepairController : BaseController
    {

        private readonly IRepairRepository repairRepository;
        private readonly IMapper mapper;

        public RepairController(
            IRepairRepository repairRepository,
            IMapper mapper
        )
        {
            this.repairRepository = repairRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Repair>> GetAll([FromQuery] string search)
        {
            var repairs = this.repairRepository.GetAll(search);
            return Ok(repairs);
        }

        [HttpPost]
        public ActionResult<IEnumerable<Repair>> CreateRepair(Repair repair)
        {
            var repairs = this.repairRepository.Create(repair);
            return Ok(repairs);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(long id)
        {
            this.repairRepository.Delete(id);
            return Ok(new { success = true });
        }
    }
}
