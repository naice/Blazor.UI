using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Components;

namespace Blazor.UI.UrlParameterSwitch;

public class ParameterTemplateEvaluator : IParameterTemplateEvaluator
{
    private readonly NavigationManager _navigationManager;
    private readonly IParameterTemplateValueConverter _valueConverter;

    public ParameterTemplateEvaluator(NavigationManager navigationManager, IParameterTemplateValueConverter valueConverter)
    {
        _navigationManager = navigationManager;
        _valueConverter = valueConverter;
    }
    
    /// <summary>
    /// % captures * skips
    /// </summary>
    /// <param name="parameterTemplate">
    /// % captures * skips
    /// </param>
    /// <returns>
    /// captured string or null.
    /// </returns>
    private string? GetUrlValueFrom(string parameterTemplate, string url)
    {
        var uri = new UriBuilder(url);
        var pattern = ".*?" + string.Join(@".*?", parameterTemplate.Split('*').Select(x => 
            string.Join(@"([^\/]*)", x.Split('%').Select(Regex.Escape))));
        var match = Regex.Match(uri.Path, pattern);
        return match.Success ? match.Groups[1].Value : null;
    }

    public object? Evaluate(string parameterTemplate, string url, Type targetType)
    {
        var stringValue = GetUrlValueFrom(parameterTemplate, url);
        return _valueConverter.Convert(stringValue, targetType);
    }
}