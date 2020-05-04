using System;
using AppEscuelaEF.Context;
using AppEscuelaEF.Model;
using AppEscuelaEF.Servicios;
using System.Collections.Generic;

namespace AppEscuelaEF
{
    class Inicio
    {
        static void Main(string[] args)
        {
            EstudianteCursoRepositorio repo1 = new EstudianteCursoRepositorio();
            EstudianteRepositorio repoEstudiante = new EstudianteRepositorio();
            CursoRepositorio repoCurso = new CursoRepositorio();

            List<EstudianteCurso> lista = repo1.GetAlumnoCursos(1);

            EstudianteCurso es = lista.Find(e => e.EstudianteId == 1);
            Console.WriteLine("El estudiante {0}, lleva los siguientes cursos:", repoEstudiante.GetEstudiante(es.EstudianteId).Nombres);
            foreach (var item in lista)
            {
                Console.WriteLine("{0}", repoCurso.GetCurso(item.CursoId).Nombre);
            }

            Console.ReadLine();
        }
    }
}
