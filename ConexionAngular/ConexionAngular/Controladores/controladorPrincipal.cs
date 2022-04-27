using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ConexionAngular.Controladores
{
    [Route("api/[controller]")]
    [ApiController]
    public class controladorPrincipal : ControllerBase
    {

        private readonly Modelos.PlasticaribeBDContext _principalId;

        public controladorPrincipal(Modelos.PlasticaribeBDContext context) {

            _principalId = context;

        }


        // GET: api/<controladorPrincipal>
        [HttpGet]

        public async Task<IActionResult> Get()
        {
            try
            {
                var listaAreas = await _principalId.Areas.ToListAsync();
                return Ok(listaAreas);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                
            }
             


        }
       

        // GET api/<controladorPrincipal>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controladorPrincipal>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<controladorPrincipal>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controladorPrincipal>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
