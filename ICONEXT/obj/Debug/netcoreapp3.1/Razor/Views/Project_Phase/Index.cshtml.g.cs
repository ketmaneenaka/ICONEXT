#pragma checksum "C:\Users\Prae_Nicha\Source\Repos\ICONEXT_Project-management\ICONEXT\Views\Project_Phase\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5761b10ec1cf2ee6df378520fd0ad2b5b9d9def3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Project_Phase_Index), @"mvc.1.0.view", @"/Views/Project_Phase/Index.cshtml")]
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
#line 2 "C:\Users\Prae_Nicha\Source\Repos\ICONEXT_Project-management\ICONEXT\Views\_ViewImports.cshtml"
using ICONEXT.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Prae_Nicha\Source\Repos\ICONEXT_Project-management\ICONEXT\Views\Project_Phase\Index.cshtml"
using ICONEXT;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5761b10ec1cf2ee6df378520fd0ad2b5b9d9def3", @"/Views/Project_Phase/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c24928ea3ae4b2d2e28249bcaf20e23c95a8feb", @"/Views/_ViewImports.cshtml")]
    public class Views_Project_Phase_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ICONEXT.Models.Project_Phase>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Prae_Nicha\Source\Repos\ICONEXT_Project-management\ICONEXT\Views\Project_Phase\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\Prae_Nicha\Source\Repos\ICONEXT_Project-management\ICONEXT\Views\Project_Phase\Index.cshtml"
  
    IEnumerable<Project_Phase> displaydata = ViewData["Results"] as IEnumerable<Project_Phase>;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

    
   
    
    <!--
    <h1>TEST database</h1>

    <table class=""table"">
        <tr>
            <th>Name</th>
            <th>Tasks</th>
            <th>Phase</th>
            <th>StartDate</th>
            <th>EndDate</th>
            <th>Usage</th>

        </tr>
");
#nullable restore
#line 29 "C:\Users\Prae_Nicha\Source\Repos\ICONEXT_Project-management\ICONEXT\Views\Project_Phase\Index.cshtml"
         foreach (var item in displaydata)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td>");
#nullable restore
#line 32 "C:\Users\Prae_Nicha\Source\Repos\ICONEXT_Project-management\ICONEXT\Views\Project_Phase\Index.cshtml"
       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 33 "C:\Users\Prae_Nicha\Source\Repos\ICONEXT_Project-management\ICONEXT\Views\Project_Phase\Index.cshtml"
       Write(item.Tasks);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 34 "C:\Users\Prae_Nicha\Source\Repos\ICONEXT_Project-management\ICONEXT\Views\Project_Phase\Index.cshtml"
       Write(item.Phase);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 35 "C:\Users\Prae_Nicha\Source\Repos\ICONEXT_Project-management\ICONEXT\Views\Project_Phase\Index.cshtml"
       Write(item.FromDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 36 "C:\Users\Prae_Nicha\Source\Repos\ICONEXT_Project-management\ICONEXT\Views\Project_Phase\Index.cshtml"
       Write(item.EndDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 37 "C:\Users\Prae_Nicha\Source\Repos\ICONEXT_Project-management\ICONEXT\Views\Project_Phase\Index.cshtml"
       Write(item.Usage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n    </tr>\r\n");
#nullable restore
#line 40 "C:\Users\Prae_Nicha\Source\Repos\ICONEXT_Project-management\ICONEXT\Views\Project_Phase\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </table>\r\n        -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ICONEXT.Models.Project_Phase>> Html { get; private set; }
    }
}
#pragma warning restore 1591