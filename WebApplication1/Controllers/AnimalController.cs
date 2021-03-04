using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalController : ControllerBase
    {
        public static List<Animal> Animals = new List<Animal>()
        {

            new Animal()
            {
                Id=1,
                Name="Bob",
                Type="Cat",
                Age=2
            },

             new Animal()
            {
                Id=2,
                Name="Frank",
                Type="Dog",
                Age=1
            },
             new Animal()
            {
                Id=3,
                Name="Andrii",
                Type="Dangeon Master",
                Age=17
            }


        };



        [HttpGet]
        public List<Animal> GetAllAnimals()
        {
            return Animals;
        }

        [HttpPost]
        [Route("Add")]
        public void AddAnimal([FromBody] Animal animal)
        {
            Animals.Add(animal);
        }

        [HttpPost]
        [Route("Delete/{id}")]
        public void DeleteAnimal([FromBody] int id)
        {
            Animals.Remove(Animals.Find(x => x.Id == id));
        }

        [HttpPost]
        [Route("Update")]
        public void Update()
        {
           
        }

    }
}
