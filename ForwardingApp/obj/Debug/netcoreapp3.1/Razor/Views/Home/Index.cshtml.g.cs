#pragma checksum "C:\Users\Huseyin\Projects\ForwardingApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce134109a3e270159676c8c2c0c20c816ac2af44"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Huseyin\Projects\ForwardingApp\Views\_ViewImports.cshtml"
using ForwardingApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Huseyin\Projects\ForwardingApp\Views\_ViewImports.cshtml"
using ForwardingApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce134109a3e270159676c8c2c0c20c816ac2af44", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a8d59bb08833456967eff2ff450e2ced64ca936", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ForwardingApp.Part>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<table style=\"text-align: center; width:100%\">\r\n  <tr>\r\n        <th> BOX ID </th>\r\n        <th> PART NUMBER </th>\r\n        <th> PART WEIGHT </th>\r\n        <th> PART COST </th>\r\n  </tr>\r\n");
#nullable restore
#line 10 "C:\Users\Huseyin\Projects\ForwardingApp\Views\Home\Index.cshtml"
 foreach (var item in Model) //Parts
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("      <tr>\r\n      <td>\r\n        ");
#nullable restore
#line 14 "C:\Users\Huseyin\Projects\ForwardingApp\Views\Home\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.BoxId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n      </td>\r\n      <td>\r\n        ");
#nullable restore
#line 17 "C:\Users\Huseyin\Projects\ForwardingApp\Views\Home\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.PartNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n      </td>\r\n       <td>\r\n        ");
#nullable restore
#line 20 "C:\Users\Huseyin\Projects\ForwardingApp\Views\Home\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.PartWeight));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n      </td>\r\n       <td>\r\n        ");
#nullable restore
#line 23 "C:\Users\Huseyin\Projects\ForwardingApp\Views\Home\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.PartCost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n      </td>\r\n      </tr>\r\n");
#nullable restore
#line 26 "C:\Users\Huseyin\Projects\ForwardingApp\Views\Home\Index.cshtml"
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ForwardingApp.Part>> Html { get; private set; }
    }
}
#pragma warning restore 1591