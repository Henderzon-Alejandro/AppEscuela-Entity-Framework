using AppEscuelaEF.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEscuelaEF.ModelConfiguration
{
    class EstudianteCursoConfiguration : EntityTypeConfiguration<EstudianteCurso>
    {
        public EstudianteCursoConfiguration()
        {
            HasKey(estudianteCurso => new { estudianteCurso.EstudianteId, estudianteCurso.CursoId });
            ToTable("EstudiantesCursos");
        }
    }
}
