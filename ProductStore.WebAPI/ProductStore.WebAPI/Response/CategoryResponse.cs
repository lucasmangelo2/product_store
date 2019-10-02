using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductStore.WebAPI.Response
{
    /// <summary>
    /// Objeto para retorno de categorias
    /// </summary>
    public class CategoryResponse
    {
        /// <summary>
        /// Identiifcador único
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome
        /// </summary>
        [Required, MaxLength(15)]
        public string Name { get; set; }

        /// <summary>
        /// Descrição
        /// </summary>
        [MaxLength(50)]
        public string Description { get; set; }

        /// <summary>
        /// Codigo d
        /// </summary>
        public int? CategoryFatherId { get; set; }

        #region Navitagions

        public CategoryResponse CategoryFather { get; set; }
        public List<CategoryResponse> SubCategories { get; set; }

        #endregion
    }
}
