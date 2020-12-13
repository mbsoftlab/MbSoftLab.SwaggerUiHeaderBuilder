using MbSoftLab.TemplateEngine.Core;
using System;

namespace MbSoftLab.SwaggerUiHeaderBuilder
{
    public class SwaggerUiHeaderBuilder : ISwaggerUiHeaderBuilder
    {
        ISwaggerUiCustomHeaderConfig _swaggerUiCustomHeaderConfig;
        HeaderTemplateLoader _headerTemplateLoader;
        public SwaggerUiHeaderBuilder()
        {
            _swaggerUiCustomHeaderConfig = new SwaggerUiCustomHeaderConfig();
            _headerTemplateLoader = new HeaderTemplateLoader();
        }
        public ISwaggerUiHeaderBuilder UseConfig(ISwaggerUiCustomHeaderConfig value)
        {
            _swaggerUiCustomHeaderConfig = value;
            return this;
        }
        public ISwaggerUiHeaderBuilder ForVersion(string value)
        {
            _swaggerUiCustomHeaderConfig.Version = value;
            return this;
        }
        public ISwaggerUiHeaderBuilder ForTitel(string value)
        {
            _swaggerUiCustomHeaderConfig.Titel = value;
            return this;
        }
        public ISwaggerUiHeaderBuilder ForImageSrc(string value)
        {
            _swaggerUiCustomHeaderConfig.HeaderImageSrc = value;
            return this;
        }
        public ISwaggerUiHeaderBuilder ForHeaderBgColor(string value)
        {
            _swaggerUiCustomHeaderConfig.HeaderBgColor = value;
            return this;
        }
        public ISwaggerUiHeaderBuilder ForHeaderFontColor(string value)
        {
            _swaggerUiCustomHeaderConfig.HeaderFontColor = value;
            return this;
        }
        public ISwaggerUiHeaderBuilder ForHoverBgColor(string value)
        {
            _swaggerUiCustomHeaderConfig.HoverColor = value;
            return this;
        }
        public ISwaggerUiHeaderBuilder ForHoverFontColor(string value)
        {
            _swaggerUiCustomHeaderConfig.HoverFontColor = value;
            return this;
        }
        /// <summary>
        /// Add a custom Link to the hamburger menu
        /// </summary>
        /// <param name="caption">Visable linkcaption </param>
        /// <param name="href">URL to customlink</param>
        /// <returns></returns>
        public ISwaggerUiHeaderBuilder AddCustomLink(string caption, Uri href)
        {
            this._swaggerUiCustomHeaderConfig.CustomLinks += $"<a href='{href.OriginalString}'>{caption}</a>";
            return this;
        }
        /// <summary>
        /// Builds the custom HeadContent as HTML with the specified parameters
        /// <see cref="SwaggerUiOptionsHeadContentExtensions.UseCustomHeader(Swashbuckle.AspNetCore.SwaggerUI.SwaggerUIOptions, Action{SwaggerUiHeaderBuilder})"/> 
        ///</summary>
        /// <returns>String with HTML Header for </returns>
        public string Build()
        {
            string customHeaderHtmlTemplate = _headerTemplateLoader.GetHeaderTemplateFromRessource();
            TemplateEngine<ISwaggerUiCustomHeaderConfig> templateEngine =
                new TemplateEngine<ISwaggerUiCustomHeaderConfig>(_swaggerUiCustomHeaderConfig, customHeaderHtmlTemplate);
            return templateEngine.CreateStringFromTemplate();
        }
    }
}
