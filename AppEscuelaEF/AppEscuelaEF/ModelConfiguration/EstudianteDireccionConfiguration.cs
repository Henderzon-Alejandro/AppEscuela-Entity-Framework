using AppEscuelaEF.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;

namespace AppEscuelaEF.ModelConfiguration
{
    class EstudianteDireccionConfiguration : EntityTypeConfiguration<EstudianteDireccion>
    {
        public EstudianteDireccionConfiguration()
        {
            //Relacion Uno a Uno ==> Estudiante -> EstudianteDireccion
            HasRequired<Estudiante>(estudianteDireccion => estudianteDireccion.Estudiante)
            .WithOptional(estudiante => estudiante.EstudianteDireccion);

            ToTable("EstudiantesDirecciones");

            Property(estudianteDireccion => estudianteDireccion.Direccion1)
            .HasMaxLength(50)
            .IsRequired();

            Property(estudianteDireccion => estudianteDireccion.Provincia)
            .HasMaxLength(50)
            .IsRequired();

            Property(estudianteDireccion => estudianteDireccion.Departamento)
            .HasMaxLength(50)
            .IsRequired();
        }
    }
}