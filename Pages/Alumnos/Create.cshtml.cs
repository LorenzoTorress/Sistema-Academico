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
	public class CreateModel : PageModel
    {
        private readonly ServicioAlumno servicio;
        public CreateModel()
        {
			IAccesoDatos<Alumno> acceso = new AccesoDatosJson<Alumno>("Alumno");
			IRepositorio<Alumno> repo = new RepositorioCrudJson<Alumno>(acceso);
			servicio = new ServicioAlumno(repo);
		}
			public void OnGet()
        {
        }
        [BindProperty]
        public Alumno Alumno { get; set; }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }         
             servicio.Agregar(Alumno);
             return RedirectToPage("/Alumnos/Index");
        }
    }
}