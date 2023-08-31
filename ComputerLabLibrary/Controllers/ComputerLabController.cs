using ComputerLabLibrary;
using ComputerLabLibrary.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ComputerLab.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComputerLabController : ControllerBase
    {
        private readonly ComputerRepository _comprepo;
        static List<ComputerLabModel> computers = new List<ComputerLabModel>();
        [HttpGet]
        public IEnumerable<ComputerLabModel> Get() {

            return _comprepo.GetAll().ToList();
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id) {
            var res = _comprepo.GetComputerLabById(id);
            return Ok(res);
        }

        [HttpPost]
        public IActionResult Add([FromBody] ComputerLabModel data)
        {
            var res = _comprepo.AddComputer(data);
            return Ok(res);
        }

        [HttpPut("{id}")]
        public IActionResult Put([FromBody] ComputerLabModel data)
        {
            var res = _comprepo.UpdateComputer(data);
            return Ok(res);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var res = computers.RemoveAll(s => s.Id == id);
            return Ok(res);
        }
    }
}
