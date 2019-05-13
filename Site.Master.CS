public IQueryable<Category> GetCategories()
{
 var _db = new WingtipToys.Models.ProductContext();
 IQueryable<Category> query = _db.Categories;
 return query;
}
