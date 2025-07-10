using SistemaAcademico.Models;
using SistemaAcademico.Repositorio;
using System.Text.Json;

namespace SistemaAcademico.Services
{
    public class ServicesCareer
    {
        private readonly IRepositorio<Carrera> _repo;
        public ServicesCareer(IRepositorio<Carrera> repo)
        {
            _repo = repo;
        }
		public List<Carrera> ObtenerTodos()
		{
			return _repo.ObtenerTodos();
		}
        public void Agregar(Carrera carrera)
        {
            _repo.Agregar(carrera);
        }
        public Carrera? BuscarPorId(int id)
		{
			return _repo.BuscarPorId(id);
		}
        public void Editar(Carrera carrera)
        {
			_repo.Editar(carrera);
        }
        public void EliminarPorId(int id)
        {
            _repo.EliminarPorId(id);
        }
	}
    
}


       