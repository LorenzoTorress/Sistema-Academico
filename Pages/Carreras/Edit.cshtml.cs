using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaAcademico.Models;
using SistemaAcademico.Data;
using System.Security.Cryptography.X509Certificates;
using SistemaAcademico.Helpers;
using SistemaAcademico.Services;
using SistemaAcademico.AccesoADatos;
using SistemaAcademico.Repositorio;
using SistemaAcademico.AccesoDatos;

namespace SistemaAcademico.Pages.Carreras
{
    public class EditModel : PageModel
    {
        private readonly ServicesCareer servicio;
        public EditModel()
        {
			IAccesoDatos<Carrera> acceso = new AccesoDatosJson<Carrera>("Carrera");
			IRepositorio<Carrera> repo = new RepositorioCrudJson<Carrera>(acceso);
			servicio = new ServicesCareer(repo);
		}
        public List<string> Modalidad { get; set; } = new();
        [BindProperty]
        public Carrera? Carrera { get; set; }
        public void OnGet(int id)
        {
            Modalidad = OpcionesModalidad.Lista;

            Carrera? carrera = servicio.BuscarPorId(id);
            if (carrera != null)
            {
                Carrera = carrera;
            }
        }
        public IActionResult OnPost()
        {
            Modalidad = OpcionesModalidad.Lista;
            
            if (!ModelState.IsValid)
            {
                return Page();
            }

            servicio.Editar(Carrera);
            
            return RedirectToPage("Index");
        }
    }
}
