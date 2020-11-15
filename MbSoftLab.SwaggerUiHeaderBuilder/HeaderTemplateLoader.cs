using System.IO;
using System.Reflection;

namespace MbSoftLab.SwaggerUiHeaderBuilder
{
    class HeaderTemplateLoader
    {
        public string GetHeaderTemplateFromRessource()
        {
            var assembly = typeof(SwaggerUiHeaderBuilder).GetTypeInfo().Assembly;
            Stream resource = assembly.GetManifestResourceStream("MbSoftLab.SwaggerUiHeaderBuilder.Custom.Header.Template.html");
            StreamReader reader = new StreamReader(resource);
            string text = reader.ReadToEnd();

            return text;
        }
    }
}
