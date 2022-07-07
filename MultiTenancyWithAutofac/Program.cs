using Autofac;
using Autofac.Multitenant;

namespace MultiTenancyWithAutofac
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Host.UseServiceProviderFactory(new AutofacMultitenantServiceProviderFactory(ConfigureMultitenantContainer));

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddScoped<IDependency, DefaultDependency>();

            builder.Services.AddAutofacMultitenantRequestServices();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }

        private static MultitenantContainer ConfigureMultitenantContainer(IContainer container)
        {
            var tenantIdentifier = new BasicTenantIdentificationStrategy();
            var mtc = new MultitenantContainer(tenantIdentifier, container);
            mtc.ConfigureTenant("1", cb => cb.RegisterType<TenantOneDependency>().As<IDependency>());
            mtc.ConfigureTenant("2", cb => cb.RegisterType<TenantTwoDependency>().As<IDependency>());
            return mtc;
        }
    }
}