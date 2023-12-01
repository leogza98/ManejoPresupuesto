using System.ComponentModel.DataAnnotations;

namespace ManejoPresupuesto.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "El Campo {0} es requerido")]
        [EmailAddress(ErrorMessage = "El Campo debe ser un correo electronico valido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "El Campo {0} es requerido")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool Recuerdame { get; set; }
    }
}
