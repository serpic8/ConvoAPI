using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models.Dto
{
    public class Clase3Dto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(40)] //Esto creo que es NVChar
        public string Producto { get; set; }

        [Required]
        public int Precio { get; set; }
    }
}
