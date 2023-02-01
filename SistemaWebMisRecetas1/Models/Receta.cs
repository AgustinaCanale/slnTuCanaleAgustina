
using SistemaWebMisRecetas1.Validations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaWebMisRecetas1.Models
{
    [Table("RECETAMVC")]
    public class Receta
    {
          
        
        public int Id { get; set; }
        [Required]
        public string Titulo { get; set; }

        [Required]
        [DesayunoName]

        public string Categoria { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        public string Ingredientes { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        public string Instrucciones { get; set; }
        [Required]
        public string Autor { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Required]
        [Mayor18]
        public string Edad { get; set; }
        [Required]

        [RegularExpression(@"^([\w.-]+)@([\w-]+)((.(\w){2,3})+)$")]
        public string Email { get; set; }
    }
}
    

