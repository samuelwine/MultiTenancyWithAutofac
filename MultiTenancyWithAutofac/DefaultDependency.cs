namespace MultiTenancyWithAutofac
{
    public class DefaultDependency : IDependency
    {
        public void PrintName()
        {
            Console.WriteLine("Hello from Default");
        }
    }
}
