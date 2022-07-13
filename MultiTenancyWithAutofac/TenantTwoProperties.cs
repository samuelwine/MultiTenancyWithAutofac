namespace MultiTenancyWithAutofac;

class TenantTwoProperties : ITenantProperties
{
    public string Name { get; set; } = "Tenant2";
    public string ConnectionString { get; set; } = "ABF";
    public string CssFile { get; set; } = "~/css/tenanttwo.css";
}