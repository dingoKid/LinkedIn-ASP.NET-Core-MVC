#pragma checksum "C:\Denes\c#\GitHub\LinkedIn\ExploreCalifornia\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8138cf5ce28e52cecaa1134f4362fb93b9291a20"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8138cf5ce28e52cecaa1134f4362fb93b9291a20", @"/Views/Blog/Index.cshtml")]
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ExploreCalifornia.Models.Post[]>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Explorer\'s Blog</h1>\r\n\r\n<p>\r\n    Here are the latest blog posts from our explorers!\r\n</p>\r\n\r\n<p class=\"pager\">\r\n");
#nullable restore
#line 10 "C:\Denes\c#\GitHub\LinkedIn\ExploreCalifornia\Views\Blog\Index.cshtml"
     if(ViewBag.HasPreviousPage)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a class=\"prev\"");
            BeginWriteAttribute("href", " href=\"", 222, "\"", 293, 1);
#nullable restore
#line 12 "C:\Denes\c#\GitHub\LinkedIn\ExploreCalifornia\Views\Blog\Index.cshtml"
WriteAttributeValue("", 229, Url.Action("Index", "Blog", new { page = ViewBag.PreviousPage}), 229, 64, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            &lt; Previous\r\n        </a>\r\n");
#nullable restore
#line 15 "C:\Denes\c#\GitHub\LinkedIn\ExploreCalifornia\Views\Blog\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 17 "C:\Denes\c#\GitHub\LinkedIn\ExploreCalifornia\Views\Blog\Index.cshtml"
     if(ViewBag.HasNextPage)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a class=\"next\"");
            BeginWriteAttribute("href", " href=\"", 407, "\"", 474, 1);
#nullable restore
#line 19 "C:\Denes\c#\GitHub\LinkedIn\ExploreCalifornia\Views\Blog\Index.cshtml"
WriteAttributeValue("", 414, Url.Action("Index", "Blog", new { page = ViewBag.NextPage}), 414, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            Next &gt;\r\n        </a>\r\n");
#nullable restore
#line 22 "C:\Denes\c#\GitHub\LinkedIn\ExploreCalifornia\Views\Blog\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<div class=\"blog-posts\">\r\n");
#nullable restore
#line 26 "C:\Denes\c#\GitHub\LinkedIn\ExploreCalifornia\Views\Blog\Index.cshtml"
     foreach (var post in Model)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Denes\c#\GitHub\LinkedIn\ExploreCalifornia\Views\Blog\Index.cshtml"
   Write(await Html.PartialAsync("_Post", post));

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Denes\c#\GitHub\LinkedIn\ExploreCalifornia\Views\Blog\Index.cshtml"
                                               
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ExploreCalifornia.Models.Post[]> Html { get; private set; }
    }
}
#pragma warning restore 1591
