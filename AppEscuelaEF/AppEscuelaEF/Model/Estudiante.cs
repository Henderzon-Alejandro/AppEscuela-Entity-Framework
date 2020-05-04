using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEscuelaEF.Model
{
    public class Estudiante
    {
        public int EstudianteId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int GradoId { get; set; }
        public Grado Grado { get; set; }
        public EstudianteDireccion EstudianteDireccion { get; set; }
        public ICollection<Curso> Cursos { get; set; }
    }
}
