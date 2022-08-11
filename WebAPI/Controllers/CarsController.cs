using Bussiness.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class CarsController : Controller
    {
        ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _carService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getcarsbybrandid")]

        public IActionResult GetCarsByBrandId(int id)
        {
            var result = _carService.GetCarsByBrandId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getcarsbycolorid")]

        public IActionResult GetCarsByColorId(int id)
        {
            var result = _carService.GetCarsByColorId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getcardetails")]
        public IActionResult GetCarDetails()
        {
            var result = _carService.GetCarDetails();

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpPost("caradd")]
        public IActionResult Add(CarDetailDto carDetailDto, Car car)
        {
            var result = _carService.Add(carDetailDto, car);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpPost("cardelete")]
        public IActionResult CarDelete(Car car)
        {
            var result = _carService.CarDelete(car);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("carremove")]
        public IActionResult CarRemove(Car car)
        {
            var result = _carService.CarRemove(car);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
    }
}
