using System;
using AppEscuelaEF.Model;
using AppEscuelaEF.Context;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEscuelaEF.Servicios
{
    class EstudianteCursoRepositorio
    {
        public void CreateEstudianteCurso(int estudianteId, int cursoId)
        {
            using (EscuelaDbContext context = new EscuelaDbContext())
            {
                Estudiante estudiante = context.Estudiantes.Find(estudianteId);
                Curso curso = context.Cursos.Find(cursoId);
                EstudianteCurso estudianteCurso = new EstudianteCurso();
                estudianteCurso.EstudianteId = estudiante.EstudianteId;
                estudianteCurso.CursoId = curso.CursoId;

                context.EstudiantesCursos.Add(estudianteCurso);
                context.SaveChanges();
            }
        }

        public List<EstudianteCurso> GetAlumnoCursos(int estudianteId)
        {
            using (EscuelaDbContext context = new EscuelaDbContext())
            {
                return context.EstudiantesCursos.Where(estudianteCurso => (estudianteCurso.EstudianteId == estudianteId)).ToList();
            }
        }
    }
}
