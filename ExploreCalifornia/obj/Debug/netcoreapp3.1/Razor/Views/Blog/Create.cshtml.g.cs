#pragma checksum "C:\Users\dingo\source\repos\ExploreCalifornia\ExploreCalifornia\Views\Blog\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f8faef87986234926c4990ba582ffd67bc216d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Create), @"mvc.1.0.view", @"/Views/Blog/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f8faef87986234926c4990ba582ffd67bc216d0", @"/Views/Blog/Create.cshtml")]
    public class Views_Blog_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ExploreCalifornia.Models.Post>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\dingo\source\repos\ExploreCalifornia\ExploreCalifornia\Views\Blog\Create.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Create blog post</h1>\r\n\r\n<fieldset>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\dingo\source\repos\ExploreCalifornia\ExploreCalifornia\Views\Blog\Create.cshtml"
     using (Html.BeginForm())
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>\r\n            ");
#nullable restore
#line 13 "C:\Users\dingo\source\repos\ExploreCalifornia\ExploreCalifornia\Views\Blog\Create.cshtml"
       Write(Html.LabelFor(x => x.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 14 "C:\Users\dingo\source\repos\ExploreCalifornia\ExploreCalifornia\Views\Blog\Create.cshtml"
       Write(Html.EditorFor(x => x.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n        <p>\r\n            ");
#nullable restore
#line 17 "C:\Users\dingo\source\repos\ExploreCalifornia\ExploreCalifornia\Views\Blog\Create.cshtml"
       Write(Html.LabelFor(x => x.Body));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 18 "C:\Users\dingo\source\repos\ExploreCalifornia\ExploreCalifornia\Views\Blog\Create.cshtml"
       Write(Html.TextAreaFor(x => x.Body));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n        <p>\r\n            <button type=\"submit\">Create post</button>\r\n        </p>\r\n");
#nullable restore
#line 23 "C:\Users\dingo\source\repos\ExploreCalifornia\ExploreCalifornia\Views\Blog\Create.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</fieldset>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ExploreCalifornia.Models.Post> Html { get; private set; }
    }
}
#pragma warning restore 1591
