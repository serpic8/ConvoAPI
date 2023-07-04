using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class Clase2
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(40)]
        public string Venta { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        //Clave Foranea
        public int Clase3_ID { get; set; }

        [ForeignKey("Clase3_ID")]
        public Clase3 Clase3 { get; set; }
    }
}
