using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public class Clase1 //Clase principal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(40)]
        public string Nombre { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        //Clave Foranea (Apareceran los datos de las otras tablas aqui)

        public int Clase2_ID { get; set; }

        [ForeignKey("Clase2_ID")]
        public Clase2 Clase2 { get; set; }

        public int Clase4_ID { get; set; }

        [ForeignKey("Clase4_ID")]
        public Clase4 Clase4 { get; set; }
    }
}
