using Autofac.Multitenant;

namespace MultiTenancyWithAutofac;

public class BasicTenantIdentificationStrategy : ITenantIdentificationStrategy
{
    public bool TryIdentifyTenant(out object tenantId)
    {
        tenantId = "2";
        return true;
    }
}