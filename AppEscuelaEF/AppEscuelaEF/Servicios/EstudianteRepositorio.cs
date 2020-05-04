using System;
using AppEscuelaEF.Model;
using AppEscuelaEF.Context;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEscuelaEF.Servicios
{
    class EstudianteRepositorio
    {
        public List<Estudiante> GetAll()
        {
            using (EscuelaDbContext context = new EscuelaDbContext())
            {
                return context.Estudiantes.ToList();
            }
        }

        public void CreateEstudiante(Estudiante estudiante)
        {
            using (EscuelaDbContext contexto = new EscuelaDbContext())
            {
                contexto.Estudiantes.Add(estudiante);
                contexto.SaveChanges();
            }
        }

        public Estudiante GetEstudiante(int key)
        {
            using (EscuelaDbContext context = new EscuelaDbContext())
            {
                return context.Estudiantes.Find(key);
            }
        }

        public void UpdateEstudiante(int key, int gradoId)
        {
            using (EscuelaDbContext context = new EscuelaDbContext())
            {
                Estudiante estudiante = context.Estudiantes.Find(key);
                estudiante.GradoId = gradoId;
                context.SaveChanges();
                Console.WriteLine("Datos actualizados.");
            }
        }

        public void DeleteEstudiante(int key)
        {
            using (EscuelaDbContext context = new EscuelaDbContext())
            {
                Estudiante estudiante = context.Estudiantes.Find(key);
                EstudianteDireccion ed = context.EstudiantesDirecciones.Find(estudiante.EstudianteId);
                estudiante.EstudianteDireccion = ed;
                context.Estudiantes.Remove(estudiante);
                context.SaveChanges();

                Console.WriteLine("Estudiante {0} eliminado.", estudiante.Nombres);
            }
        }
    }
}
