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
    public class EditModel : PageModel
    {
		private readonly ServicioAlumno servicio;
		public EditModel()
		{
			IAccesoDatos<Alumno> acceso = new AccesoDatosJson<Alumno>("Alumno");
			IRepositorio<Alumno> repo = new RepositorioCrudJson<Alumno>(acceso);
			servicio = new ServicioAlumno(repo);
		}
		[BindProperty]
        public Alumno Alumno { get; set; }

        public void OnGet(int id)
        {
            Alumno? alumno = servicio.BuscarPorId(id);
            if (alumno != null)
            {
				Alumno = alumno;
            }
        }
        public IActionResult OnPost() 
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            
            servicio.Editar(Alumno);
            return RedirectToPage("Index");

        }
    }
}
