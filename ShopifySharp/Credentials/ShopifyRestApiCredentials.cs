#if NETSTANDARD2_0
#else
#nullable enable
#endif

using System;

namespace ShopifySharp.Credentials
{
    public readonly struct ShopifyRestApiCredentials(string shopDomain, string accessToken)
    {
        public string ShopDomain { get; } = shopDomain;
        public string AccessToken { get; } = accessToken;

        #if NETSTANDARD2_0
        public override bool Equals(object obj)
        {
            return obj is ShopifyRestApiCredentials other
                && ShopDomain == other.ShopDomain
                && AccessToken == other.AccessToken;
        }
        #else
        public override bool Equals(object? obj)
        {
            return obj is ShopifyRestApiCredentials other
                && ShopDomain == other.ShopDomain
                && AccessToken == other.AccessToken;
        }
        #endif

        public override int GetHashCode()
        {
            #if NETSTANDARD2_0
            return (ShopDomain, AccessToken).GetHashCode();
            #else
            return HashCode.Combine(ShopDomain, AccessToken);
            #endif
        }
    }
}
