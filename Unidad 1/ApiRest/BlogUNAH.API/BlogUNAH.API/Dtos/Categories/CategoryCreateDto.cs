using System.ComponentModel.DataAnnotations;

namespace BlogUNAH.API.Dtos.Categories
{
    public class CategoryCreateDto
    {
        //Data Annotations
        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "El nombre de la categoria es requerido.")]
        public string Name { get; set; }
        [Display(Name = "Descripcion")]
        [MinLength(10, ErrorMessage = "La {0} descripcion debe tener almenos {1}")]

        public string Description { get; set; }
    }
}
