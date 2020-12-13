# MbSoftLab.SwaggerUiHeaderBuilder

*Develop*![BuildFromDevelop](https://github.com/mbsoftlab/SwaggerUiHeaderBuilder/workflows/BuildFromDevelop/badge.svg?branch=develop)[![CodeFactor](https://www.codefactor.io/repository/github/mbsoftlab/mbsoftlab.swaggeruiheaderbuilder/badge/develop)](https://www.codefactor.io/repository/github/mbsoftlab/mbsoftlab.swaggeruiheaderbuilder/overview/develop)

*Master* [![CodeFactor](https://www.codefactor.io/repository/github/mbsoftlab/mbsoftlab.swaggeruiheaderbuilder/badge)](https://www.codefactor.io/repository/github/mbsoftlab/mbsoftlab.swaggeruiheaderbuilder)


Der SwaggerUiHeaderBuilder erstellt einen Spezial-Header für das Swagger Ui
```cs
    public class SwaggerUiHeaderBuilder
    { 
		ISwaggerUiHeaderBuilder AddCustomLink(string caption, Uri href);
		ISwaggerUiHeaderBuilder UseConfig(ISwaggerUiCustomHeaderConfig value);
		ISwaggerUiHeaderBuilder ForHeaderBgColor(string value);
		ISwaggerUiHeaderBuilder ForHeaderFontColor(string value);
		ISwaggerUiHeaderBuilder ForHoverBgColor(string value);
		ISwaggerUiHeaderBuilder ForHoverFontColor(string value);
		ISwaggerUiHeaderBuilder ForImageSrc(string value);
		ISwaggerUiHeaderBuilder ForTitel(string value);
		ISwaggerUiHeaderBuilder ForVersion(string value);
		string Build();
    }
```

## Beispiele: 

### Beispiel 1
```csharp
            app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "MyApi V1");

                    c.UseCustomHeader(header => header
                                          .ForTitel("MyTestTitel")
                                          .ForVersion("v1.0.0.1")
                                          .AddCustomLink("MyCustomLink1", new Uri("https://myCutom1.url"))
                                          .AddCustomLink("MyCustomLink2", new Uri("https://myCutom2.url"))
                                          .ForHeaderBgColor("#fff9f3")
                                          .ForHoverBgColor("#d66b00")
                                          .ForHeaderFontColor("black"));

                });
            }

```

### Beispiel 2
```csharp 
           app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "MyApi V1");
         
                c.HeadContent = new SwaggerUiHeaderBuilder()
                               .ForTitel("MyTestTitel")
                               .ForVersion("v1.0.0.1")
                               .AddCustomLink("MyCustomLink1", new System.Uri("https://myCutom1.url"))
                               .AddCustomLink("MyCustomLink2", new System.Uri("https://myCutom2.url"))
                               .ForHeaderBgColor("#fff9f3")
                               .ForHoverBgColor("#d66b00")
                               .ForHeaderFontColor("black")
                               .Build();
               
            });

```
### Beispiel 3
```csharp 
           app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "MyApi V1");
         
                //Example 3
                c.UseCustomHeader(header => header
                                          .UseConfig(_swaggerUiCustomHeaderConfig)
                                          .AddCustomLink("MyCustomLink1", new Uri("https://myCutom1.url"))
                                          .AddCustomLink("MyCustomLink2", new Uri("https://myCutom2.url")));
               
            });

```
 

