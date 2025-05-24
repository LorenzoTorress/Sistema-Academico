using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaAcademico.Data;
using SistemaAcademico.Models;

namespace SistemaAcademico.Pages.Alumnos
{
    public class CreateModel : PageModel
    {
        public void OnGet()
        {
        }
        [BindProperty]
        public Alumno Alumno { get; set; }
        private static int ultimoId = 0;
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }         
             ultimoId++;
             Alumno.Id = ultimoId;
             DatosCompartidos.Alumnos.Add(Alumno);
             return RedirectToPage("/Alumnos/Index");
        }
    }
}