#pragma checksum "C:\Users\Admin\Downloads\CRUD Application\CRUD Application\BookApp\BookApp\Pages\Books.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd06b4b83b4b1c69ae2ea1c1c31858564a087c2e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(BookApp.Pages.Pages_Books), @"mvc.1.0.razor-page", @"/Pages/Books.cshtml")]
namespace BookApp.Pages
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
#line 1 "C:\Users\Admin\Downloads\CRUD Application\CRUD Application\BookApp\BookApp\Pages\_ViewImports.cshtml"
using BookApp;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd06b4b83b4b1c69ae2ea1c1c31858564a087c2e", @"/Pages/Books.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f48aea7e39e9883a016288c00ac518a511ceb008", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Books : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Admin\Downloads\CRUD Application\CRUD Application\BookApp\BookApp\Pages\Books.cshtml"
  
    ViewData["Title"] = "Books";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

    <div>

        <h1>Books</h1>

        Below you see all the Books in the Book Store:<br />

        <table class=""table"">
            <thead>
                <tr>
                    <th>BookId</th>
                    <th>Title</th>
                    <th>ISBN</th>
                    <th>Publisher</th>
                    <th>Author</th>
                    <th>Category</th>
                    <th>Action</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 27 "C:\Users\Admin\Downloads\CRUD Application\CRUD Application\BookApp\BookApp\Pages\Books.cshtml"
                 foreach (var book in Model.books)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td> ");
#nullable restore
#line 30 "C:\Users\Admin\Downloads\CRUD Application\CRUD Application\BookApp\BookApp\Pages\Books.cshtml"
                    Write(book.BookId);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 755, "\"", 792, 2);
            WriteAttributeValue("", 762, "./EditBook?bookid=", 762, 18, true);
#nullable restore
#line 32 "C:\Users\Admin\Downloads\CRUD Application\CRUD Application\BookApp\BookApp\Pages\Books.cshtml"
WriteAttributeValue("", 780, book.BookId, 780, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 32 "C:\Users\Admin\Downloads\CRUD Application\CRUD Application\BookApp\BookApp\Pages\Books.cshtml"
                                                            Write(book.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> </td>\r\n\r\n                    <td> ");
#nullable restore
#line 34 "C:\Users\Admin\Downloads\CRUD Application\CRUD Application\BookApp\BookApp\Pages\Books.cshtml"
                    Write(book.Isbn);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td> ");
#nullable restore
#line 35 "C:\Users\Admin\Downloads\CRUD Application\CRUD Application\BookApp\BookApp\Pages\Books.cshtml"
                    Write(book.PublisherName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td> ");
#nullable restore
#line 36 "C:\Users\Admin\Downloads\CRUD Application\CRUD Application\BookApp\BookApp\Pages\Books.cshtml"
                    Write(book.AuthorName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td> ");
#nullable restore
#line 37 "C:\Users\Admin\Downloads\CRUD Application\CRUD Application\BookApp\BookApp\Pages\Books.cshtml"
                    Write(book.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 1040, "\"", 1079, 2);
            WriteAttributeValue("", 1047, "./DeleteBook?bookid=", 1047, 20, true);
#nullable restore
#line 38 "C:\Users\Admin\Downloads\CRUD Application\CRUD Application\BookApp\BookApp\Pages\Books.cshtml"
WriteAttributeValue("", 1067, book.BookId, 1067, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\" role=\"button\">Delete Book</a> </td>\r\n                </tr>\r\n");
#nullable restore
#line 40 "C:\Users\Admin\Downloads\CRUD Application\CRUD Application\BookApp\BookApp\Pages\Books.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n\r\n\r\n        <a href=\"./NewBook\" class=\"btn btn-info\" role=\"button\">New Book</a>\r\n\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookApp.Pages.BooksModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BookApp.Pages.BooksModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BookApp.Pages.BooksModel>)PageContext?.ViewData;
        public BookApp.Pages.BooksModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591