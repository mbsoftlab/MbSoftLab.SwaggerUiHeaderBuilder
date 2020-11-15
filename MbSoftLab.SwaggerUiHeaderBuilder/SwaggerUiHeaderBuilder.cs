using MbSoftLab.TemplateEngine.Core;
using System;

namespace MbSoftLab.SwaggerUiHeaderBuilder
{
    public class SwaggerUiHeaderBuilder
    {
        SwaggerUiCustomHeaderConfig _swaggerUiCustomHeaderConfig;
        HeaderTemplateLoader _headerTemplateLoader;
        public SwaggerUiHeaderBuilder()
        {
            _swaggerUiCustomHeaderConfig = new SwaggerUiCustomHeaderConfig();
            _headerTemplateLoader = new HeaderTemplateLoader();
        }
        public SwaggerUiHeaderBuilder ForVersion(string value)
        {
            _swaggerUiCustomHeaderConfig.Version = value;
            return this;
        }
        public SwaggerUiHeaderBuilder ForTitel(string value)
        {
            _swaggerUiCustomHeaderConfig.Titel = value;
            return this;
        }
        public SwaggerUiHeaderBuilder ForImageSrc(string value)
        {
            _swaggerUiCustomHeaderConfig.HeaderImageSrc = value;
            return this;
        }
        public SwaggerUiHeaderBuilder ForHeaderBgColor(string value)
        {
            _swaggerUiCustomHeaderConfig.HeaderBgColor = value;
            return this;
        }
        public SwaggerUiHeaderBuilder ForHeaderFontColor(string value)
        {
            _swaggerUiCustomHeaderConfig.HeaderFontColor = value;
            return this;
        }
        public SwaggerUiHeaderBuilder ForHoverBgColor(string value)
        {
            _swaggerUiCustomHeaderConfig.HoverColor = value;
            return this;
        }
        public SwaggerUiHeaderBuilder ForHoverFontColor(string value)
        {
            _swaggerUiCustomHeaderConfig.HoverFontColor = value;
            return this;
        }
        public SwaggerUiHeaderBuilder AddCustomLink(string caption, Uri href)
        {
            this._swaggerUiCustomHeaderConfig.CustomLinks += $"<a href='{href.OriginalString}'>{caption}</a>";
            return this;
        }
        public string Build()
        {
            string customHeaderHtmlTemplate = _headerTemplateLoader.GetHeaderTemplateFromRessource();
            TemplateEngine<SwaggerUiCustomHeaderConfig> templateEngine =
                new TemplateEngine<SwaggerUiCustomHeaderConfig>(_swaggerUiCustomHeaderConfig, customHeaderHtmlTemplate);
            return templateEngine.CreateStringFromTemplate();
        }
    }
}
