namespace Blazor.UI.UrlParameterSwitch;

public class ParameterTemplateValueConverter : IParameterTemplateValueConverter
{
    public object? Convert(string? value, Type targetType)
    {
        if (targetType == typeof(string))
        {
            return value;
        }
        else if (targetType.IsEnum)
        {
            return Enum.Parse(targetType, value ?? "", true);
        }

        return null;
    }
}