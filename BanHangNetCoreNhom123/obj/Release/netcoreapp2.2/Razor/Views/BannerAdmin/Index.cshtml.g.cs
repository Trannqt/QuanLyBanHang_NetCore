#pragma checksum "C:\Users\trannqt\Desktop\BanHangNetCoreNhom123-backup7\BanHangNetCoreNhom123\BanHangNetCoreNhom123\Views\BannerAdmin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59a0dba8f5b9e6114e927605d83fa282eff1f6d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BannerAdmin_Index), @"mvc.1.0.view", @"/Views/BannerAdmin/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/BannerAdmin/Index.cshtml", typeof(AspNetCore.Views_BannerAdmin_Index))]
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
#line 1 "C:\Users\trannqt\Desktop\BanHangNetCoreNhom123-backup7\BanHangNetCoreNhom123\BanHangNetCoreNhom123\Views\_ViewImports.cshtml"
using BanHangNetCoreNhom123;

#line default
#line hidden
#line 2 "C:\Users\trannqt\Desktop\BanHangNetCoreNhom123-backup7\BanHangNetCoreNhom123\BanHangNetCoreNhom123\Views\_ViewImports.cshtml"
using BanHangNetCoreNhom123.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59a0dba8f5b9e6114e927605d83fa282eff1f6d2", @"/Views/BannerAdmin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2df1cb29a3fc06e5d08c4aea44f7cce5fac285bd", @"/Views/_ViewImports.cshtml")]
    public class Views_BannerAdmin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BanHangNetCoreNhom123.Models.Banner>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:180px;height:60px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\trannqt\Desktop\BanHangNetCoreNhom123-backup7\BanHangNetCoreNhom123\BanHangNetCoreNhom123\Views\BannerAdmin\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Layout/Admin/Layout.cshtml";

