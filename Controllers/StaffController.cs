using Gendar.Repository.Inteface;
using Gendar.ValueObj;
using Microsoft.AspNetCore.Mvc;

namespace Gendar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private IGendarRepository _repository;

        public StaffController(IGendarRepository repository)
        {
            _repository = repository;
        }

        // GET: api/<StaffController>
        [HttpGet]
        public async Task<ActionResult<List<StaffVO>>> GetAllAsync()
        {
            var repo = await _repository.GetAllAsync();
            return Ok(repo);
        }

        // GET api/<StaffController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StaffVO>> GetByIdAsync(Guid id)
        {
            var staff = await _repository.GetByIdAsync(id);
            return Ok(staff);
        }

        // POST api/<StaffController>
        [HttpPost]
        public async Task<ActionResult<StaffVO>> AddStaffAsync([FromBody] StaffVO staffObj)
        {
            if (staffObj == null) return BadRequest();
            var staff = await _repository.AddStaffAsync(staffObj);

            return Ok(staff);
        }

        // PUT api/<StaffController>
        [HttpPut("Update")]
        public async Task<ActionResult<StaffVO>> UpdateStaffAsync([FromBody] StaffVO staffObj)
        {
            if (staffObj == null) return BadRequest();
            var staff = await _repository.UpdateStaffAsync(staffObj);

            return Ok(staff);
        }

        // DELETE api/<StaffController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            var DeleteStaffStatus = await _repository.DeleteStaffAsync(id);
            if (!DeleteStaffStatus) return BadRequest();

            return Ok(DeleteStaffStatus);
        }
    }
}
