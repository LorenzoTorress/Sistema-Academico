using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaAcademico.AccesoADatos;
using SistemaAcademico.AccesoDatos;
using SistemaAcademico.Data;
using SistemaAcademico.Models;
using SistemaAcademico.Repositorio;
using SistemaAcademico.Services;
using System.Transactions;

namespace SistemaAcademico.Pages.Carreras
{
    
    public class DeleteModel : PageModel
    {
        private readonly ServicesCareer servicio;
        public DeleteModel()
		{
			IAccesoDatos<Carrera> acceso = new AccesoDatosJson<Carrera>("Carrera");
			IRepositorio<Carrera> repo = new RepositorioCrudJson<Carrera>(acceso);
			servicio = new ServicesCareer(repo);
		}
        [BindProperty]
        public Carrera Carrera { get; set; }
        public IActionResult OnGet(int id)
        {
            var carrera = servicio.BuscarPorId(id);
            if (carrera == null)
            {
                return RedirectToPage("Index");
            }
            Carrera = carrera;
            return Page();
        }
        public IActionResult OnPost(int id) 
        {
            servicio.EliminarPorId(id);
            return RedirectToPage("Index");
        }
    }
}
