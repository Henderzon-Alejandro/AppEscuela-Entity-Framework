using AppEscuelaEF.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEscuelaEF.ModelConfiguration
{
    public class GradoConfiguration : EntityTypeConfiguration<Grado>
    {
        public GradoConfiguration()
        {
            //Relacion Uno a Muchos ==> Grado -> Estudiante
            HasMany<Estudiante>(grado => grado.Estudiantes)
            .WithRequired(estudiante => estudiante.Grado)
            .HasForeignKey(estudiante => estudiante.GradoId);

            ToTable("Grados");

            Property(grado => grado.GradoNombre)
            .HasMaxLength(50)
            .IsRequired();

            Property(grado => grado.Seccion)
            .HasMaxLength(50)
            .IsRequired();
        }
    }
}
