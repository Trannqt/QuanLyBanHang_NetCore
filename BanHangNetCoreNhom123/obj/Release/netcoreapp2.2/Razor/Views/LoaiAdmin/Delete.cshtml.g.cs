#pragma checksum "C:\Users\trannqt\Desktop\BanHangNetCoreNhom123-backup7\BanHangNetCoreNhom123\BanHangNetCoreNhom123\Views\LoaiAdmin\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8fe242b2153d22f6805a2e82998d08f06399a14c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LoaiAdmin_Delete), @"mvc.1.0.view", @"/Views/LoaiAdmin/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/LoaiAdmin/Delete.cshtml", typeof(AspNetCore.Views_LoaiAdmin_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fe242b2153d22f6805a2e82998d08f06399a14c", @"/Views/LoaiAdmin/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2df1cb29a3fc06e5d08c4aea44f7cce5fac285bd", @"/Views/_ViewImports.cshtml")]
    public class Views_LoaiAdmin_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BanHangNetCoreNhom123.Models.LoaiThucDon>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\trannqt\Desktop\BanHangNetCoreNhom123-backup7\BanHangNetCoreNhom123\BanHangNetCoreNhom123\Views\LoaiAdmin\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Views/Layout/Admin/Layout.cshtml";

#line default
#line hidden
            BeginContext(145, 78, true);
            WriteLiteral("\r\n<h1>Xóa không thành công</h1>\r\n<h4>Vẫn còn sản phẩm thuộc mã loại này</h4>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BanHangNetCoreNhom123.Models.LoaiThucDon> Html { get; private set; }
    }
}
#pragma warning restore 1591
