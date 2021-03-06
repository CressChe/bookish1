#pragma checksum "C:\Training\Bookish\bookish1\Views\Checkout\All.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69b830c32bf6bd87e339a45e0b621309596846d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Checkout_All), @"mvc.1.0.view", @"/Views/Checkout/All.cshtml")]
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
#line 1 "C:\Training\Bookish\bookish1\Views\_ViewImports.cshtml"
using Bookish;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Training\Bookish\bookish1\Views\_ViewImports.cshtml"
using Bookish.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69b830c32bf6bd87e339a45e0b621309596846d8", @"/Views/Checkout/All.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e05004d587bb18274aac2c03503e22cb8bcb75b", @"/Views/_ViewImports.cshtml")]
    public class Views_Checkout_All : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<CheckoutViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Training\Bookish\bookish1\Views\Checkout\All.cshtml"
  
    var booksOnLoan = Model.Where(checkout => !checkout.DateReturned.HasValue);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>History of books on loan</h1>\r\n\r\n");
#nullable restore
#line 8 "C:\Training\Bookish\bookish1\Views\Checkout\All.cshtml"
 foreach (var checkout in Model)
{
    var returnDate = (@checkout.DateReturned == null) ? "Unreturned" : checkout.DateReturned?.ToString("dd/MM/yyyy");

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>");
#nullable restore
#line 11 "C:\Training\Bookish\bookish1\Views\Checkout\All.cshtml"
Write(checkout.Book.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" by ");
#nullable restore
#line 11 "C:\Training\Bookish\bookish1\Views\Checkout\All.cshtml"
                      Write(checkout.Book.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral(", loaned to ");
#nullable restore
#line 11 "C:\Training\Bookish\bookish1\Views\Checkout\All.cshtml"
                                                       Write(checkout.Member.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(", from: ");
#nullable restore
#line 11 "C:\Training\Bookish\bookish1\Views\Checkout\All.cshtml"
                                                                                    Write(checkout.DateLoaned.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(", until: ");
#nullable restore
#line 11 "C:\Training\Bookish\bookish1\Views\Checkout\All.cshtml"
                                                                                                                                        Write(checkout.DateDue.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(", returned on date: ");
#nullable restore
#line 11 "C:\Training\Bookish\bookish1\Views\Checkout\All.cshtml"
                                                                                                                                                                                                    Write(returnDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 12 "C:\Training\Bookish\bookish1\Views\Checkout\All.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2> Books currently on loan </h2>\r\n\r\n");
#nullable restore
#line 16 "C:\Training\Bookish\bookish1\Views\Checkout\All.cshtml"
 foreach (var checkout in booksOnLoan)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>");
#nullable restore
#line 18 "C:\Training\Bookish\bookish1\Views\Checkout\All.cshtml"
  Write(checkout.Book.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" by ");
#nullable restore
#line 18 "C:\Training\Bookish\bookish1\Views\Checkout\All.cshtml"
                          Write(checkout.Book.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral(", loaned to ");
#nullable restore
#line 18 "C:\Training\Bookish\bookish1\Views\Checkout\All.cshtml"
                                                           Write(checkout.Member.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(", from: ");
#nullable restore
#line 18 "C:\Training\Bookish\bookish1\Views\Checkout\All.cshtml"
                                                                                        Write(checkout.DateLoaned.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(", until: ");
#nullable restore
#line 18 "C:\Training\Bookish\bookish1\Views\Checkout\All.cshtml"
                                                                                                                                            Write(checkout.DateDue.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n");
#nullable restore
#line 19 "C:\Training\Bookish\bookish1\Views\Checkout\All.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<CheckoutViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
