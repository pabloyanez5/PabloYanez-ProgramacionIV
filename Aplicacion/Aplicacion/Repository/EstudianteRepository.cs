using Aplicacion.Modelos;

namespace Aplicacion.Repository
{
    public class EstudianteRepository
    {
        public List<Estudiante> DevuelveListadoEstudiante()
        {
            List<Estudiante> listado= new List<Estudiante>();
            Estudiante estudiante1 = new Estudiante
            {
                Id = 1,
                Nombre= "Santiago",
                Edad=20,
                TieneBeca=true
            };

            Estudiante estudiante2 = new Estudiante
            {
                Id = 2,
                Nombre = "Paulo",
                Edad = 19,
                TieneBeca = false
            };

            listado.Add(estudiante1);
            listado.Add(estudiante2);
            return listado;
        }
    }
}
