using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class Clase3
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(40)] //Esto creo que es NVChar
        public string Producto { get; set; }

        [Required]
        public int  Precio { get; set; }
    }
}
