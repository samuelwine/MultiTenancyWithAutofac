namespace MultiTenancyWithAutofac
{
    public class TenantTwoDependency : IDependency
    {
        public void PrintName()
        {
            Console.WriteLine("HelloFromTenantTwo");
        }
    }
}
