#pragma checksum "C:\Users\trannqt\Desktop\BanHangNetCoreNhom123-backup7\BanHangNetCoreNhom123\BanHangNetCoreNhom123\Views\OrderManager\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a67ef4c509f9a255e1eb32719ec1c3ace64317f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OrderManager_Details), @"mvc.1.0.view", @"/Views/OrderManager/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/OrderManager/Details.cshtml", typeof(AspNetCore.Views_OrderManager_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a67ef4c509f9a255e1eb32719ec1c3ace64317f0", @"/Views/OrderManager/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2df1cb29a3fc06e5d08c4aea44f7cce5fac285bd", @"/Views/_ViewImports.cshtml")]
    public class Views_OrderManager_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BanHangNetCoreNhom123.Models.OderViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "C:\Users\trannqt\Desktop\BanHangNetCoreNhom123-backup7\BanHangNetCoreNhom123\BanHangNetCoreNhom123\Views\OrderManager\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Layout/Admin/Layout.cshtml";

#line default
#line hidden
            BeginContext(150, 287, true);
            WriteLiteral(@"<center><h1>Chi tiết đơn hàng</h1></center>
<div class=""row"" style=""width:50%; height:auto; margin: 0 auto;"">
    <div class=""col-sm-6"">

        <dl class=""row"">
            <dt class=""col-sm-5"">
                Mã tài khoản
            </dt>
            <dd class=""col-sm-7"">
");
            EndContext();
#line 17 "C:\Users\trannqt\Desktop\BanHangNetCoreNhom123-backup7\BanHangNetCoreNhom123\BanHangNetCoreNhom123\Views\OrderManager\Details.cshtml"
                  
                    var t = @Html.DisplayFor(model => model.giohang.MaTaiKhoan);
                    if (t == null)
                    {

#line default
#line hidden
            BeginContext(598, 52, true);
            WriteLiteral("                        <p>Khách hàng vãng lai</p>\r\n");
            EndContext();
#line 22 "C:\Users\trannqt\Desktop\BanHangNetCoreNhom123-backup7\BanHangNetCoreNhom123\BanHangNetCoreNhom123\Views\OrderManager\Details.cshtml"
                    }
                    if (t != null)
                    {

#line default
#line hidden
            BeginContext(732, 27, true);
            WriteLiteral("                        <p>");
            EndContext();
            BeginContext(760, 50, false);
#line 25 "C:\Users\trannqt\Desktop\BanHangNetCoreNhom123-backup7\BanHangNetCoreNhom123\BanHangNetCoreNhom123\Views\OrderManager\Details.cshtml"
                      Write(Html.DisplayFor(model => model.giohang.MaTaiKhoan));

#line default
#line hidden
            EndContext();
            BeginContext(810, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 26 "C:\Users\trannqt\Desktop\BanHangNetCoreNhom123-backup7\BanHangNetCoreNhom123\BanHangNetCoreNhom123\Views\OrderManager\Details.cshtml"
                    }

                

#line default
#line hidden
            BeginContext(860, 151, true);
            WriteLiteral("            </dd>\r\n            <dt class=\"col-sm-5\">\r\n                Tổng cộng\r\n            </dt>\r\n            <dd class=\"col-sm-7\">\r\n                ");
            EndContext();
            BeginContext(1012, 48, false);
#line 34 "C:\Users\trannqt\Desktop\BanHangNetCoreNhom123-backup7\BanHangNetCoreNhom123\BanHangNetCoreNhom123\Views\OrderManager\Details.cshtml"
           Write(Html.DisplayFor(model => model.giohang.TongCong));

#line default
#line hidden
            EndContext();
            BeginContext(1060, 160, true);
            WriteLiteral("<u>đ</u>\r\n            </dd>\r\n            <dt class=\"col-sm-5\">\r\n                Ngày đặt\r\n            </dt>\r\n            <dd class=\"col-sm-7\">\r\n                ");
            EndContext();
            BeginContext(1221, 47, false);
#line 40 "C:\Users\trannqt\Desktop\BanHangNetCoreNhom123-backup7\BanHangNetCoreNhom123\BanHangNetCoreNhom123\Views\OrderManager\Details.cshtml"
           Write(Html.DisplayFor(model => model.giohang.NgayDat));

#line default
#line hidden
            EndContext();
            BeginContext(1268, 154, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-5\">\r\n                Trạng thái\r\n            </dt>\r\n            <dd class=\"col-sm-7\">\r\n                ");
            EndContext();
            BeginContext(1423, 49, false);
#line 46 "C:\Users\trannqt\Desktop\BanHangNetCoreNhom123-backup7\BanHangNetCoreNhom123\BanHangNetCoreNhom123\Views\OrderManager\Details.cshtml"
           Write(Html.DisplayFor(model => model.giohang.TrangThai));

#line default
#line hidden
            EndContext();
            BeginContext(1472, 104, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-5\">\r\n            </dt>\r\n\r\n        </dl>\r\n    </div>\r\n");
            EndContext();
#line 53 "C:\Users\trannqt\Desktop\BanHangNetCoreNhom123-backup7\BanHangNetCoreNhom123\BanHangNetCoreNhom123\Views\OrderManager\Details.cshtml"
       
        double total = 0;
    

#line default
#line hidden
            BeginContext(1619, 526, true);
            WriteLiteral(@"    <div class=""row"">
        <div class=""col-sm-12"">
            <table border=""1"" style=""text-align:center;border:1px solid blue; margin-bottom:20px;"" cellpadding=""17"">
                <thead>
                    <tr>
                        <td>Mã sản phẩm</td>
                        <td>Tên sản phẩm</td>
                        <td>Số lượng</td>
                        <td>Đơn giá</td>
                        <td>Thành tiền</td>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 69 "C:\Users\trannqt\Desktop\BanHangNetCoreNhom123-backup7\BanHangNetCoreNhom123\BanHangNetCoreNhom123\Views\OrderManager\Details.cshtml"
                     foreach (var item in Model.ctgiohangs)
                    {
                        
                            total += Convert.ToDouble(item.thanhtien);
                        

#line default
#line hidden
            BeginContext(2353, 96, true);
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2450, 9, false);
#line 76 "C:\Users\trannqt\Desktop\BanHangNetCoreNhom123-backup7\BanHangNetCoreNhom123\BanHangNetCoreNhom123\Views\OrderManager\Details.cshtml"
                           Write(item.masp);

#line default
#line hidden
            EndContext();
            BeginContext(2459, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2563, 10, false);
#line 79 "C:\Users\trannqt\Desktop\BanHangNetCoreNhom123-backup7\BanHangNetCoreNhom123\BanHangNetCoreNhom123\Views\OrderManager\Details.cshtml"
                           Write(item.tensp);

#line default
#line hidden
            EndContext();
            BeginContext(2573, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2677, 12, false);
#line 82 "C:\Users\trannqt\Desktop\BanHangNetCoreNhom123-backup7\BanHangNetCoreNhom123\BanHangNetCoreNhom123\Views\OrderManager\Details.cshtml"
                           Write(item.soluong);

#line default
#line hidden
            EndContext();
            BeginContext(2689, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2793, 8, false);
#line 85 "C:\Users\trannqt\Desktop\BanHangNetCoreNhom123-backup7\BanHangNetCoreNhom123\BanHangNetCoreNhom123\Views\OrderManager\Details.cshtml"
                           Write(item.gia);

#line default
#line hidden
            EndContext();
            BeginContext(2801, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2905, 14, false);
#line 88 "C:\Users\trannqt\Desktop\BanHangNetCoreNhom123-backup7\BanHangNetCoreNhom123\BanHangNetCoreNhom123\Views\OrderManager\Details.cshtml"
                           Write(item.thanhtien);

#line default
#line hidden
            EndContext();
            BeginContext(2919, 68, true);
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 91 "C:\Users\trannqt\Desktop\BanHangNetCoreNhom123-backup7\BanHangNetCoreNhom123\BanHangNetCoreNhom123\Views\OrderManager\Details.cshtml"
                    }

#line default
#line hidden
            BeginContext(3010, 136, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n    <br />\r\n    <br />\r\n    <div></div>\r\n    <h1>Tổng tiền: ");
            EndContext();
            BeginContext(3147, 29, false);
#line 99 "C:\Users\trannqt\Desktop\BanHangNetCoreNhom123-backup7\BanHangNetCoreNhom123\BanHangNetCoreNhom123\Views\OrderManager\Details.cshtml"
              Write(String.Format("{0:N0}",total));

#line default
#line hidden
            EndContext();
            BeginContext(3176, 31, true);
            WriteLiteral("<u>đ</u></h1>\r\n    <hr />\r\n    ");
            EndContext();
            BeginContext(3207, 112, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a67ef4c509f9a255e1eb32719ec1c3ace64317f012738", async() => {
                BeginContext(3229, 86, true);
                WriteLiteral("<input type=\"button\" class=\"btn btn-primary\" value=\"Trở về\" style=\"margin-top:10px;\"/>");
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
            BeginContext(3319, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BanHangNetCoreNhom123.Models.OderViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591