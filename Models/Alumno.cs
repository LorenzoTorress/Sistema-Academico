using System.ComponentModel.DataAnnotations;

namespace SistemaAcademico.Models
{
	public class Alumno
	{
		[Required]
		public int Id { get; set; }
        [Required(ErrorMessage = "Ingrese su nombre")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "Ingrese su apellido")]
        public string? Apellido {  get; set; }
        [Required(ErrorMessage = "Ingrese un DNI")]
		public string? Dni { get; set; }
        [Required(ErrorMessage = "Ingrese un email")]
        public string? Email {  get; set; }
        [Required(ErrorMessage = "Ingrese una fecha de nacimiento")]
        public int FechaDeNacimiento {  get; set; }
	}
}
