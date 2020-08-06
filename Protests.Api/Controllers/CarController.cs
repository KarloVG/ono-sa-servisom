using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Protests.Core.Repositories;
using Protests.Data;

namespace Protests.Api.Controllers
{
    [Route("api/cars")]
    public class CarController : BaseController
    {

        private readonly ICarRepository carRepository;
        private readonly IMapper mapper;

        public CarController(
            ICarRepository carRepository,
            IMapper mapper
        )
        {
            this.carRepository = carRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Car>> GetAll([FromQuery] string search)
        {
            var cars = this.carRepository.GetAll(search);
            return Ok(cars);
        }

        [HttpPost]
        public ActionResult<IEnumerable<Car>> CreateCar(Car car)
        {
            var cars = this.carRepository.Create(car);
            return Ok(cars);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(long id)
        {
            this.carRepository.Delete(id);
            return Ok(new { success = true });
        }
    }
}
