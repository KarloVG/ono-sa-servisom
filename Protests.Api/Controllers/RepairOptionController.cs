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
    [Route("api/repairOptions")]
    public class RepairOptionController : BaseController
    {

        private readonly IRepairOptionRepository repairOptionRepository;
        private readonly IMapper mapper;

        public RepairOptionController(
            IRepairOptionRepository repairOptionRepository,
            IMapper mapper
        )
        {
            this.repairOptionRepository = repairOptionRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<RepairOption>> GetAll([FromQuery] string search)
        {
            var repairOptions = this.repairOptionRepository.GetAll(search);
            return Ok(repairOptions);
        }

        [HttpPost]
        public ActionResult<IEnumerable<RepairOption>> CreateRepairOption(RepairOption repairOption)
        {
            var repairOptions = this.repairOptionRepository.Create(repairOption);
            return Ok(repairOptions);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(long id)
        {
            this.repairOptionRepository.Delete(id);
            return Ok(new { success = true });
        }
    }
}
