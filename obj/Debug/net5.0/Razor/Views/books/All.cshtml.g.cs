#pragma checksum "C:\Training\Bookish\Views\books\All.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c845c25dc79e0fb8b6dc364332a5d2c73d82e89"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_books_All), @"mvc.1.0.view", @"/Views/books/All.cshtml")]
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
#line 1 "C:\Training\Bookish\Views\_ViewImports.cshtml"
using Bookish;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Training\Bookish\Views\_ViewImports.cshtml"
using Bookish.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c845c25dc79e0fb8b6dc364332a5d2c73d82e89", @"/Views/books/All.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e05004d587bb18274aac2c03503e22cb8bcb75b", @"/Views/_ViewImports.cshtml")]
    public class Views_books_All : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<BookViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Books</h1>\r\n\r\n");
#nullable restore
#line 5 "C:\Training\Bookish\Views\books\All.cshtml"
 foreach (var book in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>");
#nullable restore
#line 7 "C:\Training\Bookish\Views\books\All.cshtml"
  Write(book.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral(", Title: ");
#nullable restore
#line 7 "C:\Training\Bookish\Views\books\All.cshtml"
                       Write(book.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ID: ");
#nullable restore
#line 7 "C:\Training\Bookish\Views\books\All.cshtml"
                                        Write(book.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(", Genre: ");
#nullable restore
#line 7 "C:\Training\Bookish\Views\books\All.cshtml"
                                                         Write(book.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral(", Number of Copies: ");
#nullable restore
#line 7 "C:\Training\Bookish\Views\books\All.cshtml"
                                                                                        Write(book.NumberOfCopies);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 8 "C:\Training\Bookish\Views\books\All.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<BookViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
