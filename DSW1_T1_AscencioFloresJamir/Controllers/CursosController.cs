using Microsoft.AspNetCore.Mvc;
using DSW1_T1_AscencioFloresJamir.Models;
using DSW1_T1_AscencioFloresJamir.Data;

namespace DSW1_T1_AscencioFloresJamir.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CursosController : ControllerBase
    {
        private readonly CursosRepository _repository;

        public CursosController(CursosRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<List<Curso>> GetCursos()
        {
            return Ok(_repository.ObtenerTodas());
        }

        [HttpGet("por-nivel/{nivelId}")]
        public ActionResult<List<Curso>> GetPorNivel(int nivelId, [FromQuery] int pagina = 1, [FromQuery] int registros = 10)
        {
            var lista = _repository.FiltrarPorNivel(nivelId, pagina, registros);

            if (lista == null || lista.Count == 0)
            {
                return NotFound(new { message = $"No hay cursos en el nivel {nivelId} para la página {pagina}" });
            }
            return Ok(lista);
        }

        [HttpGet("{id}")]
        public ActionResult<Curso> GetCurso(int id)
        {
            var curso = _repository.ObtenerPorId(id);
            // Validación ternaria estilo profe
            return curso == null ? NotFound(new { message = $"Curso {id} no encontrado" }) : Ok(curso);
        }

        [HttpPost]
        public ActionResult<Curso> PostCurso([FromBody] Curso curso)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var creado = _repository.Crear(curso);
            return CreatedAtAction(nameof(GetCurso), new { id = creado.CursoId }, creado);
        }

        [HttpPut("{id}")]
        public ActionResult Actualizar(int id, [FromBody] Curso curso)
        {
            if (id != curso.CursoId)
                return BadRequest(new { message = "El ID no coincide" });

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var actualizado = _repository.Actualizar(id, curso);

            if (!actualizado)
                return NotFound(new { message = $"Curso con ID {id} no encontrado" });

            return NoContent();
        }
    }
}