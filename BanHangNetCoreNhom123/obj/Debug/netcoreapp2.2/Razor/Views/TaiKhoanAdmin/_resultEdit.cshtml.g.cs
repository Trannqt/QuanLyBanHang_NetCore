#pragma checksum "C:\Users\trannqt\Desktop\BanHangNetCoreNhom123-backup7\BanHangNetCoreNhom123\BanHangNetCoreNhom123\Views\TaiKhoanAdmin\_resultEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a05813d0968ccdac1b4ffca64efd13fa68fc8c78"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TaiKhoanAdmin__resultEdit), @"mvc.1.0.view", @"/Views/TaiKhoanAdmin/_resultEdit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TaiKhoanAdmin/_resultEdit.cshtml", typeof(AspNetCore.Views_TaiKhoanAdmin__resultEdit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a05813d0968ccdac1b4ffca64efd13fa68fc8c78", @"/Views/TaiKhoanAdmin/_resultEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2df1cb29a3fc06e5d08c4aea44f7cce5fac285bd", @"/Views/_ViewImports.cshtml")]
    public class Views_TaiKhoanAdmin__resultEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:70px;height:70px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 187, true);
            WriteLiteral("\r\n<div>\r\n    <table class=\"table\">\r\n        <tr>\r\n            <td class=\"col-sm-2\">\r\n                Tên tài khoản\r\n            </td>\r\n            <td class=\"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(188, 28, false);
#line 9 "C:\Users\trannqt\Desktop\BanHangNetCoreNhom123-backup7\BanHangNetCoreNhom123\BanHangNetCoreNhom123\Views\TaiKhoanAdmin\_resultEdit.cshtml"
           Write(ViewBag.TaiKhoan.TenTaiKhoan);

#line default
#line hidden
            EndContext();
            BeginContext(216, 179, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td class=\"col-sm-2\">\r\n                Email\r\n            </td>\r\n            <td class=\"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(396, 22, false);
#line 17 "C:\Users\trannqt\Desktop\BanHangNetCoreNhom123-backup7\BanHangNetCoreNhom123\BanHangNetCoreNhom123\Views\TaiKhoanAdmin\_resultEdit.cshtml"
           Write(ViewBag.TaiKhoan.Email);

#line default
#line hidden
            EndContext();
            BeginContext(418, 188, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n\r\n        <tr>\r\n            <td class=\"col-sm-2\">\r\n                Ảnh đại diện\r\n            </td>\r\n            <td class=\"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(606, 98, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a05813d0968ccdac1b4ffca64efd13fa68fc8c785228", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 616, "~/user/images/khachhang/", 616, 24, true);
#line 26 "C:\Users\trannqt\Desktop\BanHangNetCoreNhom123-backup7\BanHangNetCoreNhom123\BanHangNetCoreNhom123\Views\TaiKhoanAdmin\_resultEdit.cshtml"
AddHtmlAttributeValue("", 640, ViewBag.TaiKhoan.AnhDaiDien, 640, 28, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(704, 184, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td class=\"col-sm-2\">\r\n                Trạng thái\r\n            </td>\r\n            <td class=\"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(889, 29, false);
#line 34 "C:\Users\trannqt\Desktop\BanHangNetCoreNhom123-backup7\BanHangNetCoreNhom123\BanHangNetCoreNhom123\Views\TaiKhoanAdmin\_resultEdit.cshtml"
           Write(ViewBag.TaiKhoan.DangHoatDong);

#line default
#line hidden
            EndContext();
            BeginContext(918, 179, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td class=\"col-sm-2\">\r\n                Quyền\r\n            </td>\r\n            <td class=\"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(1098, 47, false);
#line 42 "C:\Users\trannqt\Desktop\BanHangNetCoreNhom123-backup7\BanHangNetCoreNhom123\BanHangNetCoreNhom123\Views\TaiKhoanAdmin\_resultEdit.cshtml"
           Write(ViewBag.TaiKhoan.MaPhanQuyenNavigation.QuyenHan);

#line default
#line hidden
            EndContext();
            BeginContext(1145, 60, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n\r\n    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591