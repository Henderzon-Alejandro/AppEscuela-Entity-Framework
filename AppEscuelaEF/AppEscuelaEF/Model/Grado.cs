using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEscuelaEF.Model
{
    public class Grado
    {
        public int GradoId { get; set; }
        public string GradoNombre { get; set; }
        public string Seccion { get; set; }
        public ICollection<Estudiante> Estudiantes { get; set; }
    }
}
