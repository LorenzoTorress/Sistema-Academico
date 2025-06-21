using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaAcademico.Data;
using SistemaAcademico.Helpers;
using SistemaAcademico.Models;
using SistemaAcademico.Services;



namespace SistemaAcademico.Pages.Carreras
{
    public class CreateModel : PageModel
    {
        public List<string> Modalidad { get; set; } = new();
        public List<Carrera> carreras { get; set; } //Agregado para preguntar
        public void OnGet()
        {
            Modalidad = OpcionesModalidad.Lista;
            carreras = ServicesCareer.ObtenerCarreras(); //Agregado para preguntar 
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

            Carrera.Id = ServicesCareer.ObtenerNuevoId(carreras); //Agregado para preguntar
            ServicesCareer.AgregarCarrera(Carrera);
            return RedirectToPage("/Carreras/Index");
        }
    }
}
