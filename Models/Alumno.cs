using System.ComponentModel.DataAnnotations;

namespace SistemaAcademico.Models
{
	public class Alumno
	{
		public int Id { get; set; }

        [Required(ErrorMessage = "El nombre no puede estar vacio")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "El apellido no puede estar vacio")]
        public string? Apellido {  get; set; }
        [Required(ErrorMessage = "El Dni no puede estar vacio")]
        public string? Dni { get; set; }
        [Required(ErrorMessage = "El email no puede estar vacio")]
        public string? Email {  get; set; }
        [Required(ErrorMessage = "La fecha de nacimiento no puede estar vacia")]
        public int FechaDeNacimiento {  get; set; }
	}
}
