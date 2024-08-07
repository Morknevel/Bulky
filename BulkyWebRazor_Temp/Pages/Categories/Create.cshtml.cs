using BulkyWebRazor_Temp.Data;
using BulkyWebRazor_Temp.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulkyWebRazor_Temp.Pages.Categories;

public class Create : PageModel
{
    private readonly ApplicationDbContext _db;
    public Category Category { get; set; }

    public Create(ApplicationDbContext db)
    {
        _db = db;
    }
    public void OnGet()
    {
    }
}