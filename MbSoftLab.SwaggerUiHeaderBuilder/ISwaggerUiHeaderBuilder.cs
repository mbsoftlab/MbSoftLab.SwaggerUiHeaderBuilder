using System;

namespace MbSoftLab.SwaggerUiHeaderBuilder
{
    public interface ISwaggerUiHeaderBuilder
    {
        ISwaggerUiHeaderBuilder AddCustomLink(string caption, Uri href);
        string Build();
        ISwaggerUiHeaderBuilder UseConfig(ISwaggerUiCustomHeaderConfig value);
        ISwaggerUiHeaderBuilder ForHeaderBgColor(string value);
        ISwaggerUiHeaderBuilder ForHeaderFontColor(string value);
        ISwaggerUiHeaderBuilder ForHoverBgColor(string value);
        ISwaggerUiHeaderBuilder ForHoverFontColor(string value);
        ISwaggerUiHeaderBuilder ForImageSrc(string value);
        ISwaggerUiHeaderBuilder ForTitel(string value);
        ISwaggerUiHeaderBuilder ForVersion(string value);
    }
}