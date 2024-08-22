namespace Blazor.UI.UrlParameterSwitch;

public interface IParameterTemplateValueConverter
{
    object? Convert(string? value, Type targetType);
}