#pragma checksum "D:\.NET MVC\CopyVisterma\CopyVisterma\Views\Clients\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5afbce6a90ce24100e23d0d9509055222ac66a09"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clients_Create), @"mvc.1.0.view", @"/Views/Clients/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Clients/Create.cshtml", typeof(AspNetCore.Views_Clients_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5afbce6a90ce24100e23d0d9509055222ac66a09", @"/Views/Clients/Create.cshtml")]
    public class Views_Clients_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CopyVisterma.Entities.Client>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\.NET MVC\CopyVisterma\CopyVisterma\Views\Clients\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
            BeginContext(81, 4222, true);
            WriteLiteral(@"
<h2>Create</h2>

<h4>Client</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""Name"" class=""control-label""></label>
                <input asp-for=""Name"" class=""form-control"" />
                <span asp-validation-for=""Name"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""City"" class=""control-label""></label>
                <input asp-for=""City"" class=""form-control"" />
                <span asp-validation-for=""City"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""PostalCode"" class=""control-label""></label>
                <input asp-for=""PostalCode"" class=""form-control"" />
                <span asp-validation-for=""PostalCode"" class=""text-danger""></span>
            <");
            WriteLiteral(@"/div>
            <div class=""form-group"">
                <label asp-for=""NIP"" class=""control-label""></label>
                <input asp-for=""NIP"" class=""form-control"" />
                <span asp-validation-for=""NIP"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""REGON"" class=""control-label""></label>
                <input asp-for=""REGON"" class=""form-control"" />
                <span asp-validation-for=""REGON"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Phone"" class=""control-label""></label>
                <input asp-for=""Phone"" class=""form-control"" />
                <span asp-validation-for=""Phone"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Email"" class=""control-label""></label>
                <input asp-for=""Email"" class=""form-control"" />
                <span asp-validation-");
            WriteLiteral(@"for=""Email"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""TypeId"" class=""control-label""></label>
                <select asp-for=""TypeId"" class =""form-control"" asp-items=""ViewBag.TypeId""></select>
            </div>
            <div class=""form-group"">
                <label asp-for=""Street"" class=""control-label""></label>
                <input asp-for=""Street"" class=""form-control"" />
                <span asp-validation-for=""Street"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""BuildingNumber"" class=""control-label""></label>
                <input asp-for=""BuildingNumber"" class=""form-control"" />
                <span asp-validation-for=""BuildingNumber"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""ApartmentNumber"" class=""control-label""></label>
                <input asp-for=""Apartment");
            WriteLiteral(@"Number"" class=""form-control"" />
                <span asp-validation-for=""ApartmentNumber"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""PersonGuardianId"" class=""control-label""></label>
                <select asp-for=""PersonGuardianId"" class =""form-control"" asp-items=""ViewBag.PersonGuardianId""></select>
            </div>
            <div class=""form-group"">
                <label asp-for=""PersonWaterId"" class=""control-label""></label>
                <select asp-for=""PersonWaterId"" class =""form-control"" asp-items=""ViewBag.PersonWaterId""></select>
            </div>
            <div class=""form-group"">
                <label asp-for=""PersonHeatingId"" class=""control-label""></label>
                <select asp-for=""PersonHeatingId"" class =""form-control"" asp-items=""ViewBag.PersonHeatingId""></select>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-default");
            WriteLiteral("\" />\r\n            </div>\r\n        </form>\r\n    </div>\r\n</div>\r\n\r\n<div>\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(4321, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 93 "D:\.NET MVC\CopyVisterma\CopyVisterma\Views\Clients\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CopyVisterma.Entities.Client> Html { get; private set; }
    }
}
#pragma warning restore 1591
