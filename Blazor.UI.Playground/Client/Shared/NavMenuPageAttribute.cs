namespace Blazor.UI.Playground.Client.Shared
{
    [System.AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public sealed class NavMenuPageAttribute : Attribute
    {
        // This is a positional argument
        public NavMenuPageAttribute(string text, string iconCSS = "")
        {
            Text = text;
            IconCSS = iconCSS;
        }

        public string Text { get; private set; }
        public string IconCSS { get; private set; }
    }
}
