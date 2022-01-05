using Microsoft.AspNetCore.Mvc;

namespace LoginTemplate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnAuthorized : ControllerBase
    {
        public UnAuthorized()
        {
            
        }

        [HttpGet("FAkeAPI")]
        public  IActionResult GetApiResponse()
        {
            fetch('https://jsonplaceholder.typicode.com/posts/1')
     .then((response) => response.json())
    .then((json) => console.log(json));
        }


    }
}
