﻿using Animal_Shelter_Api.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Animal_Shelter_Api.Repositories
{
    public interface IDogRepository
    {
        IEnumerable<Dog> GetDogs();
        Dog GetDogById(int id);
        void AddDog(Dog d);
        bool UpdateDog(int id, Dog d);
        bool DeleteDog(int id);
    }
}
