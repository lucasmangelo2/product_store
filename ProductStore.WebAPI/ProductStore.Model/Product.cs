using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductStore.Model
{
    [Table("TB_PRODUTO")]
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Column("NOME"), Required, MaxLength(30)]
        public string Name { get; set; }

        [Column("DESCRICAO"), Required, MaxLength(200)]
        public string Description { get; set; }

        [Column("PRECO"), Required]
        public decimal Price { get; set; }

        [Column("ESTOQUE"), Required]
        public int Stock { get; set; }

        [Column("CATEGORIA_ID"), Required]
        public int CategoryId { get; set; }

        #region Navigations

        public Category Category { get; set; }

        public List<Document> Documents { get; set; }

        #endregion

    }
}
