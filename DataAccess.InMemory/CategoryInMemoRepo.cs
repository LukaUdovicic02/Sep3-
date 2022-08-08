

using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Interfaces;
using Entity;

namespace DataAccess.InMemory
{
    public class CategoryInMemoRepo : ICategoryRepo
    {
        private List<Category> categories;

        public CategoryInMemoRepo()
        {
            categories = new List<Category>()
            {
                new Category() {CategoryId = 1, Name = "Beverage", Desc = "Beverage"},
                new Category() {CategoryId = 2, Name = "Bakery", Desc = "Bakery"},
                new Category() {CategoryId = 3, Name = "Meat", Desc = "Meat"},
            };
        }

        public IEnumerable<Category> GetCategories()
        {
            return categories;
        }

        public void AddCategory(Category category)
        {
            if (categories.Any(x => x.Name.Equals(category.Name, StringComparison.OrdinalIgnoreCase))) return;
            if (categories != null && categories.Count > 0)
            {
                var maxId = categories.Max(x => x.CategoryId);
                category.CategoryId = maxId + 1;
            }
            else category.CategoryId = 1;

            categories.Add(category);
        }

        public void UpdateCategory(Category category)
        {
            var categoryToChange = categories?.FirstOrDefault(x => x.CategoryId == category.CategoryId);
            if (categoryToChange != null)
            {
                categoryToChange.Name = category.Name;
                categoryToChange.Desc = category.Desc;
            }
        }

        public Category GetCategoryById(int categoryId)
        {
            return categories?.FirstOrDefault(x => x.CategoryId == categoryId);
        }

        public void RemoveCategory(int categoryId)
        {
            categories?.Remove(GetCategoryById(categoryId));
        }
    }
}