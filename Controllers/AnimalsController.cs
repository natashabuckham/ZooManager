using Microsoft.AspNetCore.Mvc;
using ZooManager.Models.Request;
using ZooManager.Models.Response;
using ZooManager.Repositories;

namespace ZooManager.Controllers
{
    [ApiController]
    [Route("/animals")]

    public class AnimalsController: ControllerBase
    {
        private readonly IAnimalsRepo _animals;

        public AnimalsController(IAnimalsRepo animals)
        {
            _animals = animals;
        }

        [HttpGet("{id}")]
        public ActionResult<AnimalResponse> GetById([FromRoute] int id)
        {
            var animal = _animals.GetById(id);

            return new AnimalResponse(animal);
        }

        [HttpPost("create")]
        public IActionResult Create([FromBody] CreateAnimalRequest newAnimal)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var animal = _animals.Create(newAnimal);

            var url = Url.Action("GetById", new { id = animal.Id });
            var animalResponse = new AnimalResponse(animal);
            return Created(url, animalResponse);
        }
    }
}