using System.ComponentModel.DataAnnotations;

namespace SistemaAcademico.Models
{
	public class Alumno
	{
		[Required]
		public int Id { get; set; }
        [Required]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "Casilla obligatoria")]
        public string? Apellido {  get; set; }
        [Required(ErrorMessage = "Casilla obligatoria")]
        public string? Dni { get; set; }
        [Required(ErrorMessage = "Casilla obligatoria")]
        [Range(8,8, ErrorMessage ="Faltan numeros en el DNI")]
        public string? Email {  get; set; }
        [Required(ErrorMessage = "Casilla obligatoria")]
        public int FechaDeNacimiento {  get; set; }
	}
}
