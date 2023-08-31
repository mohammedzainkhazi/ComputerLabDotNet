using Microsoft.AspNetCore.Mvc;
using ComputerLabLibrary;

namespace ComputerLab.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComputerLabController : Controller
    {
        static List<ComputerLabModel> computers = new List<ComputerLabModel>();
        [HttpGet]
        public IEnumerable<ComputerLabModel> Get() {

            return computers;
        }

        [HttpGet("{id}")]
        public ComputerLabModel Get(int id) {
            return computers.FirstOrDefault(c => c.Id == id);
        }

        [HttpPost]
        public string Add([FromBody] ComputerLabModel data)
        {
            computers.Add(data);
            return "Added a new Computer to LAB!";
        }

        [HttpPut("{id}")]
        public string Put(int id, [FromBody] ComputerLabModel data)
        {
            int i = computers.FindIndex(s => s.Id == id);
            if (i >= 0)
            {
                computers[i] = data;
            }
            return "Updated Computer :" + id;
        }
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            computers.RemoveAll(s => s.Id == id);
            return "Deleted Computer :" + id;
        }
    }
}
