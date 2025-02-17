using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASPCoreWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FruitsAPIController : ControllerBase
    {
        public List<String> fruits = new List<String>
        {
            "Apple", "Banana", "Cherry","Grapes","Mango","Orange","Pineapple","Strawberry","Watermelon"
            
        };

        [HttpGet]
        public List<String> GetFruits()
        {
            return fruits;
        }
        [HttpGet("{id}")]
        public String GetFruits(int id)
        {
            return fruits.ElementAt(id);
        }
    }
}
