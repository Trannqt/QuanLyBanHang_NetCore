#pragma checksum "C:\Users\trannqt\Desktop\BanHangNetCoreNhom123-backup7\BanHangNetCoreNhom123\BanHangNetCoreNhom123\Views\Checkout\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2e5f72559167d472abc80a1e7c382bb77c37bcf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Checkout_Index), @"mvc.1.0.view", @"/Views/Checkout/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Checkout/Index.cshtml", typeof(AspNetCore.Views_Checkout_Index))]
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
#line 1 "C:\Users\trannqt\Desktop\BanHangNetCoreNhom123-backup7\BanHangNetCoreNhom123\BanHangNetCoreNhom123\Views\Checkout\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2e5f72559167d472abc80a1e7c382bb77c37bcf", @"/Views/Checkout/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2df1cb29a3fc06e5d08c4aea44f7cce5fac285bd", @"/Views/_ViewImports.cshtml")]
    public class Views_Checkout_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\trannqt\Desktop\BanHangNetCoreNhom123-backup7\BanHangNetCoreNhom123\BanHangNetCoreNhom123\Views\Checkout\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Layout/User/Layout.cshtml";

#line default
#line hidden
            BeginContext(126, 644, true);
            WriteLiteral(@"
<div style=""background:#ffff;padding-top:30px;padding-bottom:30px;"">
    <section class=""generic-banner relative"">
        <div class=""container"">
            <div class=""row height align-items-center justify-content-center"">
                <div class=""col-lg-10"">
                    <div class=""generic-banner-content"">
                        <h2 class=""text-white"">THANH TO??N</h2>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- End banner Area -->
    <!-- About Generic Start -->

    <div class=""main-wrapper"">
        <div class=""container checkout-area"">
");
            EndContext();
#line 24 "C:\Users\trannqt\Desktop\BanHangNetCoreNhom123-backup7\BanHangNetCoreNhom123\BanHangNetCoreNhom123\Views\Checkout\Index.cshtml"
             if (ViewBag.Success != null)
            {
                if (ViewBag.Success == true)
                {

#line default
#line hidden
            BeginContext(893, 154, true);
            WriteLiteral("                    <div class=\"alert alert-success\" role=\"alert\">\r\n                        ????n h??ng c???a b???n ???? ???????c g???i ??i.\r\n                    </div>\r\n");
            EndContext();
#line 31 "C:\Users\trannqt\Desktop\BanHangNetCoreNhom123-backup7\BanHangNetCoreNhom123\BanHangNetCoreNhom123\Views\Checkout\Index.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(1107, 167, true);
            WriteLiteral("                    <div class=\"alert alert-danger\" role=\"alert\">\r\n                        Gi??? h??ng ??ang tr???ng. B???n kh??ng th??? thanh to??n.\r\n                    </div>\r\n");
            EndContext();
#line 37 "C:\Users\trannqt\Desktop\BanHangNetCoreNhom123-backup7\BanHangNetCoreNhom123\BanHangNetCoreNhom123\Views\Checkout\Index.cshtml"
                }

            }

#line default
#line hidden
            BeginContext(1310, 12, true);
            WriteLiteral("            ");
            EndContext();
#line 40 "C:\Users\trannqt\Desktop\BanHangNetCoreNhom123-backup7\BanHangNetCoreNhom123\BanHangNetCoreNhom123\Views\Checkout\Index.cshtml"
             if (Context.Session.GetString("USERNAME_SESSION") == null && ViewBag.Success == null)
            {


#line default
#line hidden
            BeginContext(1427, 107, true);
            WriteLiteral("                <div class=\"alert alert-info\" role=\"alert\">\r\n                    N???u b???n c?? t??i kho???n. H??y ");
            EndContext();
            BeginContext(1534, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2e5f72559167d472abc80a1e7c382bb77c37bcf7992", async() => {
                BeginContext(1579, 9, true);
                WriteLiteral("????ng nh???p");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1592, 59, true);
            WriteLiteral(" ????? c?? th??? xem th??ng tin ????n h??ng\r\n                </div>\r\n");
            EndContext();
#line 46 "C:\Users\trannqt\Desktop\BanHangNetCoreNhom123-backup7\BanHangNetCoreNhom123\BanHangNetCoreNhom123\Views\Checkout\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1666, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(1674, 4599, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2e5f72559167d472abc80a1e7c382bb77c37bcf9928", async() => {
                BeginContext(1728, 38, true);
                WriteLiteral("\r\n            <input name=\"account_id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1766, "\"", 1814, 1);
#line 48 "C:\Users\trannqt\Desktop\BanHangNetCoreNhom123-backup7\BanHangNetCoreNhom123\BanHangNetCoreNhom123\Views\Checkout\Index.cshtml"
WriteAttributeValue("", 1774, Context.Session.GetString("ID_SESSION"), 1774, 40, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1815, 1432, true);
                WriteLiteral(@" hidden />
            <div class=""form-field"">
                <h5 for=""fullname"" style=""text-align: left"">
                    H??? t??n
                    <abbr title=""required"" class=""required"">*</abbr>
                </h5>
                <br />
                <input type=""text"" name=""fullname"" id=""fullname"" class=""form-control"">
            </div>
            <br />
            <div class=""form-field"">
                <h5 for=""address"" style=""text-align: left"">
                    ?????a ch???
                    <abbr title=""required"" class=""required"">*</abbr>
                </h5>
                <br />
                <input type=""text"" name=""address"" id=""address"" class=""form-control"">
            </div>
            <br />
            <div class=""form-field"">
                <h5 for=""email"" style=""text-align: left"">
                    Email
                    <abbr title=""required"" class=""required"">*</abbr>
                </h5>
                <br />
                <input type");
                WriteLiteral(@"=""text"" name=""email"" id=""email"" class=""form-control"">
            </div>
            <br />
            <div class=""form-field"">
                <h5 for=""city"" style=""text-align: left"">
                    Th??nh ph???
                    <abbr title=""required"" class=""required"">*</abbr>
                </h5>
                <br />
                <select name=""city"" id=""city"" class=""form-control"">
");
                EndContext();
#line 83 "C:\Users\trannqt\Desktop\BanHangNetCoreNhom123-backup7\BanHangNetCoreNhom123\BanHangNetCoreNhom123\Views\Checkout\Index.cshtml"
                     foreach (var city in ViewBag.City)
                    {

#line default
#line hidden
                BeginContext(3327, 24, true);
                WriteLiteral("                        ");
                EndContext();
                BeginContext(3351, 61, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2e5f72559167d472abc80a1e7c382bb77c37bcf12770", async() => {
                    BeginContext(3386, 17, false);
#line 85 "C:\Users\trannqt\Desktop\BanHangNetCoreNhom123-backup7\BanHangNetCoreNhom123\BanHangNetCoreNhom123\Views\Checkout\Index.cshtml"
                                                     Write(city.TenTinhThanh);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 85 "C:\Users\trannqt\Desktop\BanHangNetCoreNhom123-backup7\BanHangNetCoreNhom123\BanHangNetCoreNhom123\Views\Checkout\Index.cshtml"
                           WriteLiteral(city.MaTinhThanh);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3412, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 86 "C:\Users\trannqt\Desktop\BanHangNetCoreNhom123-backup7\BanHangNetCoreNhom123\BanHangNetCoreNhom123\Views\Checkout\Index.cshtml"
                    }

#line default
#line hidden
                BeginContext(3437, 1239, true);
                WriteLiteral(@"                </select>
            </div>
            <br />
            <div class=""form-field"">
                <h5 for=""email"" style=""text-align: left"">
                    S??? ??i???n tho???i
                    <abbr title=""required"" class=""required"">*</abbr>
                </h5>
                <br />
                <input type=""text"" name=""tel"" id=""email"" class=""form-control"">
            </div>
            <br />
            <div class=""form-field"">
                <h5 for=""email"" style=""text-align: left"">
                    Ghi ch?? ?????t h??ng
                </h5>
                <br />
                <textarea name="""" id="""" cols=""30"" rows=""5"" class=""form-control"" placeholder=""Ghi ch?? v??? ????n ?????t h??ng""></textarea>
            </div>
            <br />
            <div class=""form-field cart-checkout"">
                <h5>????n h??ng c???a b???n</h5>
                <br />
                <table class=""table"" style=""font-size:18px;"">
                    <thead>
                        ");
                WriteLiteral("<tr>\r\n                            <th scope=\"col\">S???n ph???m</th>\r\n                            <th scope=\"col\">T???ng c???ng</th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
                EndContext();
#line 118 "C:\Users\trannqt\Desktop\BanHangNetCoreNhom123-backup7\BanHangNetCoreNhom123\BanHangNetCoreNhom123\Views\Checkout\Index.cshtml"
                         if (ViewBag.Cart != null)
                        {
                            foreach (var item in ViewBag.Cart)
                            {

#line default
#line hidden
                BeginContext(4850, 90, true);
                WriteLiteral("                                <tr>\r\n                                    <td scope=\"row\">");
                EndContext();
                BeginContext(4941, 15, false);
#line 123 "C:\Users\trannqt\Desktop\BanHangNetCoreNhom123-backup7\BanHangNetCoreNhom123\BanHangNetCoreNhom123\Views\Checkout\Index.cshtml"
                                               Write(item.TenThucDon);

#line default
#line hidden
                EndContext();
                BeginContext(4956, 3, true);
                WriteLiteral(" x ");
                EndContext();
                BeginContext(4960, 12, false);
#line 123 "C:\Users\trannqt\Desktop\BanHangNetCoreNhom123-backup7\BanHangNetCoreNhom123\BanHangNetCoreNhom123\Views\Checkout\Index.cshtml"
                                                                  Write(item.SoLuong);

#line default
#line hidden
                EndContext();
                BeginContext(4972, 48, true);
                WriteLiteral("</td>\r\n                                    <td>$");
                EndContext();
                BeginContext(5021, 36, false);
#line 124 "C:\Users\trannqt\Desktop\BanHangNetCoreNhom123-backup7\BanHangNetCoreNhom123\BanHangNetCoreNhom123\Views\Checkout\Index.cshtml"
                                    Write(string.Format("{0:N2}", item.GiaBan));

#line default
#line hidden
                EndContext();
                BeginContext(5057, 46, true);
                WriteLiteral("</td>\r\n                                </tr>\r\n");
                EndContext();
#line 126 "C:\Users\trannqt\Desktop\BanHangNetCoreNhom123-backup7\BanHangNetCoreNhom123\BanHangNetCoreNhom123\Views\Checkout\Index.cshtml"
                            }
                        }

#line default
#line hidden
                BeginContext(5161, 24, true);
                WriteLiteral("                        ");
                EndContext();
#line 128 "C:\Users\trannqt\Desktop\BanHangNetCoreNhom123-backup7\BanHangNetCoreNhom123\BanHangNetCoreNhom123\Views\Checkout\Index.cshtml"
                         if (ViewBag.Total == 0)
                        {

#line default
#line hidden
                BeginContext(5238, 177, true);
                WriteLiteral("                            <tr>\r\n                                <td colspan=\"2\" style=\"padding-left: 80px\">Ch??a c?? s???n ph???m trong gi???</td>\r\n                            </tr>\r\n");
                EndContext();
#line 133 "C:\Users\trannqt\Desktop\BanHangNetCoreNhom123-backup7\BanHangNetCoreNhom123\BanHangNetCoreNhom123\Views\Checkout\Index.cshtml"
                        }

#line default
#line hidden
                BeginContext(5442, 129, true);
                WriteLiteral("\r\n                        <tr>\r\n                            <td><strong>Subtotal</strong></td>\r\n                            <td>$");
                EndContext();
                BeginContext(5572, 38, false);
#line 137 "C:\Users\trannqt\Desktop\BanHangNetCoreNhom123-backup7\BanHangNetCoreNhom123\BanHangNetCoreNhom123\Views\Checkout\Index.cshtml"
                            Write(string.Format("{0:N2}", ViewBag.Total));

#line default
#line hidden
                EndContext();
                BeginContext(5610, 336, true);
                WriteLiteral(@"</td>
                        </tr>
                        <tr>
                            <td><strong>Coupon</strong></td>
                            <td>None</td>
                        </tr>
                        <tr>
                            <td><strong>Total</strong></td>
                            <td><strong>$");
                EndContext();
                BeginContext(5947, 38, false);
#line 145 "C:\Users\trannqt\Desktop\BanHangNetCoreNhom123-backup7\BanHangNetCoreNhom123\BanHangNetCoreNhom123\Views\Checkout\Index.cshtml"
                                    Write(string.Format("{0:N2}", ViewBag.Total));

#line default
#line hidden
                EndContext();
                BeginContext(5985, 281, true);
                WriteLiteral(@"</strong></td>
                        </tr>
                    </tbody>
                </table>
            </div>
            <br />

            <div class=""form-field"">
                <button class=""btn btn-danger"">THANH TO??N</button>
            </div>

        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6273, 38, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
