using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaAcademico.AccesoADatos;
using SistemaAcademico.AccesoDatos;
using SistemaAcademico.Data;
using SistemaAcademico.Helpers;
using SistemaAcademico.Models;
using SistemaAcademico.Repositorio;
using SistemaAcademico.Services;
using System.Transactions;



namespace SistemaAcademico.Pages.Carreras
{
    public class CreateModel : PageModel
    {
        private readonly ServicesCareer servicio;
		public List<string> Modalidad { get; set; } = new();
		public List<Carrera> carreras { get; set; } //Agregado para preguntar
		public CreateModel()
        {
            IAccesoDatos<Carrera> acceso= new AccesoDatosJson<Carrera>("Carrera");
            IRepositorio<Carrera> repo = new RepositorioCrudJson<Carrera>(acceso);
            servicio = new ServicesCareer(repo);
        }
        
        public void OnGet()
        {
            Modalidad = OpcionesModalidad.Lista;
            
        }

        [BindProperty]
        public Carrera Carrera { get; set; }
        public IActionResult OnPost()
        {
            Modalidad = OpcionesModalidad.Lista;
            if (!ModelState.IsValid)
            {
                return Page();
            }

            servicio.Agregar(Carrera);
            return RedirectToPage("/Carreras/Index");
        }
    }
}
