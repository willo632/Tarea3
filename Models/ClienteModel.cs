using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tarea3.Models
{
    [Table("Cliente")]
    public class ClienteModel
    {
        public int id { get; set; }

        [Display(Name = "Nombres del Cliente")]
        [Required(ErrorMessage = "El campo nombres es requerido")]
        [MaxLength(100, ErrorMessage = "El máximo número de caracteres es 100")]
        public string Nombres_Cliente { get; set; }

        [Display(Name = "Cédula")]
        [Required(ErrorMessage = "El campo cédula es requerido")]
        [MaxLength(10, ErrorMessage = "La cédula debe tener máximo 10 caracteres")]
        [MinLength(10, ErrorMessage = "La cédula debe tener 10 caracteres")]
        public string Cedula { get; set; }

        [Display(Name = "Apellidos")]
        [Required(ErrorMessage = "El campo apellidos es requerido")]
        [MaxLength(100, ErrorMessage = "El máximo número de caracteres es 100")]
        public string Apellidos { get; set; }

        [Display(Name = "Dirección")]
        [Required(ErrorMessage = "El campo dirección es requerido")]
        [MaxLength(200, ErrorMessage = "El máximo número de caracteres es 200")]
        public string Direccion { get; set; }

        [Display(Name = "Teléfono")]
        [Required(ErrorMessage = "El campo teléfono es requerido")]
        [MaxLength(17, ErrorMessage = "El máximo número de caracteres es 17")]
        [MinLength(9, ErrorMessage = "El mínimo de caracteres es 9")]
        [Phone(ErrorMessage = "El teléfono no es válido")]
        public string Telefono { get; set; }

        [Display(Name = "Correo electrónico")]
        [Required(ErrorMessage = "El campo correo es requerido")]
        [EmailAddress(ErrorMessage = "El correo electrónico no es válido")]
        [MaxLength(100, ErrorMessage = "El máximo número de caracteres es 100")]
        public string Correo { get; set; }

        [Display(Name = "Celular")]
        [Required(ErrorMessage = "El campo celular es requerido")]
        [MaxLength(10, ErrorMessage = "El celular debe tener máximo 10 caracteres")]
        [MinLength(10, ErrorMessage = "El celular debe tener 10 caracteres")]
        [Phone(ErrorMessage = "El celular no es válido")]
        public string Celular { get; set; }

        [Display(Name = "Fecha de nacimiento")]
        [Required(ErrorMessage = "El campo fecha de nacimiento es requerido")]
        [DataType(DataType.Date)]
        public DateTime fecha_nacimiento { get; set; }

        [Display(Name = "Estado civil")]
        [Required(ErrorMessage = "El campo estado civil es requerido")]
        [MaxLength(50, ErrorMessage = "El máximo número de caracteres es 50")]
        public string estado_civil { get; set; }

        [Display(Name = "Estado")]
        [Required(ErrorMessage = "El campo estado es requerido")]
        [MaxLength(20, ErrorMessage = "El máximo número de caracteres es 20")]
        public string estado { get; set; }
    }
}
