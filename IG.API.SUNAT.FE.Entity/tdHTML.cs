using System.ComponentModel.DataAnnotations.Schema;

namespace IG.API.SUNAT.FE.Entity
{
    public class tdHTML:EntityBase
    {
        [NotMapped]  
        public new int Id { get; set; }
        public int IdtdHTML { get; set; }
        public string TipoHTML { get; set; }
        public string HTML { get; set; }
    }
}
