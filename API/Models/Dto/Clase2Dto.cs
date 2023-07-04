using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models.Dto
{
    public class Clase2Dto
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
