using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace DSW1_T1_AscencioFloresJamir.Models
{
    public class NivelAcademico
    {
        [Key]
        public int NivelAcademicoId { get; set; }
        public string Descripcion { get; set; }
        public int Orden { get; set; }

        [JsonIgnore] 
        public ICollection<Curso> Cursos { get; set; }
    }
}