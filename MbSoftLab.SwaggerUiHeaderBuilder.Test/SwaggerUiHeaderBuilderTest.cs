using NUnit.Framework;
using System.IO;

namespace MbSoftLab.SwaggerUiHeaderBuilder.Test
{
    public class SwaggerUiHeaderBuilderTest
    {
        ISwaggerUiHeaderBuilder _swaggerUiHeaderBuilder;
        [SetUp]
        public void Setup()
        {
            _swaggerUiHeaderBuilder = new SwaggerUiHeaderBuilder();
        }
        [Test]
        public void Can_set_a_titel()
        {
            string titel = "AppTestTitle";
            string htmlheader = _swaggerUiHeaderBuilder
                  .ForTitel(titel)
                  .Build();
            Assert.AreEqual(true, htmlheader.Contains(titel));
        }
        [Test]
        public void Can_set_a_headerImage()
        {
            string imageSrc = "https://api.nuget.org/v3-flatcontainer/mbsoftlab.templateengine.core/1.0.0/icon1";
            string htmlheader = _swaggerUiHeaderBuilder
                  .ForImageSrc(imageSrc)
                  .Build();
            Assert.AreEqual(true, htmlheader.Contains($"src=\"{imageSrc}\""));
        }
        [Test]
        public void Can_set_headerBgColor()
        {
            string headerBgColor = "#12345";
            string htmlheader = _swaggerUiHeaderBuilder
                  .ForHeaderBgColor(headerBgColor)
                  .Build();
            Assert.AreEqual(true, htmlheader.Contains(headerBgColor));
        }
        [Test]
        public void Can_set_headerFontColor()
        {
            string headerFontColor = "#12345";
            string htmlheader = _swaggerUiHeaderBuilder
                  .ForHeaderFontColor(headerFontColor)
                  .Build();
            Assert.AreEqual(true, htmlheader.Contains(headerFontColor));
        }
        [Test]
        public void Can_set_a_version()
        {
            string version = "v1.023.1";
            string htmlheader = _swaggerUiHeaderBuilder
                  .ForVersion(version)
                  .Build();
            Assert.AreEqual(true, htmlheader.Contains(version));
        }
        [Test]
        public void Can_add_custom_links()
        {
            string customLink1Text = "TextOfSpezialLink1";
            string customLink1Url = "https://MyCustomLink1.de/";
            string customLink2Text = "TextOfSpezialLink2";
            string customLink2Url = "https://MyCustomLink2.de/";

            string htmlheader = _swaggerUiHeaderBuilder
                  .AddCustomLink(customLink1Text, new System.Uri(customLink1Url))
                  .AddCustomLink(customLink2Text, new System.Uri(customLink2Url))
                  .Build();
            Assert.AreEqual(true, htmlheader.Contains($"<a href='{customLink1Url}'>{customLink1Text}</a><a href='{customLink2Url}'>{customLink2Text}</a>"));
        }
        [Test]
        public void Can_set_a_hoverBgColor()
        {
            string hovercolor = "#1234";
            string htmlheader = _swaggerUiHeaderBuilder
                  .ForHoverBgColor(hovercolor)
                  .Build();
            Assert.AreEqual(true, htmlheader.Contains(hovercolor));
        }
        [Test]
        public void Can_set_a_BgColor_for_content_dropdown()
        {
            string htmlheader = _swaggerUiHeaderBuilder
                  .ForTitel("MyTestTitel")
                  .ForVersion("v1.0.0.1")
                  .AddCustomLink("MyCustomLink1", new System.Uri("https://myCutom1.url"))
                  .AddCustomLink("MyCustomLink2", new System.Uri("https://myCutom2.url"))
                  .Build();


            Assert.AreEqual(true, htmlheader.Contains(".dropdown-content a:hover {background-color: #c56900; color:white;}"));
        }
        [Test]
        public void Can_create_a_valid_header()
        {
            string htmlheader = _swaggerUiHeaderBuilder
                  .ForTitel("Company.Product.Package")
                  .ForVersion("v1.0.1.0")
                  .ForHeaderBgColor("#fff9f3")
                  .ForHoverBgColor("#d66b00")
                  .ForHeaderFontColor("black")
                  .Build();
            File.WriteAllText("outputHeader.html", htmlheader);
            string sollHeader = File.ReadAllText(Directory.GetCurrentDirectory() + "/SollHeader.html");

            Assert.AreEqual(sollHeader, htmlheader);
        }

        [Test]
        public void Can_use_a_config()
        {
            string htmlheader = _swaggerUiHeaderBuilder
                  .UseConfig(new SwaggerUiCustomHeaderConfig()
                  {
                      Titel = "Company.Product.Package",
                      Version = "v1.0.1.0",
                      HeaderBgColor = "#fff9f3",
                      HoverColor = "#d66b00",
                      HeaderFontColor = "black"
                  }).Build();

            File.WriteAllText("outputHeader.html", htmlheader);
            string sollHeader = File.ReadAllText(Directory.GetCurrentDirectory() + "/SollHeader.html");

            Assert.AreEqual(sollHeader, htmlheader);
        }
    }
}