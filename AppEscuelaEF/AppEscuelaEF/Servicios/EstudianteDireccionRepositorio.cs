using System;
using AppEscuelaEF.Model;
using AppEscuelaEF.Context;
using System.Collections.Generic;
using System.Linq;

namespace AppEscuelaEF.Servicios
{
    class EstudianteDireccionRepositorio
    {
        public List<EstudianteDireccion> GetAll()
        {
            using (EscuelaDbContext context = new EscuelaDbContext())
            {
                return context.EstudiantesDirecciones.ToList();
            }
        }

        public void CreateEstudianteDireccion(EstudianteDireccion estudianteDireccion)
        {
            using (EscuelaDbContext context = new EscuelaDbContext())
            {
                context.EstudiantesDirecciones.Add(estudianteDireccion);
                context.SaveChanges();
            }
        }

        public EstudianteDireccion GetEstudianteDireccion(int key)
        {
            using (EscuelaDbContext context = new EscuelaDbContext())
            {
                return context.EstudiantesDirecciones.Find(key);
            }
        }

        public void UpdateEstudianteDireccion(int key, string direccionUpdate)
        {
            using (EscuelaDbContext context = new EscuelaDbContext())
            {
                EstudianteDireccion estudianteDireccion = context.EstudiantesDirecciones.Find(key);
                estudianteDireccion.Direccion1 = direccionUpdate;
                context.SaveChanges();
            }
        }

        public void DeleteEstudianteDireccion(int key)
        {
            using (EscuelaDbContext context = new EscuelaDbContext())
            {
                EstudianteDireccion estudianteDireccion = context.EstudiantesDirecciones.Find(key);
                context.EstudiantesDirecciones.Remove(estudianteDireccion);
                context.SaveChanges();
            }
        }
    }
}
