using Microsoft.Extensions.Configuration;
using System;

namespace MbSoftLab.SwaggerUiHeaderBuilder.Demo
{
    public class YourJsonSwaggerUiCustomHeaderConfig : ISwaggerUiCustomHeaderConfig
    {
        private readonly IConfiguration _configuration;
        public YourJsonSwaggerUiCustomHeaderConfig(IConfiguration configuration) => _configuration = configuration;
        public string CustomLinks { get => _configuration.GetValue<string>("SwaggerUiHeaderConfig:CustomLinks"); set => throw new NotImplementedException("Customlink must be added in json.config as <a href='customUrl.de'>CustomCaption</a>"); }
        public string HeaderBgColor { get => _configuration.GetValue<string>("SwaggerUiHeaderConfig:HeaderBgColor"); set => throw new NotImplementedException(); }
        public string HeaderFontColor { get => _configuration.GetValue<string>("SwaggerUiHeaderConfig:HeaderFontColor"); set => throw new NotImplementedException(); }
        public string HeaderImageSrc { get => _configuration.GetValue<string>("SwaggerUiHeaderConfig:HeaderImageSrc"); set => throw new NotImplementedException(); }
        public string HoverColor { get => _configuration.GetValue<string>("SwaggerUiHeaderConfig:HoverColor"); set => throw new NotImplementedException(); }
        public string HoverFontColor { get => _configuration.GetValue<string>("SwaggerUiHeaderConfig:HoverFontColor"); set => throw new NotImplementedException(); }
        public string Titel { get => _configuration.GetValue<string>("SwaggerUiHeaderConfig:Titel"); set => throw new NotImplementedException(); }
        public string Version { get => _configuration.GetValue<string>("SwaggerUiHeaderConfig:Version"); set => throw new NotImplementedException(); }
    }
}
