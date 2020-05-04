using AppEscuelaEF.Context;
using AppEscuelaEF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEscuelaEF.Servicios
{
    public class CursoRepositorio
    {
        public List<Curso> GetAll()
        {
            using (EscuelaDbContext context = new EscuelaDbContext())
            {
                return context.Cursos.ToList(); ;
            }
        }

        public void CreateCurso(Curso curso)
        {
            using (EscuelaDbContext context = new EscuelaDbContext())
            {
                context.Cursos.Add(curso);
                context.SaveChanges();
            }
        }

        public Curso GetCurso(int key)
        {
            using (EscuelaDbContext context = new EscuelaDbContext())
            {
                return context.Cursos.Find(key);
            }
        }

        public void UpdateCurso(int key, string descripcionUpdate)
        {
            using (EscuelaDbContext context = new EscuelaDbContext())
            {
                Curso curso = context.Cursos.Find(key);
                curso.Descripcion = descripcionUpdate;
                context.SaveChanges();
            }
        }

        public void DeleteCurso(int key)
        {
            using (EscuelaDbContext context = new EscuelaDbContext())
            {
                Curso curso = context.Cursos.Find(key);
                context.Cursos.Remove(curso);
                context.SaveChanges();
            }
        }
    }
}
