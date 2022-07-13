using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MultiTenancyWithAutofac.Pages
{
    public class IndexModel : PageModel
    {
        public ITenantProperties TenantProperties { get; }
        private readonly ILogger<IndexModel> _logger;
        private readonly IDependency _dependency;


        public IndexModel(ILogger<IndexModel> logger, IDependency dependency, ITenantProperties tenantProperties)
        {
            TenantProperties = tenantProperties;
            _logger = logger;
            _dependency = dependency;
        }

        public void OnGet()
        {
            _dependency.PrintName();
        }
    }
}