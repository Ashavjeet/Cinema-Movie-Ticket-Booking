#pragma checksum "C:\Users\ashus\Downloads\MoviesAppProjectFSD\Views\Movie\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2174c7742858cae7b64477e5dd581ee7e2ce577"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_Details), @"mvc.1.0.view", @"/Views/Movie/Details.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\ashus\Downloads\MoviesAppProjectFSD\Views\_ViewImports.cshtml"
using MoviesAppProjectFSD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ashus\Downloads\MoviesAppProjectFSD\Views\_ViewImports.cshtml"
using MoviesAppProjectFSD.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2174c7742858cae7b64477e5dd581ee7e2ce577", @"/Views/Movie/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8478643ac2c1769b3314e57457476915f6a09f43", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MoviesAppProjectFSD.Models.DB.Movie>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cinema", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Producer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Actor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Orders", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddItemToShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ashus\Downloads\MoviesAppProjectFSD\Views\Movie\Details.cshtml"
  
    ViewData["Title"] = "Details";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""row"">
    <div class=""col-md-8 offset-2"">
        <div class=""card mb-12"">
            <div class=""row g-0"">
                <div class=""col-md-12"">
                    <div class=""card-header text-white bg-info"">
                        <p class=""card-text"">
                            <h5 class=""card-title"">
                                ");
#nullable restore
#line 17 "C:\Users\ashus\Downloads\MoviesAppProjectFSD\Views\Movie\Details.cshtml"
                           Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </h5>\r\n                        </p>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-md-4\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 653, "\"", 674, 1);
#nullable restore
#line 23 "C:\Users\ashus\Downloads\MoviesAppProjectFSD\Views\Movie\Details.cshtml"
WriteAttributeValue("", 659, Model.ImageUrl, 659, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"100%\"");
            BeginWriteAttribute("alt", " alt=\"", 688, "\"", 705, 1);
#nullable restore
#line 23 "C:\Users\ashus\Downloads\MoviesAppProjectFSD\Views\Movie\Details.cshtml"
WriteAttributeValue("", 694, Model.Name, 694, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                </div>\r\n                <div class=\"col-md-8\">\r\n                    <div class=\"card-body\">\r\n                        <p class=\"card-text\">");
#nullable restore
#line 27 "C:\Users\ashus\Downloads\MoviesAppProjectFSD\Views\Movie\Details.cshtml"
                                        Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"card-text\">\r\n                            <b>Cinema: </b>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2174c7742858cae7b64477e5dd581ee7e2ce5777918", async() => {
                WriteLiteral("\r\n                                ");
#nullable restore
#line 31 "C:\Users\ashus\Downloads\MoviesAppProjectFSD\Views\Movie\Details.cshtml"
                           Write(Model.Cinema.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 30 "C:\Users\ashus\Downloads\MoviesAppProjectFSD\Views\Movie\Details.cshtml"
                                                                              WriteLiteral(Model.CinemaId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </p>\r\n                        <p class=\"card-text\">\r\n                            <b>Produced by: </b>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2174c7742858cae7b64477e5dd581ee7e2ce57710778", async() => {
                WriteLiteral("\r\n                                ");
#nullable restore
#line 37 "C:\Users\ashus\Downloads\MoviesAppProjectFSD\Views\Movie\Details.cshtml"
                           Write(Model.Producer.FullName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 36 "C:\Users\ashus\Downloads\MoviesAppProjectFSD\Views\Movie\Details.cshtml"
                                                                                WriteLiteral(Model.ProducerId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </p>\r\n\r\n\r\n                        <p class=\"card-text\"><b>Start Date: </b>");
#nullable restore
#line 42 "C:\Users\ashus\Downloads\MoviesAppProjectFSD\Views\Movie\Details.cshtml"
                                                           Write(Model.StartDate.ToString("dd MMM yy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"card-text\"><b>End Date: </b>");
#nullable restore
#line 43 "C:\Users\ashus\Downloads\MoviesAppProjectFSD\Views\Movie\Details.cshtml"
                                                         Write(Model.EndDate.ToString("dd MMM yy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"card-text \">\r\n                            <b>Status: </b>\r\n");
#nullable restore
#line 46 "C:\Users\ashus\Downloads\MoviesAppProjectFSD\Views\Movie\Details.cshtml"
                             if (DateTime.Now >= Model.StartDate && DateTime.Now <= Model.EndDate)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"badge bg-success text-white\">AVAILABLE</span> ");
#nullable restore
#line 48 "C:\Users\ashus\Downloads\MoviesAppProjectFSD\Views\Movie\Details.cshtml"
                                                                                           }
                            else if (DateTime.Now > Model.EndDate)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"badge bg-danger text-white\">EXPIRED</span> ");
#nullable restore
#line 51 "C:\Users\ashus\Downloads\MoviesAppProjectFSD\Views\Movie\Details.cshtml"
                                                                                        }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"badge bg-primary text-white\">UPCOMING</span>");
#nullable restore
#line 54 "C:\Users\ashus\Downloads\MoviesAppProjectFSD\Views\Movie\Details.cshtml"
                                                                                         }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </p>
                        <p class=""card-text"">
                            <b>Actors: </b>
                            <hr />
                            <div class=""row"">
                                <div class=""column text-center"">
                                    <img class=""rounded""");
            BeginWriteAttribute("src", " src=\"", 2744, "\"", 2766, 1);
#nullable restore
#line 61 "C:\Users\ashus\Downloads\MoviesAppProjectFSD\Views\Movie\Details.cshtml"
WriteAttributeValue("", 2750, ViewBag.UrlList, 2750, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"max-width: 150px\" />\r\n                                    <br />\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2174c7742858cae7b64477e5dd581ee7e2ce57716738", async() => {
#nullable restore
#line 63 "C:\Users\ashus\Downloads\MoviesAppProjectFSD\Views\Movie\Details.cshtml"
                                                                                                              Write(ViewBag.ActorName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 63 "C:\Users\ashus\Downloads\MoviesAppProjectFSD\Views\Movie\Details.cshtml"
                                                                                     WriteLiteral(ViewBag.ActorID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </div>



                            </div>
                        </p>

                    </div>
                </div>
                <div class=""col-md-12"">
                    <div class=""card-footer"">
                        <p class=""card-text"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2174c7742858cae7b64477e5dd581ee7e2ce57719723", async() => {
                WriteLiteral("\r\n                                Back to List\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2174c7742858cae7b64477e5dd581ee7e2ce57721064", async() => {
                WriteLiteral("<i class=\"bi bi-cart-plus\"></i> Add to Cart (Price ");
#nullable restore
#line 81 "C:\Users\ashus\Downloads\MoviesAppProjectFSD\Views\Movie\Details.cshtml"
                                                                                                                                         Write(Model.Price.ToString("c"));

#line default
#line hidden
#nullable disable
                WriteLiteral(")");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3495, "btn", 3495, 3, true);
            AddHtmlAttributeValue(" ", 3498, "btn-success", 3499, 12, true);
            AddHtmlAttributeValue(" ", 3510, "text-white", 3511, 11, true);
#nullable restore
#line 79 "C:\Users\ashus\Downloads\MoviesAppProjectFSD\Views\Movie\Details.cshtml"
AddHtmlAttributeValue("  ", 3521, (DateTime.Now > Model.EndDate) ? "disabled" : "", 3523, 51, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 81 "C:\Users\ashus\Downloads\MoviesAppProjectFSD\Views\Movie\Details.cshtml"
                                                                    WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MoviesAppProjectFSD.Models.DB.Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591
