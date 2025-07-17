using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaAcademico.Data;
using SistemaAcademico.Models;
using SistemaAcademico.Services;


namespace SistemaAcademico.Pages.Alumnos
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Alumno Alumno { get; set; }
        public void OnGet()
        {
            
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }         
             ServicesStudent.AgregarAlumno(Alumno);
             return RedirectToPage("/Alumnos/Index");
        }
    }
}