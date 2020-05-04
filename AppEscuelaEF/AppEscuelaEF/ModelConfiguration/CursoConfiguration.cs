using AppEscuelaEF.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEscuelaEF.ModelConfiguration
{
    public class CursoConfiguration : EntityTypeConfiguration<Curso>
    {
        public CursoConfiguration()
        {
            //Relación Muchos a Muchos ==> Estudiantes - Cursos
            //HasMany<Estudiante>(curso => curso.Estudiantes)
            //.WithMany(estudiante => estudiante.Cursos)
            //.Map(estudiantesCursos =>
            //{
            //    estudiantesCursos.MapLeftKey("EstudianteId");
            //    estudiantesCursos.MapRightKey("CursoId");
            //    estudiantesCursos.ToTable("EstudiantesCursos");
            //});

            ToTable("Cursos");

            Property(curso => curso.Nombre)
            .HasMaxLength(50)
            .IsRequired();

            Property(curso => curso.Descripcion)
            .HasMaxLength(50)
            .IsRequired();
        }
    }
}
