using BlogUNAH.API.Database.Entities;
using BlogUNAH.API.Dtos.Categories;
using BlogUNAH.API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BlogUNAH.API.Controllers
{
    [ApiController]
    [Route("api/categories")]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoriesService _categoriesService;

        public CategoriesController(ICategoriesService categoriesService)
        {
            this._categoriesService = categoriesService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok( await _categoriesService.GetCategoriesListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(Guid id) 
        {
            //var category = new Category
            //{
            //    Id = Guid.NewGuid(),
            //    Name = "C#",
            //    Description = "Super mega hper lenguaje de programacion"
            //};

            var category = await _categoriesService.GetCategoryByIdAsync(id);

            if (category == null) 
            {
                return NotFound(new {Message = $"No se encontro la categoria: {id}"});
            }
            return Ok(category);
        }

        [HttpPost]
        public async Task<ActionResult> Create(CategoryCreateDto category) 
        {

            //if (string.IsNullOrEmpty(category.Name))
            //{
            //    return BadRequest(new { Message = "El nombre de la categoria es requerido" });
            //}
            
            //if(!string.IsNullOrEmpty(category.Description) && category.Description.Length < 10) 
            //{
            //    return BadRequest(new {Message = "La descripcion debe tener almenos 10 caracteres."});
            //}

            //bool categoryExist = _categories.Any(x => x.Name.ToUpper().Trim().Contains(category.Name.ToUpper()));
            //if (!categoryExist) 
            //{
            //    return BadRequest("La categotia ya esta registrada.");
            //}
            //category.Id = Guid.NewGuid(); // Se general Id cada vez que lo solicitemos
            //_categories.Add(category);

            await _categoriesService.CreateAsync(category);

            return StatusCode(201);
        }

        [HttpPut("{id}")]

        public async Task<ActionResult> Edit(CategoryEditDto dto, Guid id) 
        {
             var result = await _categoriesService.EditAsync(dto, id);

            if (!result) 
            {
                return NotFound();
            }

            return Ok();
        }


        [HttpDelete("{id}")]

        public async Task<ActionResult> Delete(Guid id)
        {
            var category = await _categoriesService.GetCategoryByIdAsync(id);

            if (category is null) 
            {
                return NotFound();
            }

            await _categoriesService.DeleteAsync(id);

            return Ok();
        }
    }
}
