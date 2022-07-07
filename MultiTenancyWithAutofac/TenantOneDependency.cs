namespace MultiTenancyWithAutofac
{
    public class TenantOneDependency : IDependency
    {
        public void PrintName()
        {
            Console.WriteLine("HelloFromTenantOne");
        }
    }
}
