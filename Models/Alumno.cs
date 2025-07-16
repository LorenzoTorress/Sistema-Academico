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
        
		[Required(ErrorMessage = "Ingrese su DNI")]
		[Range(8, 8, ErrorMessage = "Faltan numeros en el DNI")]
		public string? Dni { get; set; }
		[Required(ErrorMessage = "")]
        public string? Email {  get; set; }
		[Display(Name = "Fecha de Nacimiento")]
		[DataType(DataType.Date)]
        [Required(ErrorMessage = "Ingrese una fecha de nacimiento")]
        public DateTime FechaDeNacimiento {  get; set; }
	}
}
