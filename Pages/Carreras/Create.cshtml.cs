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
        public void OnGet()
        {
            Modalidad = OpcionesModalidad.Lista;
        }

        [BindProperty]
        public Carrera Carrera { get; set; }
        //public static List<Carrera> listacarrera = new();
        public IActionResult OnPost()
        {
            Modalidad = OpcionesModalidad.Lista;
            if (!ModelState.IsValid)
            {
                return Page();
            }

            ServicesCareer.AgregarCarrera(Carrera);
            return RedirectToPage("/Carreras/Index");
        }
    }
}
