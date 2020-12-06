using Swashbuckle.AspNetCore.SwaggerUI;
using System;

namespace MbSoftLab.SwaggerUiHeaderBuilder
{
    public static class SwaggerUiOptionsHeadContentExtensions
    {
        public static void UseCustomHeader(this SwaggerUIOptions options, Action<SwaggerUiHeaderBuilder> header)
        {
            var swaggerUiHeaderBuilder = new SwaggerUiHeaderBuilder();
            header?.Invoke(swaggerUiHeaderBuilder);

            options.HeadContent = swaggerUiHeaderBuilder.Build();

        }
    }
}
