#pragma checksum "C:\Users\PC_1\source\repos\file_handling_mvc\identity_2auth_mvc\Views\Shared\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d78b097657b352b91b973473fbaa52372b3e93d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
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
#line 1 "C:\Users\PC_1\source\repos\file_handling_mvc\identity_2auth_mvc\Views\_ViewImports.cshtml"
using identity_2auth_mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PC_1\source\repos\file_handling_mvc\identity_2auth_mvc\Views\_ViewImports.cshtml"
using identity_2auth_mvc.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\PC_1\source\repos\file_handling_mvc\identity_2auth_mvc\Views\_ViewImports.cshtml"
using identity_2auth_mvc.Models.Klas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\PC_1\source\repos\file_handling_mvc\identity_2auth_mvc\Views\_ViewImports.cshtml"
using identity_2auth_mvc.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\PC_1\source\repos\file_handling_mvc\identity_2auth_mvc\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d78b097657b352b91b973473fbaa52372b3e93d5", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c8956e3a956151fbd957c45296973096f3b8a69", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ErrorViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\PC_1\source\repos\file_handling_mvc\identity_2auth_mvc\Views\Shared\Error.cshtml"
  
	Context.Response.StatusCode = Model.StatusCode;
	switch (Context.Response.StatusCode)
	{
		case 404:
			ViewData["Title"] = "404: Resource Not Found";
			break;
		default: // CAN HANDLE OTHER STATUS CODES
			ViewData["Title"] = Context.Response.StatusCode + ": Error";
			break;
	}

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>");
#nullable restore
#line 14 "C:\Users\PC_1\source\repos\file_handling_mvc\identity_2auth_mvc\Views\Shared\Error.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n");
#nullable restore
#line 16 "C:\Users\PC_1\source\repos\file_handling_mvc\identity_2auth_mvc\Views\Shared\Error.cshtml"
 if (Model.ShowRequestId)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<p><strong>Request ID:</strong> <code>");
#nullable restore
#line 18 "C:\Users\PC_1\source\repos\file_handling_mvc\identity_2auth_mvc\Views\Shared\Error.cshtml"
                                     Write(Model.RequestId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</code></p>\r\n");
#nullable restore
#line 19 "C:\Users\PC_1\source\repos\file_handling_mvc\identity_2auth_mvc\Views\Shared\Error.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<pre>");
#nullable restore
#line 20 "C:\Users\PC_1\source\repos\file_handling_mvc\identity_2auth_mvc\Views\Shared\Error.cshtml"
Write(Model.Path);

#line default
#line hidden
#nullable disable
            WriteLiteral("</pre>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ErrorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
