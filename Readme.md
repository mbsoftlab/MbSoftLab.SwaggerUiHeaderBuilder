# MbSoftLab.SwaggerUiHeaderBuilder

Der SwaggerUiHeaderBuilder erstellt einen Spezial-Header für das Swagger Ui
```cs
    public class SwaggerUiHeaderBuilder
    { 
        public SwaggerUiHeaderBuilder();
        public SwaggerUiHeaderBuilder AddCustomLink(string caption, Uri href);
        public SwaggerUiHeaderBuilder ForHeaderBgColor(string value);
        public SwaggerUiHeaderBuilder ForHeaderFontColor(string value);
        public SwaggerUiHeaderBuilder ForHoverBgColor(string value);
        public SwaggerUiHeaderBuilder ForHoverFontColor(string value);
        public SwaggerUiHeaderBuilder ForImageSrc(string value);
        public SwaggerUiHeaderBuilder ForTitel(string value);
        public SwaggerUiHeaderBuilder ForVersion(string value);
        public string Build();
    }
```

## Beispiel: 

```cs 
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

