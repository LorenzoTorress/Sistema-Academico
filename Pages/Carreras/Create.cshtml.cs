using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaAcademico.Data;
using SistemaAcademico.Helpers;
using SistemaAcademico.Models;
using SistemaAcademico.Services;
using System.Transactions;



namespace SistemaAcademico.Pages.Carreras
{
    public class CreateModel : PageModel
    {
        private readonly ServicesCareer servicio;
        public CreateModel()
        {
            servicio = new ServicesCareer();
        }
        public List<string> Modalidad { get; set; } = new();
        public List<Carrera> carreras { get; set; } //Agregado para preguntar
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
