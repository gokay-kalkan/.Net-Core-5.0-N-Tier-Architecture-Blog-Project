#pragma checksum "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NETCORE\Blog.UI\Blog.UI\Views\Blog\BlogList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8439da798910475f2b5c2e18ea80b8bd0b36e30"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_BlogList), @"mvc.1.0.view", @"/Views/Blog/BlogList.cshtml")]
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
#line 1 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NETCORE\Blog.UI\Blog.UI\Views\_ViewImports.cshtml"
using Blog.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NETCORE\Blog.UI\Blog.UI\Views\_ViewImports.cshtml"
using Blog.UI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NETCORE\Blog.UI\Blog.UI\Views\_ViewImports.cshtml"
using EntityLayer.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8439da798910475f2b5c2e18ea80b8bd0b36e30", @"/Views/Blog/BlogList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c98b3fefefbb96ef99f9320949ad7d0d22c809bd", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_BlogList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("150"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("150"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BlogDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Blog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("target", new global::Microsoft.AspNetCore.Html.HtmlString("_parent"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("search_form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("gs"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "GET", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NETCORE\Blog.UI\Blog.UI\Views\Blog\BlogList.cshtml"
  
    ViewData["Title"] = "BlogList";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"tr\">\r\n\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8439da798910475f2b5c2e18ea80b8bd0b36e307486", async() => {
                WriteLiteral("\r\n\r\n    <!-- ***** Preloader Start ***** -->\r\n");
                WriteLiteral(@"
    <div class=""heading-page header-text"">
        <section class=""page-heading"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-lg-12"">
                        <div class=""text-content"">
                            <h2>Tüm Bloglar</h2>

                        </div>
                    </div>
                </div>
            </div>
        </section>
    </div>

    <!-- Banner Ends Here -->

    <section class=""call-to-action"">
    </section>


    <section class=""blog-posts grid-system"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-8"">
                    <div class=""all-blog-posts"">
                        <div class=""row"">
");
#nullable restore
#line 50 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NETCORE\Blog.UI\Blog.UI\Views\Blog\BlogList.cshtml"
                             foreach (var item in Model)
                            {



#line default
#line hidden
#nullable disable
                WriteLiteral("                                <div class=\"col-lg-6\">\r\n                                    <div class=\"blog-post\">\r\n                                        <div class=\"blog-thumb\">\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b8439da798910475f2b5c2e18ea80b8bd0b36e309169", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1501, "~/img/", 1501, 6, true);
#nullable restore
#line 57 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NETCORE\Blog.UI\Blog.UI\Views\Blog\BlogList.cshtml"
AddHtmlAttributeValue("", 1507, item.BlogImage, 1507, 15, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                        </div>\r\n                                        <div class=\"down-content\">\r\n                                            <span>");
#nullable restore
#line 60 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NETCORE\Blog.UI\Blog.UI\Views\Blog\BlogList.cshtml"
                                             Write(item.Category.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                                            <a href=\"post-details.html\"><h4>");
#nullable restore
#line 61 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NETCORE\Blog.UI\Blog.UI\Views\Blog\BlogList.cshtml"
                                                                       Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4></a>\r\n                                            <ul class=\"post-info\">\r\n                                                <li><a href=\"#\">");
#nullable restore
#line 63 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NETCORE\Blog.UI\Blog.UI\Views\Blog\BlogList.cshtml"
                                                           Write(item.UserAdmin.FullName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></li>\r\n                                                <li><a href=\"#\">");
#nullable restore
#line 64 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NETCORE\Blog.UI\Blog.UI\Views\Blog\BlogList.cshtml"
                                                           Write(item.BlogDate.ToShortDateString());

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></li>\r\n                                                <li>Blog Puanı</li>\r\n                                                <li><i class=\"fa fa-eye\"></i>");
#nullable restore
#line 66 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NETCORE\Blog.UI\Blog.UI\Views\Blog\BlogList.cshtml"
                                                                        Write(item.ReadCount);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                                            </ul>\r\n");
#nullable restore
#line 68 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NETCORE\Blog.UI\Blog.UI\Views\Blog\BlogList.cshtml"
                                              string metin = System.Text.RegularExpressions.Regex.Replace(item.Description, @"<(.|\n)*?>", string.Empty); 

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <p>\r\n                                            ");
#nullable restore
#line 70 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NETCORE\Blog.UI\Blog.UI\Views\Blog\BlogList.cshtml"
                                       Write(Html.Raw(metin.Substring(0, metin.Substring(0, 50).LastIndexOf(""))));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                                            ... ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8439da798910475f2b5c2e18ea80b8bd0b36e3014000", async() => {
                    WriteLiteral("Devamını Oku");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 72 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NETCORE\Blog.UI\Blog.UI\Views\Blog\BlogList.cshtml"
                                                                                                    WriteLiteral(item.BlogId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                        </p>\r\n                                           \r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 78 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NETCORE\Blog.UI\Blog.UI\Views\Blog\BlogList.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            <div class=""col-lg-12"">
                                <ul class=""page-numbers"">
                                    <li><a href=""#"">1</a></li>
                                    <li class=""active""><a href=""#"">2</a></li>
                                    <li><a href=""#"">3</a></li>
                                    <li><a href=""#""><i class=""fa fa-angle-double-right""></i></a></li>
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-4"">
                    <div class=""sidebar"">
                        <div class=""row"">
                            <div class=""col-lg-12"">
                                <div class=""sidebar-item search"">
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8439da798910475f2b5c2e18ea80b8bd0b36e3017984", async() => {
                    WriteLiteral("\r\n                                        <input type=\"text\" name=\"q\" class=\"searchText\" placeholder=\"type to search...\" autocomplete=\"on\">\r\n                                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                            ");
#nullable restore
#line 100 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NETCORE\Blog.UI\Blog.UI\Views\Blog\BlogList.cshtml"
                       Write(await Component.InvokeAsync("LastThreeBlog"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 101 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NETCORE\Blog.UI\Blog.UI\Views\Blog\BlogList.cshtml"
                       Write(await Component.InvokeAsync("CategoryList"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
                WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591