#pragma checksum "C:\Users\trannqt\Desktop\BanHangNetCoreNhom123-backup7\BanHangNetCoreNhom123\BanHangNetCoreNhom123\Views\LoaiAdmin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74dd8b30fab80af9cbd51ee2fcacb6eadd79357d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LoaiAdmin_Index), @"mvc.1.0.view", @"/Views/LoaiAdmin/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/LoaiAdmin/Index.cshtml", typeof(AspNetCore.Views_LoaiAdmin_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74dd8b30fab80af9cbd51ee2fcacb6eadd79357d", @"/Views/LoaiAdmin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2df1cb29a3fc06e5d08c4aea44f7cce5fac285bd", @"/Views/_ViewImports.cshtml")]
    public class Views_LoaiAdmin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BanHangNetCoreNhom123.Models.LoaiThucDon>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("S???a"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(62, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\trannqt\Desktop\BanHangNetCoreNhom123-backup7\BanHangNetCoreNhom123\BanHangNetCoreNhom123\Views\LoaiAdmin\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Layout/Admin/Layout.cshtml";

#line default
#line hidden
            BeginContext(157, 45, true);
            WriteLiteral("\r\n<h1>Qu???n l?? lo???i s???n ph???m</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(202, 105, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74dd8b30fab80af9cbd51ee2fcacb6eadd79357d5063", async() => {
                BeginContext(225, 78, true);
                WriteLiteral("<button class=\"btn btn-primary\"><li class=\"fa fa-plus\"></li> Th??m m???i</button>");
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
            BeginContext(307, 447, true);
            WriteLiteral(@"
</p>

<div class=""container text-center"">
    <div class=""row"">
        <div class=""col col-12"">
            <table class=""table"">
                <thead class=""thead-light"">
                    <tr>
                        <th scope=""col"">#</th>
                        <th scope=""col"">T??n lo???i</th>
                        <th scope=""col"">Ch???c n??ng</th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 26 "C:\Users\trannqt\Desktop\BanHangNetCoreNhom123-backup7\BanHangNetCoreNhom123\BanHangNetCoreNhom123\Views\LoaiAdmin\Index.cshtml"
                      
                        var i = 1;
                        foreach (var item in ViewBag.List)
                        {

#line default
#line hidden
            BeginContext(901, 82, true);
            WriteLiteral("                            <tr>\r\n                                <th scope=\"row\">");
            EndContext();
            BeginContext(984, 1, false);
#line 31 "C:\Users\trannqt\Desktop\BanHangNetCoreNhom123-backup7\BanHangNetCoreNhom123\BanHangNetCoreNhom123\Views\LoaiAdmin\Index.cshtml"
                                           Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(985, 43, true);
            WriteLiteral("</th>\r\n                                <td>");
            EndContext();
            BeginContext(1029, 12, false);
#line 32 "C:\Users\trannqt\Desktop\BanHangNetCoreNhom123-backup7\BanHangNetCoreNhom123\BanHangNetCoreNhom123\Views\LoaiAdmin\Index.cshtml"
                               Write(item.TenLoai);

#line default
#line hidden
            EndContext();
            BeginContext(1041, 81, true);
            WriteLiteral("</td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(1122, 153, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74dd8b30fab80af9cbd51ee2fcacb6eadd79357d8397", async() => {
                BeginContext(1183, 88, true);
                WriteLiteral("<button class=\"btn btn-secondary\"><i class=\"fa fa-edit\" aria-hidden=\"true\"></i></button>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 34 "C:\Users\trannqt\Desktop\BanHangNetCoreNhom123-backup7\BanHangNetCoreNhom123\BanHangNetCoreNhom123\Views\LoaiAdmin\Index.cshtml"
                                                                       WriteLiteral(item.MaLoai);

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
            BeginContext(1275, 88, true);
            WriteLiteral("\r\n                                    <button class=\"btn btn-primary thongtin\" data-id=\"");
            EndContext();
            BeginContext(1364, 11, false);
#line 35 "C:\Users\trannqt\Desktop\BanHangNetCoreNhom123-backup7\BanHangNetCoreNhom123\BanHangNetCoreNhom123\Views\LoaiAdmin\Index.cshtml"
                                                                                 Write(item.MaLoai);

#line default
#line hidden
            EndContext();
            BeginContext(1375, 212, true);
            WriteLiteral("\" data-toggle=\"modal\" data-target=\"#exampleModal\"><i class=\"fa fa-info\" aria-hidden=\"true\"></i></button>\r\n                                    <button class=\"btn btn-danger Xoane\" data-toggle=\"modal\" data-target=\"");
            EndContext();
            BeginContext(1588, 44, false);
#line 36 "C:\Users\trannqt\Desktop\BanHangNetCoreNhom123-backup7\BanHangNetCoreNhom123\BanHangNetCoreNhom123\Views\LoaiAdmin\Index.cshtml"
                                                                                                     Write(String.Concat("#exampleModal1",@item.MaLoai));

#line default
#line hidden
            EndContext();
            BeginContext(1632, 200, true);
            WriteLiteral("\">\r\n                                        <i class=\"fa fa-times\" aria-hidden=\"true\"></i>\r\n                                    </button>\r\n\r\n                                    <div class=\"modal fade\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1832, "\"", 1881, 1);
#line 40 "C:\Users\trannqt\Desktop\BanHangNetCoreNhom123-backup7\BanHangNetCoreNhom123\BanHangNetCoreNhom123\Views\LoaiAdmin\Index.cshtml"
WriteAttributeValue("", 1837, String.Concat("exampleModal1",@item.MaLoai), 1837, 44, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1882, 953, true);
            WriteLiteral(@" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel1"" aria-hidden=""true"">
                                        <div class=""modal-dialog"" role=""document"">
                                            <div class=""modal-content"">
                                                <div class=""modal-header"">
                                                    <h5 class=""modal-title"" id=""exampleModalLabel"" style=""text-align:center"">X??a T??i Kho???n</h5>
                                                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                                        <span aria-hidden=""true"">&times;</span>
                                                    </button>
                                                </div>
                                                <div class=""modal-body"">
                                                    B???n c?? mu???n x??a ");
            EndContext();
            BeginContext(2836, 12, false);
#line 50 "C:\Users\trannqt\Desktop\BanHangNetCoreNhom123-backup7\BanHangNetCoreNhom123\BanHangNetCoreNhom123\Views\LoaiAdmin\Index.cshtml"
                                                               Write(item.TenLoai);

#line default
#line hidden
            EndContext();
            BeginContext(2848, 331, true);
            WriteLiteral(@" kh??ng ?
                                                </div>
                                                <div class=""modal-footer"">
                                                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                                                    ");
            EndContext();
            BeginContext(3179, 115, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74dd8b30fab80af9cbd51ee2fcacb6eadd79357d14689", async() => {
                BeginContext(3230, 60, true);
                WriteLiteral(" <button type=\"button\" class=\"btn btn-primary\">X??a </button>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 54 "C:\Users\trannqt\Desktop\BanHangNetCoreNhom123-backup7\BanHangNetCoreNhom123\BanHangNetCoreNhom123\Views\LoaiAdmin\Index.cshtml"
                                                                             WriteLiteral(item.MaLoai);

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
            BeginContext(3294, 276, true);
            WriteLiteral(@"
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </td>
                            </tr>
");
            EndContext();
#line 61 "C:\Users\trannqt\Desktop\BanHangNetCoreNhom123-backup7\BanHangNetCoreNhom123\BanHangNetCoreNhom123\Views\LoaiAdmin\Index.cshtml"
                            i++;
                        }
                    

#line default
#line hidden
            BeginContext(3654, 1510, true);
            WriteLiteral(@"
                </tbody>
            </table>
        </div>
    </div>
</div>

<script>

    function IsDelete() {
        return confirm(""B???n mu???n x??a kh??ng?"");
    }

    $('.thongtin').click(function (e) {
        var id = $(this).attr('data-id');
        //var page = $('#trang').val();
        //alert(id);
        $.ajax({
            ""url"": '/LoaiAdmin/Details',
            type: ""POST"",
            data: { 'id': id },
            success: function (result) {
                //alert(result);
                $(""#result"").html(result);
            }
        });
    });


</script>
<div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"" style=""text-align:center"">Th??ng Tin Lo???i Th???c ????n</h5>
                <button type=""");
            WriteLiteral(@"button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
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
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BanHangNetCoreNhom123.Models.LoaiThucDon>> Html { get; private set; }
    }
}
#pragma warning restore 1591
