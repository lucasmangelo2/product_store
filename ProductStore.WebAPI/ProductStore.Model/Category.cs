using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProductStore.Model
{
    [Table("TB_CATEGORIA")]
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required, Column("NOME"), MaxLength(15)]
        public string Name { get; set; }

        [Column("DESCRICAO"), MaxLength(50)]
        public string Description { get; set; }

        [Column("CATEGORIA_PAI_ID"), MaxLength(50)]
        public int CategoryFatherId { get; set; }

        #region Navitagions

        public Category CategoryFather { get; set; }
        public List<Category> SubCategories { get; set; }

        #endregion

    }
}
