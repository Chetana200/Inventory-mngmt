using Inventory_mngmt.Models;
using Microsoft.AspNetCore.Mvc;

namespace Inventory_mngmt.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpPost]
        public async Task<newModel> GetModel(newModel exampleModel) { 
            newModel model = new newModel();
            model.Person.Name = exampleModel.Person.Name;
            model.Person.Age = exampleModel.Person.Age;
            model.Person.Contact.Email = 
            return model;
        }

        
    }
}
