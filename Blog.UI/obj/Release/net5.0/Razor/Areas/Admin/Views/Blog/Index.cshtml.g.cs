#pragma checksum "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NETCORE\Blog.UI\Blog.UI\Areas\Admin\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "130cb5c905dc491c6b5f198775a20060d6a70ccf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Blog_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Blog/Index.cshtml")]
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
#line 1 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NETCORE\Blog.UI\Blog.UI\Areas\_ViewImports.cshtml"
using Blog.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NETCORE\Blog.UI\Blog.UI\Areas\_ViewImports.cshtml"
using Blog.UI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NETCORE\Blog.UI\Blog.UI\Areas\_ViewImports.cshtml"
using EntityLayer.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NETCORE\Blog.UI\Blog.UI\Areas\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NETCORE\Blog.UI\Blog.UI\Areas\_ViewImports.cshtml"
using Blog.UI.Areas.Author.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NETCORE\Blog.UI\Blog.UI\Areas\_ViewImports.cshtml"
using Blog.UI.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"130cb5c905dc491c6b5f198775a20060d6a70ccf", @"/Areas/Admin/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e48c9cefece5f5c700616187a1cc83c552307b8", @"/Areas/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("70"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("70"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NETCORE\Blog.UI\Blog.UI\Areas\Admin\Views\Blog\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NETCORE\Blog.UI\Blog.UI\Areas\Admin\Views\Blog\Index.cshtml"
   
    string success = "bg-success";
    string danger = "bg-danger";
    string warning = "bg-warning";
    int puan;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 14 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NETCORE\Blog.UI\Blog.UI\Areas\Admin\Views\Blog\Index.cshtml"
 if (Model.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""col-md-6"">
                    <div class=""alert alert-success"">Henüz herhangi bir blog eklenmedi.</div>
                </div>
            </div>
        </div>
    </div>
");
#nullable restore
#line 25 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NETCORE\Blog.UI\Blog.UI\Areas\Admin\Views\Blog\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table");
            BeginWriteAttribute("id", " id=\"", 544, "\"", 549, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""display"" style=""width:100%"">
        <thead>
            <tr>
                <th>Blog Resmi</th>
                <th>Blog Adı</th>
                <th>Açıklama</th>
                <th>Tarih</th>
                <th>Kategori</th>
                <th>Sil</th>
                <th>Güncelle</th>
               <th>Paunı</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 42 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NETCORE\Blog.UI\Blog.UI\Areas\Admin\Views\Blog\Index.cshtml"
             foreach (var item in Model)
            {
                puan = item.Rating * 20;

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "130cb5c905dc491c6b5f198775a20060d6a70ccf8319", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1094, "~/img/", 1094, 6, true);
#nullable restore
#line 46 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NETCORE\Blog.UI\Blog.UI\Areas\Admin\Views\Blog\Index.cshtml"
AddHtmlAttributeValue("", 1100, item.BlogImage, 1100, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 47 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NETCORE\Blog.UI\Blog.UI\Areas\Admin\Views\Blog\Index.cshtml"
               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 48 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NETCORE\Blog.UI\Blog.UI\Areas\Admin\Views\Blog\Index.cshtml"
               Write(Html.Raw(item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <th>");
#nullable restore
#line 49 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NETCORE\Blog.UI\Blog.UI\Areas\Admin\Views\Blog\Index.cshtml"
               Write(item.BlogDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 50 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NETCORE\Blog.UI\Blog.UI\Areas\Admin\Views\Blog\Index.cshtml"
               Write(item.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                <td><a class=\"btn btn-danger\" id=\"delete\" data-id=\"");
#nullable restore
#line 52 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NETCORE\Blog.UI\Blog.UI\Areas\Admin\Views\Blog\Index.cshtml"
                                                              Write(item.BlogId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Sil</a></td>\r\n                <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "130cb5c905dc491c6b5f198775a20060d6a70ccf11532", async() => {
                WriteLiteral("Güncelle");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 53 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NETCORE\Blog.UI\Blog.UI\Areas\Admin\Views\Blog\Index.cshtml"
                                                                     WriteLiteral(item.BlogId);

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
            WriteLiteral("</td>\r\n");
#nullable restore
#line 54 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NETCORE\Blog.UI\Blog.UI\Areas\Admin\Views\Blog\Index.cshtml"
                 if (puan == 100)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>\r\n                        <small>");
#nullable restore
#line 57 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NETCORE\Blog.UI\Blog.UI\Areas\Admin\Views\Blog\Index.cshtml"
                          Write(puan);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                        <div class=\"progress\">\r\n                            <div");
            BeginWriteAttribute("class", " class=\"", 1764, "\"", 1814, 3);
            WriteAttributeValue("", 1772, "progress-bar", 1772, 12, true);
            WriteAttributeValue(" ", 1784, "progress-bar-striped", 1785, 21, true);
#nullable restore
#line 59 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NETCORE\Blog.UI\Blog.UI\Areas\Admin\Views\Blog\Index.cshtml"
WriteAttributeValue(" ", 1805, success, 1806, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"progressbar\"");
            BeginWriteAttribute("style", " style=\"", 1834, "\"", 1855, 3);
            WriteAttributeValue("", 1842, "width:", 1842, 6, true);
#nullable restore
#line 59 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NETCORE\Blog.UI\Blog.UI\Areas\Admin\Views\Blog\Index.cshtml"
WriteAttributeValue(" ", 1848, puan, 1849, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1854, "%", 1854, 1, true);
            EndWriteAttribute();
            WriteLiteral(" aria-valuenow=\"100\" aria-valuemin=\"0\" aria-valuemax=\"100\"></div>\r\n                        </div>\r\n\r\n                    </td>\r\n");
#nullable restore
#line 63 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NETCORE\Blog.UI\Blog.UI\Areas\Admin\Views\Blog\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 65 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NETCORE\Blog.UI\Blog.UI\Areas\Admin\Views\Blog\Index.cshtml"
                 if (puan == 80 ||puan==60)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>\r\n                <small>");
#nullable restore
#line 68 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NETCORE\Blog.UI\Blog.UI\Areas\Admin\Views\Blog\Index.cshtml"
                  Write(puan);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                <div class=\"progress\">\r\n                    <div");
            BeginWriteAttribute("class", " class=\"", 2189, "\"", 2239, 3);
            WriteAttributeValue("", 2197, "progress-bar", 2197, 12, true);
            WriteAttributeValue(" ", 2209, "progress-bar-striped", 2210, 21, true);
#nullable restore
#line 70 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NETCORE\Blog.UI\Blog.UI\Areas\Admin\Views\Blog\Index.cshtml"
WriteAttributeValue(" ", 2230, warning, 2231, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"progressbar\"");
            BeginWriteAttribute("style", " style=\"", 2259, "\"", 2280, 3);
            WriteAttributeValue("", 2267, "width:", 2267, 6, true);
#nullable restore
#line 70 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NETCORE\Blog.UI\Blog.UI\Areas\Admin\Views\Blog\Index.cshtml"
WriteAttributeValue(" ", 2273, puan, 2274, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2279, "%", 2279, 1, true);
            EndWriteAttribute();
            WriteLiteral(" aria-valuenow=\"100\" aria-valuemin=\"0\" aria-valuemax=\"100\"></div>\r\n                </div>\r\n\r\n            </td>\r\n");
#nullable restore
#line 74 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NETCORE\Blog.UI\Blog.UI\Areas\Admin\Views\Blog\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n              \r\n\r\n");
#nullable restore
#line 78 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NETCORE\Blog.UI\Blog.UI\Areas\Admin\Views\Blog\Index.cshtml"
                 if (puan == 40 || puan==20)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>\r\n                <small>");
#nullable restore
#line 81 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NETCORE\Blog.UI\Blog.UI\Areas\Admin\Views\Blog\Index.cshtml"
                  Write(puan);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                <div class=\"progress\">\r\n                    <div");
            BeginWriteAttribute("class", " class=\"", 2617, "\"", 2666, 3);
            WriteAttributeValue("", 2625, "progress-bar", 2625, 12, true);
            WriteAttributeValue(" ", 2637, "progress-bar-striped", 2638, 21, true);
#nullable restore
#line 83 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NETCORE\Blog.UI\Blog.UI\Areas\Admin\Views\Blog\Index.cshtml"
WriteAttributeValue(" ", 2658, danger, 2659, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"progressbar\"");
            BeginWriteAttribute("style", " style=\"", 2686, "\"", 2707, 3);
            WriteAttributeValue("", 2694, "width:", 2694, 6, true);
#nullable restore
#line 83 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NETCORE\Blog.UI\Blog.UI\Areas\Admin\Views\Blog\Index.cshtml"
WriteAttributeValue(" ", 2700, puan, 2701, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2706, "%", 2706, 1, true);
            EndWriteAttribute();
            WriteLiteral(" aria-valuenow=\"100\" aria-valuemin=\"0\" aria-valuemax=\"100\"></div>\r\n                </div>\r\n\r\n            </td>\r\n");
#nullable restore
#line 87 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NETCORE\Blog.UI\Blog.UI\Areas\Admin\Views\Blog\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </tr>\r\n");
#nullable restore
#line 90 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NETCORE\Blog.UI\Blog.UI\Areas\Admin\Views\Blog\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </tbody>
        <tfoot>
            <tr>
                <th>Blog Resmi</th>
                <th>Blog Adı</th>
                <th>Açıklama</th>
                <th>Tarih</th>
                <th>Kategori</th>
                <th>Sil</th>
                <th>Güncelle</th>
            </tr>
        </tfoot>
    </table>
");
#nullable restore
#line 105 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NETCORE\Blog.UI\Blog.UI\Areas\Admin\Views\Blog\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<br />\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "130cb5c905dc491c6b5f198775a20060d6a70ccf20937", async() => {
                WriteLiteral("Ekle");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>
    $(document).ready(function () {
        $('table.display').DataTable({
            ""language"": {
                ""url"": ""//cdn.datatables.net/plug-ins/9dcbecd42ad/i18n/Turkish.json""
            }

        });
        
    });
</script>


<script type=""text/javascript"">
    $(""table.display"").on(""click"", ""#delete"", function () {
        var id = $(this).data(""id"");

        swal({
            title: ""Blog Silinecek!"",
            text: ""Bu blog silinecek gerçekten silmek istediğinize emin misinz?"",
            icon: ""warning"",
            buttons: true,
            dangerMode: true,
        })
            .then((willDelete) => {
                if (willDelete) {

                    $.ajax({
                        type: 'GET',
                        url: '/Admin/Blog/Delete/' + id,
                        success: function () {
                            toastr.error(""Blog silme işlemi başarıyla gerçekleşti"");
                        }
                    });
            WriteLiteral("\n\r\n                    $(this).parent(\"td\").parent(\"tr\").remove();\r\n\r\n                }\r\n            });\r\n\r\n\r\n    });\r\n</script>");
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