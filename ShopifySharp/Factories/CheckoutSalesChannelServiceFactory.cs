// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.
#if NETSTANDARD2_0
#nullable disable
#else
#nullable enable
#endif

using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface ICheckoutSalesChannelServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    ICheckoutSalesChannelService Create(ShopifyRestApiCredentials credentials);
}

public class CheckoutSalesChannelServiceFactory(
    #if NETSTANDARD2_0
    IRequestExecutionPolicy requestExecutionPolicy = null
    #else
    IRequestExecutionPolicy? requestExecutionPolicy = null
    #endif
) : ICheckoutSalesChannelServiceFactory
{
    public virtual ICheckoutSalesChannelService Create(ShopifyRestApiCredentials credentials)
    {
        var service = new CheckoutSalesChannelService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
