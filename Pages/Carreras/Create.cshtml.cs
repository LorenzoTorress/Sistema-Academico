using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaAcademico.Data;
using SistemaAcademico.Models;



namespace SistemaAcademico.Pages.Carreras
{
    public class CreateModel : PageModel
    {
        public void OnGet()
        {
        }

        [BindProperty]
        public Carrera Carrera { get; set; }
        //public static List<Carrera> listacarrera = new();
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            Carrera.Id = DatosCompartidos.ObtenerID();
            DatosCompartidos.Carreras.Add(Carrera);
            return RedirectToPage("/Carreras/Index");
        }
    }
}
