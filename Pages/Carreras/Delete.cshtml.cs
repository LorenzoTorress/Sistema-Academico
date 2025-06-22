using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaAcademico.Data;
using SistemaAcademico.Models;
using SistemaAcademico.Services;

namespace SistemaAcademico.Pages.Carreras
{
    
    public class DeleteModel : PageModel
    {
        [BindProperty]
        public Carrera Carrera { get; set; }
        public IActionResult OnGet(int id)
        {
            var carrera = ServicesCareer.BuscarPorId(id);
            if (carrera == null)
            {
                return RedirectToPage("Index");
            }
            Carrera = carrera;
            return Page();
        }
        public IActionResult OnPost(int id) 
        {
            ServicesCareer.EliminarPorId(id);
            return RedirectToPage("Index");
        }
    }
}
