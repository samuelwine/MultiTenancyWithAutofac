namespace MultiTenancyWithAutofac
{
    public interface ITenantProperties
    {
        public string Name { get; set; }
        public string ConnectionString { get; set; }
        public string CssFile { get; set; }
    }
}
