using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProductStore.WebAPI.Request
{
    /// <summary>
    /// Objeto para requisição de categorias
    /// </summary>
    public class CategoryRequest
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
    }
}
