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
    public class DeleteModel : PageModel
    {
		private readonly ServicioAlumno servicio;
		public DeleteModel()
		{
			IAccesoDatos<Alumno> acceso = new AccesoDatosJson<Alumno>("Alumno");
			IRepositorio<Alumno> repo = new RepositorioCrudJson<Alumno>(acceso);
			servicio = new ServicioAlumno(repo);
		}
		[BindProperty]
        public Alumno Alumno { get; set; }

        public void OnGet(int id)
        {
            var alumno = servicio.BuscarPorId(id);
			if (alumno == null)
            {
				RedirectToPage("Index");
            }
			Alumno = alumno;
            
        }
        public IActionResult OnPost() 
        {
            servicio.EliminarPorId(Alumno.Id);
            
            return RedirectToPage("Index");
        }
    }
}
