using Animal_Shelter_Api.Entities;
using Animal_Shelter_Api.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Animal_Shelter_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DogController : ControllerBase
    {
        public readonly IDogRepository _repository;

        public DogController(IDogRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IEnumerable<Dog> GetDogs() 
        {
            return _repository.GetDogs();
        }

        [HttpGet("{id}")]
        public ActionResult<Dog> GetDogById(int id)
        { 
            var dog = _repository.GetDogById(id);
            if (dog == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(dog); 
            }
        }

        [HttpPut("{id}")]
        public ActionResult UpdateDog(int id, string name) { 
            var resp = _repository.UpdateDog(id, name);
            if (!resp)
            {
                return NotFound();
            }
            else
            {
                return Ok("Dog Successfully Updated!");
            }
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteDog(int id)
        {
            var resp = _repository.DeleteDog(id);
            if (!resp)
            {
                return NotFound();
            }
            else 
            {
                return Ok("Dog Successfully Deleted!");
            }
        }

        [HttpPost]
        public ActionResult AddDog(string name)
        {
            _repository.AddDog(name);
            return Ok("Dog Successfully Created!");
           
        }
    }
}
