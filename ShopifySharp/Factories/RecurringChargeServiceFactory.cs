// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.
#if NETSTANDARD2_0
#nullable disable
#else
#nullable enable
#endif

using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface IRecurringChargeServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    IRecurringChargeService Create(ShopifyRestApiCredentials credentials);
}

public class RecurringChargeServiceFactory(
    #if NETSTANDARD2_0
    IRequestExecutionPolicy requestExecutionPolicy = null
    #else
    IRequestExecutionPolicy? requestExecutionPolicy = null
    #endif
) : IRecurringChargeServiceFactory
{
    public virtual IRecurringChargeService Create(ShopifyRestApiCredentials credentials)
    {
        var service = new RecurringChargeService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
