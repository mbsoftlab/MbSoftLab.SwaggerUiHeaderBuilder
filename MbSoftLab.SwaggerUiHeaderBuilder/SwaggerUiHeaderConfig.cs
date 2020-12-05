using System;
using System.Collections.Generic;
using System.Text;

namespace MbSoftLab.SwaggerUiHeaderBuilder
{
    public class SwaggerUiCustomHeaderConfig : ISwaggerUiCustomHeaderConfig
    {
        public String Version { get; set; }
        public String Titel { get; set; }
        public String HeaderImageSrc { get; set; } = "";
        public String HoverColor { get; set; } = "#c56900";
        public String HoverFontColor { get; set; } = "white";
        public string CustomLinks { get; set; } = "";
        public string HeaderBgColor { get; set; } = "#333";
        public string HeaderFontColor { get; set; } = "white";
    }
}
