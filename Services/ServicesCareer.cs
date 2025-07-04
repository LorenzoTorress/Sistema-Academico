using SistemaAcademico.Models;
using System.Text.Json;

namespace SistemaAcademico.Services
{
    public class ServicesCareer
    {
        private readonly RepositorioCrudJson<Carrera> crud;
        public ServicesCareer()
        {
            crud = new RepositorioCrudJson<Carrera>("carreras");
        }
		public List<Carrera> ObtenerTodos()
		{
			return crud.ObtenerTodos();
		}
        public void Agregar(Carrera carrera)
        {
            crud.Agregar(carrera);
        }
        public Carrera? BuscarPorId(int id)
		{
			return crud.BuscarPorId(id);
		}
        public void Editar(Carrera carrera)
        {
			crud.Editar(carrera);
        }
        public void EliminarPorId(int id)
        {
            crud.EliminarPorId(id);
        }
	}
    
}


       