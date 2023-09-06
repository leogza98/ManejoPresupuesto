using ManejoPresupuesto.Validaciones;
using System.ComponentModel.DataAnnotations;

namespace ManejoPresupuesto.Models
{
    public class Cuenta
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El Campo {0} es Requerido")]
        [StringLength(maximumLength: 50)]
        [PrimeraLetraMayuscula]
        public string Nombre { get; set; }
        [Display(Name = "Tipo cuenta")]
        public int TipoCuentaId { get; set; }
        public decimal  Balance { get; set; }
        [StringLength(maximumLength: 1000)]
        public string Descripcion { get; set; }
        public string TipoCuenta { get; set; }
            
    }
}
