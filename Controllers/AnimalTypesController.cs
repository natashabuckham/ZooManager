using Microsoft.AspNetCore.Mvc;
using ZooManager.Models.Request;
using ZooManager.Models.Response;
using ZooManager.Repositories;

namespace ZooManager.Controllers
{
    [ApiController]
    [Route("/animaltypes")]

     public class AnimalTypesController: ControllerBase
    {
        private readonly IAnimalTypesRepo _animalTypes;

        public AnimalTypesController(IAnimalTypesRepo animalTypes)
        {
            _animalTypes = animalTypes;
        }

        [HttpGet("{id}")]
        public ActionResult<AnimalTypeResponse> GetById([FromRoute] int id)
        {
            var animalType = _animalTypes.GetById(id);
            return new AnimalTypeResponse(animalType);
        }


        [HttpPost("create")]
        public IActionResult Create([FromBody] CreateAnimalTypeRequest newAnimalType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var animalType = _animalTypes.Create(newAnimalType);
            var url = Url.Action("GetById", new { id = animalType.Id });
            var animalTypeResponse = new AnimalTypeResponse(animalType);
            return Created(url, animalTypeResponse);
        }

        [HttpGet("")]
        public ActionResult<IEnumerable<AnimalTypeResponse>> GetAll()
        {
            var animalTypes = _animalTypes.GetAll();

            return Ok(animalTypes.Select(animalType => new AnimalTypeResponse(animalType)));
        }
    }
}