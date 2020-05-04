using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using AppEscuelaEF.Model;
using System.Linq;

namespace AppEscuelaEF.ModelConfiguration
{
    class EstudianteConfiguration : EntityTypeConfiguration<Estudiante>
    {
        public EstudianteConfiguration()
        {
            //Relación Uno a Uno ==> Estudiante -> EstudianteDireccion
            HasOptional<EstudianteDireccion>(estudiante => estudiante.EstudianteDireccion)
            .WithRequired(estudianteDireccion => estudianteDireccion.Estudiante);

            //Relacion Uno a Muchos ==> Grado -> Estudiante
            HasRequired<Grado>(estudiante => estudiante.Grado)
            .WithMany(grado => grado.Estudiantes)
            .HasForeignKey(estudiante => estudiante.GradoId);

            //Relacion Muchos a Muchos ==> Estudiantes - Cursos
            //HasMany<Curso>(estudiante => estudiante.Cursos)
            //.WithMany(curso => curso.Estudiantes)
            //.Map(estudiantesCursos =>
            //{
            //    estudiantesCursos.MapLeftKey("EstudianteId");
            //    estudiantesCursos.MapRightKey("CursoId");
            //    estudiantesCursos.ToTable("EstudiantesCursos");
            //});

            ToTable("Estudiantes");

            Property(estudiante => estudiante.Nombres)
            .HasMaxLength(50)

            .IsRequired();

            Property(estudiante => estudiante.Apellidos)
            .HasMaxLength(50)
            .IsRequired();
        }
    }
}
