namespace MultiTenancyWithAutofac
{
    public class TenantOneProperties : ITenantProperties
    {
        public string Name { get; set; } = "TenantOne";
        public string ConnectionString { get; set; } = "AHT";
        public string CssFile { get; set; } = "~/css/tenantone.css";
    }
}
