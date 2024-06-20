using BlogUNAH.API.Database.Entities;
using BlogUNAH.API.Dtos;
using BlogUNAH.API.Dtos.Categories;
using BlogUNAH.API.Services.Interfaces;
using Newtonsoft.Json;
using System.Xml;

namespace BlogUNAH.API.Services
{
    public class CategoriesService : ICategoriesService
    {
        public readonly string _JSON_FILE;
        public CategoriesService()
        {
            _JSON_FILE = "SeedData/categories.json";
        }
        public async Task<List<CategoryDto>> GetCategoriesListAsync()
        {
            return await ReadCategoriesFromFileAsync();
        }

        public async Task<CategoryDto>  GetCategoryByIdAsync(Guid id)
        {
            var categories = await ReadCategoriesFromFileAsync();
            CategoryDto category = categories.FirstOrDefault(c => c.Id == id);
            return category;
        }
        public async Task<bool> CreateAsync(CategoryCreateDto dto)
        {
            var categoriesDtos = await ReadCategoriesFromFileAsync();

            //dto.Id = Guid.NewGuid();

            var categoryDto = new CategoryDto
            {
                Id = Guid.NewGuid(),
                Name = dto.Name,
                Description = dto.Description,
            };

            categoriesDtos.Add(categoryDto);

            var categories = categoriesDtos.Select(x => new Category
            {
                Id = Guid.NewGuid(),
                Name = dto.Name,
                Description = dto.Description,
            }).ToList();

            await WriteCategoriesToFileAsync(categories);

            return true;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var categoriesDto = await ReadCategoriesFromFileAsync();
            var categoryToDelete = categoriesDto.FirstOrDefault(x => x.Id == id);

            if (categoryToDelete is null)
            {
                return false;
            }

            categoriesDto.Remove(categoryToDelete);

            var categories = categoriesDto.Select(x => new Category
            {
                Id = Guid.NewGuid(),
                Name = x.Name,
                Description = x.Description,
            }).ToList();

            await WriteCategoriesToFileAsync(categories);



            return true;
        }

        public async Task<bool> EditAsync(CategoryEditDto dto, Guid id)
        {
            var categoriesDto = await ReadCategoriesFromFileAsync();

            var existingCategory = categoriesDto.FirstOrDefault(c => c.Id == id);

            if (existingCategory is null) 
            {
                return false;
            }

            //TODO: Recorrer las categorias y actualizar la correspondiente de la lista

            for (int i = 0; i < categoriesDto.Count; i++)
            {
                if (categoriesDto[i].Id == id)
                {
                    categoriesDto[i].Name= dto.Name;
                    categoriesDto[i].Description= dto.Description;
                }
            }

            var categories = categoriesDto.Select(x => new Category
            {
                Id = Guid.NewGuid(),
                Name = x.Name,
                Description = x.Description,
            }).ToList();

            await WriteCategoriesToFileAsync(categories);
            return true;
        }

        private async Task<List<CategoryDto>> ReadCategoriesFromFileAsync() 
        {
            if (!File.Exists(_JSON_FILE))
               {
                return new List<CategoryDto>();
               }

            var json = await File.ReadAllTextAsync(_JSON_FILE);

            var categories = JsonConvert.DeserializeObject<List<Category>>(json);

            var dtos = categories.Select(x => new CategoryDto
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
            }).ToList();

            return dtos;
        }

        private async Task WriteCategoriesToFileAsync(List<Category> categories)
        { 
            var json = JsonConvert.SerializeObject(categories, Newtonsoft.Json.Formatting.Indented);

            await File.WriteAllTextAsync(_JSON_FILE, json);
        }
    }

}
