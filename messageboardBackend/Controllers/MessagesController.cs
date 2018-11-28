using System.Collections.Generic;
using messageboardBackend.Models;
using Microsoft.AspNetCore.Mvc;

namespace messageboardBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {

        public IEnumerable<Message> Get()
        {
            return new Message[]{
                new Message { Owner = "John" , Text ="Hello"} ,
                new Message { Owner = "Tim" , Text ="Hi"}
            };
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Message message)
        {
        }

    }
}