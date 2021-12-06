using Animal_Shelter_Api.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Animal_Shelter_Api.Repositories
{
    public interface IDogRepository
    {
        IEnumerable<Dog> GetDogs();
        Dog GetDogById(int id);
        void AddDog(string name);
        Dog UpdateDog(int id, string name);
        bool DeleteDog(int id);
    }
}
