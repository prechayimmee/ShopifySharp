namespace ShopifySharp.Extensions.DependencyInjection.Tests;

public class FactoryServiceTests
{
    private readonly ShopifyRestApiCredentials _credentials = new("some-shopify-domain", "some-access-token");

    [Fact]
    public void FactoryServices_WhenRequestExecutionPolicyIsNotInjected_ShouldCreateService()
    {
        // Setup
        var container = new ServiceCollection();
        container.AddShopifySharpServiceFactories();
        var serviceProvider = container.BuildServiceProvider();

        // Act
        var orderServiceFactory = serviceProvider.GetRequiredService<IOrderServiceFactory>();
        var act = () => orderServiceFactory.Create(_credentials);

        // Assert
        act.Should()
            .NotThrow()
            .Subject
            .Should()
            .BeOfType<OrderService>();
    }

    [Fact]
    public async Task FactoryServices_WhenRequestExecutionPolicyIsInjected_ShouldCreateServiceWithThePolicy()
    {
        // Setup
        var container = new ServiceCollection();
        container.AddShopifySharpServiceFactories();
        container.AddShopifySharpRequestExecutionPolicy<TestRequestExecutionPolicy>();
        var serviceProvider = container.BuildServiceProvider();

        // Act
        var orderServiceFactory = serviceProvider.GetRequiredService<IOrderServiceFactory>();
        var orderService = orderServiceFactory.Create(_credentials);
        var act = () => orderService.ListAsync();

        // Assert
        await act.Should()
            .ThrowAsync<TestException>();
    }
}
