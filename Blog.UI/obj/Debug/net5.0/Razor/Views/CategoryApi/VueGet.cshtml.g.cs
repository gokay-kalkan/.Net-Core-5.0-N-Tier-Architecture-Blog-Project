#pragma checksum "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NETCORE\Blog.UI\Blog.UI\Views\CategoryApi\VueGet.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9742135988a23e2ccb2803a7b14577c7688569bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CategoryApi_VueGet), @"mvc.1.0.view", @"/Views/CategoryApi/VueGet.cshtml")]
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
#nullable restore
#line 1 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NETCORE\Blog.UI\Blog.UI\Views\CategoryApi\VueGet.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9742135988a23e2ccb2803a7b14577c7688569bb", @"/Views/CategoryApi/VueGet.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c98b3fefefbb96ef99f9320949ad7d0d22c809bd", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_CategoryApi_VueGet : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NETCORE\Blog.UI\Blog.UI\Views\CategoryApi\VueGet.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n <html>\r\n\r\n     ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9742135988a23e2ccb2803a7b14577c7688569bb4681", async() => {
                WriteLiteral("\r\n         ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9742135988a23e2ccb2803a7b14577c7688569bb4948", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n <script src=\"https://cdn.jsdelivr.net/npm/vue/dist/vue.js\"></script>\r\n     ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
     
<div id=""app"">

    <input type=""text"" class=""form-control col-md-4"" v-model=""newCategory""/>
    <button type=""submit"" class=""btn btn-primary"" v-on:click=""create"">Ekle</button>

    <div class=""container mt-5"">
        <div class=""col-md-6"">

           

            <table class=""table table-bordered table table-striped"">
                <tr>
                    <th>Kategori</th>
                    <th>Sil</th>
                    
                </tr>
                <tbody>
                    <tr v-for=""k in kategoriler"">
                        <td>
                            <input v-if=""k==modifiedCategory"" v-model=""modifiedCategory.name"" />
                            <span>{{k.name}}</span>
                        </td>
                        
                        <td>

                           
                             <div v-if=""k==modifiedCategory"">
                                <button class=""btn btn-danger"" v-on:click=""modifiedCategory=null"">İpt");
            WriteLiteral(@"al</button>

                                 <button class=""btn btn-success"" v-on:click=""modified(modifiedCategory)"">Kaydet</button>
                            </div>

                              <div v-else>
                                <button class=""btn btn-danger"" v-on:click=""deleted(k)"">Sil</button>

                                 <button class=""btn btn-warning"" v-on:click=""modifiedCategory=k"">Güncelle</button>
                            </div>

                        </td>
                       
                    </tr>
                </tbody>
            </table>
        </div>
    </div>

</div>



            <script>

                    var app=new Vue({

                        el:'#app',

                        data:{

                            kategoriler:[],
                            newCategory:"""",
                            modifiedCategory:null
                            
                        },
                      

           ");
            WriteLiteral(@"             methods:{

                            listele:function(){

                                fetch(""https://localhost:44362/api/Category"")
                                .then(response=>response.json()).then(data=>{console.log(data); this.kategoriler=data;});
                            },

                            create:function(){
                                var category={name:this.newCategory};
                                fetch(""https://localhost:44362/api/Category"",{

                                method:'POST',
                                headers:{
                                    'Content-Type':""application/json""
                                },

                                body:JSON.stringify(category)

                                }).then(response=>response.json())
                                
                                .then(data=>
                                    {console.log(data);
                                    this");
            WriteLiteral(@".listele();
                                    this.newCategory="""";
                                    }).catch(error=>{console.error('Error',error)});
                            },

                            deleted:function(category){

                                fetch(`https://localhost:44362/api/Category/${category.categoryId}`,{
                                    method:'DELETE',
                                    headers:{
                                        'Content-Type':""application/json""
                                    },
                                })
                                .then(data=>{
                                    console.log(data);

                                    this.listele();
                                }).catch(error=>{console.error('Error',error)});
                            },


                            modified:function(){
                               
                                fetch(""https://localhost:443");
            WriteLiteral(@"62/api/Category"",{

                                method:'PUT',
                                headers:{
                                    'Content-Type':""application/json""
                                },

                                body:JSON.stringify(this.modifiedCategory)

                                }).then(response=>response.json())
                                
                                .then(data=>
                                    {console.log(data);
                                    this.listele();
                                    this.newCategory="""";
                                    }).catch(error=>{console.error('Error',error)});
                            },


                            

                           

                        },



                         created:function(){
                            this.listele();
                        }
                    }); 

        </script>
       
 </html>
");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591