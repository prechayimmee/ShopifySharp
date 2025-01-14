// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.
#if NETSTANDARD2_0
#nullable disable
#else
#nullable enable
#endif

using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface IWebhookServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    IWebhookService Create(ShopifyRestApiCredentials credentials);
}

public class WebhookServiceFactory(
    #if NETSTANDARD2_0
    IRequestExecutionPolicy requestExecutionPolicy = null
    #else
    IRequestExecutionPolicy? requestExecutionPolicy = null
    #endif
) : IWebhookServiceFactory
{
    public virtual IWebhookService Create(ShopifyRestApiCredentials credentials)
    {
        var service = new WebhookService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
