namespace MbSoftLab.SwaggerUiHeaderBuilder
{
    public interface ISwaggerUiCustomHeaderConfig
    {
        /// <summary>
        /// Html tags for custom links in haburgermenu 
        /// </summary>
        string CustomLinks { get; set; }
        /// <summary>
        /// Backgroundcolor for Header
        /// </summary>
        string HeaderBgColor { get; set; }
        /// <summary>
        /// Forcolor for text in Header
        /// </summary>
        string HeaderFontColor { get; set; }
        /// <summary>
        /// URL to the HeaderImage
        /// </summary>
        string HeaderImageSrc { get; set; }
        /// <summary>
        /// Bagroundcolor on hover 
        /// </summary>
        string HoverColor { get; set; }
        /// <summary>
        /// Fontcolor on hover 
        /// </summary>
        string HoverFontColor { get; set; }
        /// <summary>
        /// Displayed in header
        /// </summary>
        string Titel { get; set; }
        /// <summary>
        /// Versionnumber displayed in hamburgermenu
        /// </summary>
        string Version { get; set; }
    }
}