using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaAcademico.Data;
using SistemaAcademico.Models;

namespace SistemaAcademico.Pages.Alumnos
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public Alumno Alumno { get; set; }

        public void OnGet(int id)
        {
            foreach (var a in DatosCompartidos.Alumnos) 
            {
                if (a.Id == id)
                {
                    Alumno = a;
                }

            }

        }
        public IActionResult OnPost() 
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            foreach (var a in DatosCompartidos.Alumnos)
            {
                a.Nombre = Alumno.Nombre;
                a.Apellido = Alumno.Apellido;
                a.Dni = Alumno.Dni;
                a.Email = Alumno.Email;
                a.FechaDeNacimiento = Alumno.FechaDeNacimiento;
                break;
            }
            return RedirectToPage("Index");

        }
    }
}
