#pragma checksum "D:\2019年开发框架\BS\DotNetCoreTemplate\ZCX.DotNetCoreTemplate\DotNetCoreTemplate.Web\Pages\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8cf5a6ef6e30bb9b0748438acef1654d8e212a57"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(DotNetCoreTemplate.Web.Pages.Pages_Error), @"mvc.1.0.razor-page", @"/Pages/Error.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Error.cshtml", typeof(DotNetCoreTemplate.Web.Pages.Pages_Error), null)]
namespace DotNetCoreTemplate.Web.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\2019年开发框架\BS\DotNetCoreTemplate\ZCX.DotNetCoreTemplate\DotNetCoreTemplate.Web\Pages\_ViewImports.cshtml"
using DotNetCoreTemplate.Web;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8cf5a6ef6e30bb9b0748438acef1654d8e212a57", @"/Pages/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33c1eaf7dd989c43e6ba89425ab7dbebc605cfdd", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Error : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\2019年开发框架\BS\DotNetCoreTemplate\ZCX.DotNetCoreTemplate\DotNetCoreTemplate.Web\Pages\Error.cshtml"
  
    ViewData["Title"] = "错误";

#line default
#line hidden
            BeginContext(64, 83, true);
            WriteLiteral("\r\n<h1 class=\"text-danger\">出错啦！</h1>\r\n<h2 class=\"text-danger\">在处理您的请求时出现错误.</h2>\r\n\r\n");
            EndContext();
#line 10 "D:\2019年开发框架\BS\DotNetCoreTemplate\ZCX.DotNetCoreTemplate\DotNetCoreTemplate.Web\Pages\Error.cshtml"
 if (Model.ShowRequestId)
{

#line default
#line hidden
            BeginContext(177, 46, true);
            WriteLiteral("    <p>\r\n        <strong>请求编号:</strong> <code>");
            EndContext();
            BeginContext(224, 15, false);
#line 13 "D:\2019年开发框架\BS\DotNetCoreTemplate\ZCX.DotNetCoreTemplate\DotNetCoreTemplate.Web\Pages\Error.cshtml"
                                Write(Model.RequestId);

#line default
#line hidden
            EndContext();
            BeginContext(239, 19, true);
            WriteLiteral("</code>\r\n    </p>\r\n");
            EndContext();
#line 15 "D:\2019年开发框架\BS\DotNetCoreTemplate\ZCX.DotNetCoreTemplate\DotNetCoreTemplate.Web\Pages\Error.cshtml"
}

#line default
#line hidden
            BeginContext(261, 316, true);
            WriteLiteral(@"
<h3>开发模式</h3>
<p>
    切换到 <strong>Development</strong> 环境将显示发生错误的详细信息.
</p>
<p>
    <strong>在部署应用程序时，Development环境设置应当禁用.</strong>
    否则会导致一些异常的敏感信息暴露给终端用户.
    对于本地调试，开启<strong>Development</strong>环境变量，通过设置<strong>ASPNETCORE_ENVIRONMENT</strong> 环境变量值为<strong>Development</strong>
    然后重新启动应用程序.
</p>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ErrorModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ErrorModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ErrorModel>)PageContext?.ViewData;
        public ErrorModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
