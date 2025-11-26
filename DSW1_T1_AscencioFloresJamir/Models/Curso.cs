using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DSW1_T1_AscencioFloresJamir.Models
{
    public class Curso
    {
        [Key]
        public int CursoId { get; set; }
        public string CodigoCurso { get; set; }
        public string NombreCurso { get; set; }
        public int Creditos { get; set; }
        public int HorasSemanales { get; set; }

        public int NivelAcademicoId { get; set; }

        [ForeignKey("NivelAcademicoId")]
        public NivelAcademico? NivelAcademico { get; set; }
    }
}