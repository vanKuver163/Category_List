using Category_List.Data;
using Category_List.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Category_List.Pages.Categories
{
    
    public class CreateModel : PageModel
    {
        private readonly AppDbContext _db;

        [BindProperty]
        public Category Category { get; set; }
        public CreateModel(AppDbContext db)
        {
            _db = db;          
        }

       
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            if (Category.Name == Category.DisplayOrder.ToString())
            {
                ModelState.AddModelError("Category.Name", "The Display Order cannot exactly match the Name.");
            }
            if (ModelState.IsValid)
            { 
                await _db.Categories.AddAsync(Category);
                await _db.SaveChangesAsync();
                TempData["Success"] = "Category created successfully";
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
