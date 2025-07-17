using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaAcademico.Data;
using SistemaAcademico.Models;
using SistemaAcademico.Services;

namespace SistemaAcademico.Pages.Alumnos
{
    public class DeleteModel : PageModel
    {
        [BindProperty]
        public Alumno Alumno { get; set; }

        public IActionResult OnGet(int id)
        {
            var alumno = ServicesStudent.BuscarPorId(id);
            if (alumno == null)
			{
				return RedirectToPage("Index");
			}
			Alumno = alumno;
			return Page();
        }
        public IActionResult OnPost(int id) 
        {
            ServicesStudent.EliminarPorId(id);
            return RedirectToPage("Index");
        }
    }
}
