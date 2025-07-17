using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaAcademico.Data;
using SistemaAcademico.Models;
using SistemaAcademico.Services;

namespace SistemaAcademico.Pages.Alumnos
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public Alumno Alumno { get; set; }

        public void OnGet(int id)
        {
            Alumno? alumno = ServicesStudent.BuscarPorId(id);
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
            ServicesStudent.EditarAlumno(Alumno);
            
            return RedirectToPage("Index");

        }
    }
}
