#pragma checksum "C:\Users\Mikis P\Desktop\TecTradeAPI\Views\Watch\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db4db246dd57620bd40e21b66baf162bfcac4458"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Watch_Edit), @"mvc.1.0.view", @"/Views/Watch/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db4db246dd57620bd40e21b66baf162bfcac4458", @"/Views/Watch/Edit.cshtml")]
    public class Views_Watch_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TecTradeAPI.Models.Watch>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Mikis P\Desktop\TecTradeAPI\Views\Watch\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Edit</h1>

<h4>Watch</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Edit"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""Id"" />
            <div class=""form-group"">
                <label asp-for=""Symbol"" class=""control-label""></label>
                <input asp-for=""Symbol"" class=""form-control"" />
                <span asp-validation-for=""Symbol"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""AssetTypeId"" class=""control-label""></label>
                <input asp-for=""AssetTypeId"" class=""form-control"" />
                <span asp-validation-for=""AssetTypeId"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""WatchlistId"" class=""control-label""></label>
                <input asp-for=""WatchlistId"" class=""form-control"" />
                <span ");
            WriteLiteral(@"asp-validation-for=""WatchlistId"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Save"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 43 "C:\Users\Mikis P\Desktop\TecTradeAPI\Views\Watch\Edit.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TecTradeAPI.Models.Watch> Html { get; private set; }
    }
}
#pragma warning restore 1591
