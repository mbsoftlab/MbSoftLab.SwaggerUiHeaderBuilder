<?xml version="1.0"?>
<doc>
    <assembly>
        <name>MbSoftLab.SwaggerUiHeaderBuilder</name>
    </assembly>
    <members>
        <member name="P:MbSoftLab.SwaggerUiHeaderBuilder.ISwaggerUiCustomHeaderConfig.CustomLinks">
            <summary>
            Html tags for custom links in haburgermenu 
            </summary>
        </member>
        <member name="P:MbSoftLab.SwaggerUiHeaderBuilder.ISwaggerUiCustomHeaderConfig.HeaderBgColor">
            <summary>
            Backgroundcolor for Header
            </summary>
        </member>
        <member name="P:MbSoftLab.SwaggerUiHeaderBuilder.ISwaggerUiCustomHeaderConfig.HeaderFontColor">
            <summary>
            Forcolor for text in Header
            </summary>
        </member>
        <member name="P:MbSoftLab.SwaggerUiHeaderBuilder.ISwaggerUiCustomHeaderConfig.HeaderImageSrc">
            <summary>
            URL to the HeaderImage
            </summary>
        </member>
        <member name="P:MbSoftLab.SwaggerUiHeaderBuilder.ISwaggerUiCustomHeaderConfig.HoverColor">
            <summary>
            Bagroundcolor on hover 
            </summary>
        </member>
        <member name="P:MbSoftLab.SwaggerUiHeaderBuilder.ISwaggerUiCustomHeaderConfig.HoverFontColor">
            <summary>
            Fontcolor on hover 
            </summary>
        </member>
        <member name="P:MbSoftLab.SwaggerUiHeaderBuilder.ISwaggerUiCustomHeaderConfig.Titel">
            <summary>
            Displayed in header
            </summary>
        </member>
        <member name="P:MbSoftLab.SwaggerUiHeaderBuilder.ISwaggerUiCustomHeaderConfig.Version">
            <summary>
            Versionnumber displayed in hamburgermenu
            </summary>
        </member>
        <member name="M:MbSoftLab.SwaggerUiHeaderBuilder.SwaggerUiHeaderBuilder.AddCustomLink(System.String,System.Uri)">
            <summary>
            Add a custom Link to the hamburger menu
            </summary>
            <param name="caption">Visable linkcaption </param>
            <param name="href">URL to customlink</param>
            <returns></returns>
        </member>
        <member name="M:MbSoftLab.SwaggerUiHeaderBuilder.SwaggerUiHeaderBuilder.Build">
             <summary>
             Builds the custom HeadContent as HTML with the specified parameters
             <see cref="M:MbSoftLab.SwaggerUiHeaderBuilder.SwaggerUiOptionsHeadContentExtensions.UseCustomHeader(Swashbuckle.AspNetCore.SwaggerUI.SwaggerUIOptions,System.Action{MbSoftLab.SwaggerUiHeaderBuilder.SwaggerUiHeaderBuilder})"/> 
            </summary>
             <returns>String with HTML Header for </returns>
        </member>
    </members>
</doc>
