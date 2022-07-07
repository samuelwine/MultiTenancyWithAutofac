using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MultiTenancyWithAutofac.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IDependency _dependency;

        public IndexModel(ILogger<IndexModel> logger, IDependency dependency)
        {
            _logger = logger;
            _dependency = dependency;
        }

        public void OnGet()
        {
            _dependency.PrintName();
        }
    }
}