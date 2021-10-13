using EsculaDeConexion.Models;
using EsculaDeConexion.Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EsculaDeConexion.Repository
{
    public class CoursesRepository : ICourses
    {
        EscuelaDeConexionesEntities bd = new EscuelaDeConexionesEntities();

        public void Create(Courses c)
        {
            bd.Courses.Add(c);
            bd.SaveChanges();
        }

        public void Delete(Courses c)
        {
            bd.Courses.Remove(c);
            bd.SaveChanges();
        }

        public List<Courses> ListDataCourses()
        {
            var ListOfDataOfCourse = bd.Courses.ToList();

            return ListOfDataOfCourse;
        }

        public void Update(Courses c)
        {
            throw new NotImplementedException();
        }
    }
}