using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEscuelaEF.Model
{
    public class EstudianteDireccion
    {
        [ForeignKey("Estudiante")]
        public int EstudianteDireccionId { get; set; }
        public string Direccion1 { get; set; }
        public string Direccion2 { get; set; }
        public string Provincia { get; set; }
        public string Departamento { get; set; }
        public Estudiante Estudiante { get; set; }
    }
}
