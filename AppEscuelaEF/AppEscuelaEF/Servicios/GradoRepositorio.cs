using AppEscuelaEF.Context;
using AppEscuelaEF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEscuelaEF.Servicios
{
    public class GradoRepositorio
    {
        public List<Grado> GetAll()
        {
            using (EscuelaDbContext context = new EscuelaDbContext())
            {
                return context.Grados.ToList();
            }
        }

        public void CreateGrado(Grado grado)
        {
            using (EscuelaDbContext context = new EscuelaDbContext())
            {
                context.Grados.Add(grado);
                context.SaveChanges();
            }
        }

        public Grado GetGrado(int key)
        {
            using (EscuelaDbContext context = new EscuelaDbContext())
            {
                return context.Grados.Find(key);
            }
        }

        public void UpdateGrado(int key, string nombreUpdate)
        {
            using (EscuelaDbContext context = new EscuelaDbContext())
            {
                Grado grado = context.Grados.Find(key);
                grado.GradoNombre = nombreUpdate;
                context.SaveChanges();
            }
        }

        public void DeleteGrado(int key)
        {
            using (EscuelaDbContext context = new EscuelaDbContext())
            {
                Grado grado = context.Grados.Find(key);
                context.Grados.Remove(grado);
                context.SaveChanges();
            }
        }
    }
}