#line default
#line hidden
            BeginContext(152, 48, true);
            WriteLiteral("\r\n<h1>Quản lý banner quảng cáo</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(200, 105, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "59a0dba8f5b9e6114e927605d83fa282eff1f6d24957", async() => {
                BeginContext(223, 78, true);
                WriteLiteral("<button class=\"btn btn-primary\"><li class=\"fa fa-plus\"></li> Thêm mới</button>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(305, 556, true);
            WriteLiteral(@"
</p>

<div class=""container text-center"">
    <div class=""row"">
        <div class=""col col-12"">
            <table class=""table"">
                <thead class=""thead-light"">
                    <tr>
                        <th scope=""col"">#</th>
                        <th scope=""col"">Hình ảnh</th>
                        <th scope=""col"">Tiêu đề</th>
                        <th scope=""col"">Nội dung</th>
                        <th scope=""col"">Chức năng</th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 28 "C:\Users\trannqt\Desktop\BanHangNetCoreNhom123-backup7\BanHangNetCoreNhom123\BanHangNetCoreNhom123\Views\BannerAdmin\Index.cshtml"
                      
                        var i = 1;
                        foreach (var item in ViewBag.List)
                        {

#line default
#line hidden
            BeginContext(1008, 106, true);
            WriteLiteral("                                        <tr>\r\n                                            <th scope=\"row\">");
            EndContext();
            BeginContext(1115, 1, false);
#line 33 "C:\Users\trannqt\Desktop\BanHangNetCoreNhom123-backup7\BanHangNetCoreNhom123\BanHangNetCoreNhom123\Views\BannerAdmin\Index.cshtml"
                                                       Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(1116, 59, true);
            WriteLiteral("</th>\r\n                                                <td>");
            EndContext();
            BeginContext(1175, 75, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "59a0dba8f5b9e6114e927605d83fa282eff1f6d27982", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1185, "~/user/images/", 1185, 14, true);
#line 34 "C:\Users\trannqt\Desktop\BanHangNetCoreNhom123-backup7\BanHangNetCoreNhom123\BanHangNetCoreNhom123\Views\BannerAdmin\Index.cshtml"
AddHtmlAttributeValue("", 1199, item.UrlBanner, 1199, 15, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1250, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(1310, 11, false);
#line 35 "C:\Users\trannqt\Desktop\BanHangNetCoreNhom123-backup7\BanHangNetCoreNhom123\BanHangNetCoreNhom123\Views\BannerAdmin\Index.cshtml"
                                               Write(item.TieuDe);

#line default
#line hidden
            EndContext();
            BeginContext(1321, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(1381, 12, false);
#line 36 "C:\Users\trannqt\Desktop\BanHangNetCoreNhom123-backup7\BanHangNetCoreNhom123\BanHangNetCoreNhom123\Views\BannerAdmin\Index.cshtml"
                                               Write(item.NoiDung);

#line default
#line hidden
            EndContext();
            BeginContext(1393, 154, true);
            WriteLiteral("</td>\r\n                                            <td>\r\n                                               <button class=\"btn btn-primary thongtin\" data-id=\"");
            EndContext();
            BeginContext(1548, 13, false);
#line 38 "C:\Users\trannqt\Desktop\BanHangNetCoreNhom123-backup7\BanHangNetCoreNhom123\BanHangNetCoreNhom123\Views\BannerAdmin\Index.cshtml"
                                                                                            Write(item.MaBanner);

#line default
#line hidden
            EndContext();
            BeginContext(1561, 224, true);
            WriteLiteral("\" data-toggle=\"modal\" data-target=\"#exampleModal\"><i class=\"fa fa-info\" aria-hidden=\"true\"></i></button>\r\n                                                <button class=\"btn btn-danger Xoane\" data-toggle=\"modal\" data-target=\"");
            EndContext();
            BeginContext(1786, 46, false);
#line 39 "C:\Users\trannqt\Desktop\BanHangNetCoreNhom123-backup7\BanHangNetCoreNhom123\BanHangNetCoreNhom123\Views\BannerAdmin\Index.cshtml"
                                                                                                                 Write(String.Concat("#exampleModal1",@item.MaBanner));

#line default
#line hidden
            EndContext();
            BeginContext(1832, 236, true);
            WriteLiteral("\">\r\n                                                    <i class=\"fa fa-times\" aria-hidden=\"true\"></i>\r\n                                                </button>\r\n\r\n                                                <div class=\"modal fade\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2068, "\"", 2119, 1);
#line 43 "C:\Users\trannqt\Desktop\BanHangNetCoreNhom123-backup7\BanHangNetCoreNhom123\BanHangNetCoreNhom123\Views\BannerAdmin\Index.cshtml"
WriteAttributeValue("", 2073, String.Concat("exampleModal1",@item.MaBanner), 2073, 46, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2120, 1448, true);
            WriteLiteral(@" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel1"" aria-hidden=""true"">
                                                    <div class=""modal-dialog"" role=""document"">
                                                        <div class=""modal-content"">
                                                            <div class=""modal-header"">
                                                                <h5 class=""modal-title"" id=""exampleModalLabel"" style=""text-align:center"">Xóa Banner</h5>
                                                                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                                                    <span aria-hidden=""true"">&times;</span>
                                                                </button>
                                                            </div>
                                                            <div class=""modal-body"">
                                  ");
            WriteLiteral(@"                              Bạn có muốn xóa không ?
                                                            </div>
                                                            <div class=""modal-footer"">
                                                                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                                                                ");
            EndContext();
            BeginContext(3568, 116, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "59a0dba8f5b9e6114e927605d83fa282eff1f6d214282", async() => {
                BeginContext(3621, 59, true);
                WriteLiteral(" <button type=\"button\" class=\"btn btn-primary\">Xóa</button>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 57 "C:\Users\trannqt\Desktop\BanHangNetCoreNhom123-backup7\BanHangNetCoreNhom123\BanHangNetCoreNhom123\Views\BannerAdmin\Index.cshtml"
                                                                                         WriteLiteral(item.MaBanner);

#line default
#line hidden
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
            EndContext();
            BeginContext(3684, 348, true);
            WriteLiteral(@"
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </td>
                                        </tr>
");
            EndContext();
#line 64 "C:\Users\trannqt\Desktop\BanHangNetCoreNhom123-backup7\BanHangNetCoreNhom123\BanHangNetCoreNhom123\Views\BannerAdmin\Index.cshtml"
                            i++;
                        }
                    

#line default
#line hidden
            BeginContext(4116, 968, true);
            WriteLiteral(@"
                </tbody>
            </table>
        </div>
    </div>
</div>
<div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"" style=""text-align:center"">Thông Tin Banner</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <div id=""result"">

                </div>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
            </div>
        </div>
    </div>
</div>
");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BanHangNetCoreNhom123.Models.Banner>> Html { get; private set; }
    }
}
#pragma warning restore 1591