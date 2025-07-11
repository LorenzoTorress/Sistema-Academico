using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaAcademico.AccesoADatos;
using SistemaAcademico.AccesoDatos;
using SistemaAcademico.Data;
using SistemaAcademico.Models;
using SistemaAcademico.Repositorio;
using SistemaAcademico.Services;

namespace SistemaAcademico.Pages.Carreras
{
    public class IndexModel : PageModel
    {
		private readonly ServicesCareer servicio;
		public IndexModel()
		{
			IAccesoDatos<Carrera> acceso = new AccesoDatosJson<Carrera>("Carrera");
			IRepositorio<Carrera> repo = new RepositorioCrudJson<Carrera>(acceso);
			servicio = new ServicesCareer(repo);
		}
		public List<Carrera> Carreras { get; set; }
        public void OnGet()
        {
            Carreras = servicio.ObtenerTodos();
        }
    }
}
