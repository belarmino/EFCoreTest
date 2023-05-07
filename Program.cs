using Database.Context;
using Database.Models;

using NewsContext db = new NewsContext();

// CREATE
Console.WriteLine("---------------------------------");
Console.WriteLine("Create a new category");
Category category = new Category { Name = "Software" };
db.Add(category);
db.SaveChanges();
Console.WriteLine($"Created CategoryId:{category.CategoryId} Name:{category.Name}");

// READ
Console.WriteLine("---------------------------------");
Console.WriteLine("Querying for a category");
IQueryable<Category> categories = db.Category.OrderBy(b => b.CategoryId);
Category _category = categories.First();
Console.WriteLine($"Querying CategoryId:{_category.CategoryId} Name:{_category.Name}");

// UPDATE
Console.WriteLine("---------------------------------");
Console.WriteLine("Update the category");
_category.Name = "Software Development";
db.SaveChanges();

// READ
Console.WriteLine("---------------------------------");
Console.WriteLine("Querying Updated category");
IQueryable<Category> _categories = categories.Where(f=>f.Name.Contains(_category.Name));
Console.WriteLine($"Number {_categories.Count()}");
foreach(Category cat in _categories){
    Console.WriteLine($"Updated CategoryId:{cat.CategoryId} Name:{cat.Name}");
}

// DELETE
Console.WriteLine("---------------------------------");
Console.WriteLine("Delete the category");
db.Remove(_category);
db.SaveChanges();