using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;

namespace RazorPagesPizza.Pages;

// [Authorize(Policy = "Admin")]
public class AdminsOnlyModel : PageModel
{
    private readonly ILogger<AdminsOnlyModel> _logger;

    public AdminsOnlyModel(ILogger<AdminsOnlyModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

