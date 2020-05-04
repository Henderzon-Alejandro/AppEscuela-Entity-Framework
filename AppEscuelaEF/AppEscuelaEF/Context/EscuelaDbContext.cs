using AppEscuelaEF.Model;
using AppEscuelaEF.ModelConfiguration;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEscuelaEF.Context
{
    public class EscuelaDbContext : DbContext
    {
        public EscuelaDbContext() : base("name=AppEscuelaBD")
        {
        }

        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<EstudianteDireccion> EstudiantesDirecciones { get; set; }
        public DbSet<Grado> Grados { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<EstudianteCurso> EstudiantesCursos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new EstudianteConfiguration());
            modelBuilder.Configurations.Add(new EstudianteDireccionConfiguration());
            modelBuilder.Configurations.Add(new GradoConfiguration());
            modelBuilder.Configurations.Add(new CursoConfiguration());
            modelBuilder.Configurations.Add(new EstudianteCursoConfiguration());
            //base.OnModelCreating(modelBuilder);
        }
    }
}
