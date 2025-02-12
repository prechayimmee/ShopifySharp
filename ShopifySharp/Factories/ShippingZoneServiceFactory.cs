// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.
#if NETSTANDARD2_0
#nullable disable
#else
#nullable enable
#endif

using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface IShippingZoneServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    IShippingZoneService Create(ShopifyRestApiCredentials credentials);
}

public class ShippingZoneServiceFactory(
    #if NETSTANDARD2_0
    IRequestExecutionPolicy requestExecutionPolicy = null
    #else
    IRequestExecutionPolicy? requestExecutionPolicy = null
    #endif
) : IShippingZoneServiceFactory
{
    public virtual IShippingZoneService Create(ShopifyRestApiCredentials credentials)
    {
        var service = new ShippingZoneService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
