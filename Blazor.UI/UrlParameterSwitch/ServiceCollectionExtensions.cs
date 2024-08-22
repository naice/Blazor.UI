using Microsoft.Extensions.DependencyInjection;

namespace Blazor.UI.UrlParameterSwitch;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddUrlParameterSwitch(this IServiceCollection serviceCollection)
    {
        serviceCollection
            .AddSingleton<IParameterTemplateEvaluator, ParameterTemplateEvaluator>()
            .AddSingleton<IParameterTemplateValueConverter, ParameterTemplateValueConverter>()
            ;
        return serviceCollection;
    }
}