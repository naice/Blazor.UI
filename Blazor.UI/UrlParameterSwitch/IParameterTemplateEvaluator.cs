namespace Blazor.UI.UrlParameterSwitch;

public interface IParameterTemplateEvaluator
{
    object? Evaluate(string parameterTemplate, string url, Type targetType);
}