using Animal_Shelter_Api.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;

namespace Animal_Shelter_Api.Repositories
{
    public class DogRepository : IDogRepository
    {

        private readonly MyDbContext _context;

        public DogRepository(MyDbContext context)
        {
            _context = context;
        }

        //private readonly List<Dog> _repository = new()
        //{
        //    new() { Id = 1, Name = "Alfie" },
        //    new() { Id = 2, Name = "Apollo" },
        //    new() { Id = 3, Name = "Bentley" },
        //    new() { Id = 4, Name = "Cinnamon" },
        //    new() { Id = 5, Name = "Chance" },
        //    new() { Id = 6, Name = "Buzz" },
        //    new() { Id = 7, Name = "Chief" },
        //    new() { Id = 8, Name = "Duchess" },
        //    new() { Id = 9, Name = "Goose" },
        //    new() { Id = 10, Name = "Maximus" },
        //};
        public IEnumerable<Dog> GetDogs()
        {
            return _context.Dog.Include(d => d.Owner).ToList();
            
        }
        public Dog GetDogById(int id)
        {
            return _context.Dog.FirstOrDefault(dog => dog.Id == id);
        }

        public void AddDog(Dog d)
        {
            //var id = _repository.Last().Id;
            //var dog = new Dog() { Id = (id + 1), Name = d.Name };
            //_repository.Add(dog);

        }

        public bool DeleteDog(int id)
        {
            //var dog = _repository.FirstOrDefault(dog => dog.Id == id);
            //if (dog != null)
            //{
            //    _repository.Remove(dog);
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
            return true;
        }

        public bool UpdateDog(int id, Dog d)
        {
            //var dog = _repository.FirstOrDefault(dog => dog.Id == id);
            //if (dog != null)
            //{
            //    dog.Name = d.Name;
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
            return true;
        }
    }
}
