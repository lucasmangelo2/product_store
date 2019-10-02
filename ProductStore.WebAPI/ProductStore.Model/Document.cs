using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductStore.Model
{
    [Table("TB_DOCUMENTO")]
    public class Document
    {
        [Key]
        public int Id { get; set; }

        [Column("NOME"), Required, MaxLength(50)]
        public string Name { get; set; }

        [Column("ARQUIVO"), Required]
        public byte[] Archive { get; set; }
    }
}
