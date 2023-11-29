using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace Basket.API.Models
{
    [Table("Basket", Schema = "dbo")]
    public class BasketModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("BasketId")]
        public int Id { get; set; }

        [Column("Name")]
        public string Name { get; set; }

        [Column("OrderId")]
        public int OrderId { get; set; }
    }
}
