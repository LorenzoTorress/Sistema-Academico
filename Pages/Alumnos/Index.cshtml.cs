using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaAcademico.AccesoADatos;
using SistemaAcademico.AccesoDatos;
using SistemaAcademico.Data;
using SistemaAcademico.Models;
using SistemaAcademico.Repositorio;
using SistemaAcademico.Services;

namespace SistemaAcademico.Pages.Alumnos
{
    public class IndexModel : PageModel
    {
		private readonly ServicioAlumno servicio;
		public IndexModel()
		{
			IAccesoDatos<Alumno> acceso = new AccesoDatosJson<Alumno>("Alumno");
			IRepositorio<Alumno> repo = new RepositorioCrudJson<Alumno>(acceso);
			servicio = new ServicioAlumno(repo);
		}
		public List<Alumno> Alumnos { get; set; }
        public void OnGet()
        {
            Alumnos = servicio.ObtenerTodos();
        }
    }
}
