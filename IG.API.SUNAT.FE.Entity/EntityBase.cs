using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IG.API.SUNAT.FE.Entity
{
  public  class EntityBase
    {
        public int Id { get; set; }

        [Column("FechaCreacion")]
        [DataType(DataType.DateTime)]
        public DateTime FechaCreacion { get; set; }

        [Column("FechaModificacion")]
        [DataType(DataType.DateTime)]
        public DateTime? FechaModificacion { get; set; }

        protected EntityBase()
        {
            FechaCreacion = DateTime.Now;
        }
    }
}
