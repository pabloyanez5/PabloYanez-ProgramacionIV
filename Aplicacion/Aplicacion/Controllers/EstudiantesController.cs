using Aplicacion.Modelos;
using Aplicacion.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Aplicacion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudiantesController : ControllerBase
    {
        [HttpGet]
        public List<Estudiante> GetListadoEstudiantes()
        {
            EstudianteRepository repo = new EstudianteRepository();
            var listado = repo.DevuelveListadoEstudiante();
            return listado;
        }

        [HttpGet]
        [Route("InformacionEstudiante/{id}")]
        public ActionResult DevuelveInformacionEstudiante(int id)
        {
            try
            {
                EstudianteRepository repo = new EstudianteRepository();
                var Listado = repo.DevuelveListadoEstudiante();
                var estudiante = Listado.Find(x => x.Id == id);
                return Ok(estudiante);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPost]
        public ActionResult GuardaEstudiante([FromBody] Estudiante estudiante)
        {
            return Ok();
        }
    }
}
