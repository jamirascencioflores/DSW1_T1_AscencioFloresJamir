using DSW1_T1_AscencioFloresJamir.Models;
using Microsoft.EntityFrameworkCore;

namespace DSW1_T1_AscencioFloresJamir.Data
{
    public class CursosRepository
    {
        private readonly AppDbContext _context;

        public CursosRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<Curso> ObtenerTodas()
        {
            return _context.Cursos.Include(c => c.NivelAcademico).ToList();
        }

        public Curso? ObtenerPorId(int id)
        {
            return _context.Cursos.Include(c => c.NivelAcademico)
                                  .FirstOrDefault(c => c.CursoId == id);
        }

        public Curso Crear(Curso curso)
        {
            _context.Cursos.Add(curso);
            _context.SaveChanges();
            return curso;
        }

        public bool Actualizar(int id, Curso cursoActualizado)
        {
            var curso = _context.Cursos.Find(id);
            if (curso == null) return false; 

            curso.CodigoCurso = cursoActualizado.CodigoCurso;
            curso.NombreCurso = cursoActualizado.NombreCurso;
            curso.Creditos = cursoActualizado.Creditos;
            curso.HorasSemanales = cursoActualizado.HorasSemanales;
            curso.NivelAcademicoId = cursoActualizado.NivelAcademicoId;

            _context.SaveChanges();
            return true;
        }

        public List<Curso> FiltrarPorNivel(int nivelId, int pagina = 1, int registros = 10)
        {
            return _context.Cursos
                           .Where(c => c.NivelAcademicoId == nivelId)
                           .Include(c => c.NivelAcademico)
                           .Skip((pagina - 1) * registros) 
                           .Take(registros)                
                           .ToList();
        }
    }
}