#pragma checksum "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NETCORE\Blog.UI\Blog.UI\Areas\Admin\Views\Istatistic\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "237c47ef0856de673b60c9803857bb6f9953173a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Istatistic_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Istatistic/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"237c47ef0856de673b60c9803857bb6f9953173a", @"/Areas/Admin/Views/Istatistic/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e48c9cefece5f5c700616187a1cc83c552307b8", @"/Areas/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Istatistic_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NETCORE\Blog.UI\Blog.UI\Areas\Admin\Views\Istatistic\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <div class=""row"">

        <div class=""card bg-warning mb-3 col-md-3"" style=""max-width: 18rem; margin-left:10px;"">
            <div class=""card-header"">En Çok Puanı Olan Blog</div>
            <div class=""card-body text-primary"">
");
#nullable restore
#line 13 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NETCORE\Blog.UI\Blog.UI\Areas\Admin\Views\Istatistic\Index.cshtml"
                 foreach (var item in ViewBag.blogratingencok)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p class=\"card-text text-white\">\r\n                        ");
#nullable restore
#line 16 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NETCORE\Blog.UI\Blog.UI\Areas\Admin\Views\Istatistic\Index.cshtml"
                   Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n");
#nullable restore
#line 18 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NETCORE\Blog.UI\Blog.UI\Areas\Admin\Views\Istatistic\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n\r\n        <div class=\"card bg-warning mb-3 col-md-3\" style=\"max-width: 18rem; margin-left:10px;\">\r\n            <div class=\"card-header\">En Az Puanı Olan Blog</div>\r\n            <div class=\"card-body text-primary\">\r\n");
#nullable restore
#line 27 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NETCORE\Blog.UI\Blog.UI\Areas\Admin\Views\Istatistic\Index.cshtml"
                 foreach (var item in ViewBag.blogratingenaz)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p class=\"card-text text-white\">\r\n                        ");
#nullable restore
#line 30 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NETCORE\Blog.UI\Blog.UI\Areas\Admin\Views\Istatistic\Index.cshtml"
                   Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n");
#nullable restore
#line 32 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NETCORE\Blog.UI\Blog.UI\Areas\Admin\Views\Istatistic\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
        </div>


        <div class=""card bg-warning mb-3 col-md-3"" style=""max-width: 18rem; margin-left:10px;"">
            <div class=""card-header"">En Çok Yorumu Olan Blog</div>
            <div class=""card-body text-primary"">
              
                    <p class=""card-text text-white"">
                        ");
#nullable restore
#line 43 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NETCORE\Blog.UI\Blog.UI\Areas\Admin\Views\Istatistic\Index.cshtml"
                   Write(ViewBag.comemntencok);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </p>
                

            </div>
        </div>


        <div class=""card bg-warning mb-3 col-md-3"" style=""max-width: 18rem; margin-left:10px;"">
            <div class=""card-header"">En Az Yorumu Olan Blog</div>
            <div class=""card-body text-primary"">
               
                    <p class=""card-text text-white"">
                        ");
#nullable restore
#line 56 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NETCORE\Blog.UI\Blog.UI\Areas\Admin\Views\Istatistic\Index.cshtml"
                   Write(ViewBag.comemntenaz);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </p>
                

            </div>
        </div>

        <div class=""card bg-warning mb-3 col-md-3"" style=""max-width: 18rem; margin-left:10px;"">
            <div class=""card-header"">En Çok Blogu Olan Kategori</div>
            <div class=""card-body text-primary"">
                
                    <p class=""card-text text-white"">
                        ");
#nullable restore
#line 68 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NETCORE\Blog.UI\Blog.UI\Areas\Admin\Views\Istatistic\Index.cshtml"
                   Write(ViewBag.categoryblog);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </p>
                

            </div>
        </div>


        <div class=""card bg-warning mb-3 col-md-3"" style=""max-width: 18rem; margin-left:10px;"">
            <div class=""card-header"">En Çok görüntülenen blog</div>
            <div class=""card-body text-primary"">
               
                    <p class=""card-text text-white"">
                        ");
#nullable restore
#line 81 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NETCORE\Blog.UI\Blog.UI\Areas\Admin\Views\Istatistic\Index.cshtml"
                   Write(ViewBag.blogreadcount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </p>
                

            </div>
        </div>

        <div class=""card bg-warning mb-3 col-md-3"" style=""max-width: 18rem; margin-left:10px;"">
            <div class=""card-header"">Blog Sayısı</div>
            <div class=""card-body text-primary"">
                
                    <p class=""card-text text-white"">
                        ");
#nullable restore
#line 93 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NETCORE\Blog.UI\Blog.UI\Areas\Admin\Views\Istatistic\Index.cshtml"
                   Write(ViewBag.blogcount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </p>
                

            </div>
        </div>


        <div class=""card bg-warning mb-3 col-md-3"" style=""max-width: 18rem; margin-left:10px;"">
            <div class=""card-header"">Kategori Sayısı</div>
            <div class=""card-body text-primary"">
               
                    <p class=""card-text text-white"">
                        ");
#nullable restore
#line 106 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NETCORE\Blog.UI\Blog.UI\Areas\Admin\Views\Istatistic\Index.cshtml"
                   Write(ViewBag.categorycount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </p>
                

            </div>
        </div>


        <div class=""card bg-warning mb-3 col-md-3"" style=""max-width: 18rem; margin-left:10px;"">
            <div class=""card-header"">Yorum Sayısı</div>
            <div class=""card-body text-primary"">
                   <p class=""card-text text-white"">
                        ");
#nullable restore
#line 118 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NETCORE\Blog.UI\Blog.UI\Areas\Admin\Views\Istatistic\Index.cshtml"
                   Write(ViewBag.commentcount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </p>
                

            </div>
        </div>


        <div class=""card bg-warning mb-3 col-md-3"" style=""max-width: 18rem; margin-left:10px;"">
            <div class=""card-header"">Yazar Sayısı</div>
            <div class=""card-body text-primary"">
               
                    <p class=""card-text text-white"">
                        ");
#nullable restore
#line 131 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NETCORE\Blog.UI\Blog.UI\Areas\Admin\Views\Istatistic\Index.cshtml"
                   Write(ViewBag.authorcount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                \r\n\r\n            </div>\r\n        </div>\r\n\r\n\r\n\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
