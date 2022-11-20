using Category_List.Data;
using Category_List.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Category_List.Pages.Categories
{
    public class IndexModel : PageModel
    {
        public readonly AppDbContext _db;
        public IEnumerable<Category> Categories { get; set; }
        public IndexModel(AppDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            Categories = _db.Categories;
        }
    }
}
