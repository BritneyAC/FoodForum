#pragma checksum "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\IndexRatingPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a62eaf93309cc3af7930f9206993c1c9fea4874a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_IndexRatingPartial), @"mvc.1.0.view", @"/Views/Home/IndexRatingPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/IndexRatingPartial.cshtml", typeof(AspNetCore.Views_Home_IndexRatingPartial))]
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
#line 1 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\_ViewImports.cshtml"
using FoodForum;

#line default
#line hidden
#line 2 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\_ViewImports.cshtml"
using FoodForum.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a62eaf93309cc3af7930f9206993c1c9fea4874a", @"/Views/Home/IndexRatingPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0dbefc2e8829f90b94546d276e003e26c9851cf8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_IndexRatingPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Recipe", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Recipes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 374, true);
            WriteLiteral(@"  <table class=""SortingTbl"">
    <thead class=""SortingThead"">
      <tr class=""SortingTR"">
        <td class=""SortingBtn"" id=""IndexRatingReverse""><h4>Sort By Rating ↑</h4></td>
        <td class=""SortingBtn"" id=""IndexLikes""><h4>Sort By Likes ↓</h4></td>
        <td class=""SortingBtn"" id=""IndexTime""><h4>Sort By Newest</h4></td>
      </tr>
    </thead>
  </table>
");
            EndContext();
#line 10 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\IndexRatingPartial.cshtml"
   foreach(var recipe in ViewBag.RecipesByRating){

#line default
#line hidden
            BeginContext(426, 36, true);
            WriteLiteral("    <div class=\"Recipe\">\r\n      <h3>");
            EndContext();
            BeginContext(462, 97, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b51ad132be664c3987cb38eb3ba8e675", async() => {
                BeginContext(543, 12, false);
#line 12 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\IndexRatingPartial.cshtml"
                                                                                     Write(recipe.Title);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Title", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 12 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\IndexRatingPartial.cshtml"
                                                               WriteLiteral(recipe.Title);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Title"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Title", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Title"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(559, 20, true);
            WriteLiteral("</h3>\r\n      <h5>By ");
            EndContext();
            BeginContext(580, 20, false);
#line 13 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\IndexRatingPartial.cshtml"
        Write(recipe.User.Username);

#line default
#line hidden
            EndContext();
            BeginContext(600, 7, true);
            WriteLiteral("</h5>\r\n");
            EndContext();
#line 14 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\IndexRatingPartial.cshtml"
       if(recipe.PictureURL != null){

#line default
#line hidden
            BeginContext(646, 38, true);
            WriteLiteral("        <div class=\"RecipeListPicture\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 684, "\"", 733, 4);
            WriteAttributeValue("", 692, "background-image:", 692, 17, true);
            WriteAttributeValue(" ", 709, "url(", 710, 5, true);
#line 15 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\IndexRatingPartial.cshtml"
WriteAttributeValue("", 714, recipe.PictureURL, 714, 18, false);

#line default
#line hidden
            WriteAttributeValue("", 732, ")", 732, 1, true);
            EndWriteAttribute();
            BeginContext(734, 10, true);
            WriteLiteral(";></div>\r\n");
            EndContext();
#line 16 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\IndexRatingPartial.cshtml"
      }

#line default
#line hidden
            BeginContext(753, 12, true);
            WriteLiteral("      <ul>\r\n");
            EndContext();
#line 18 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\IndexRatingPartial.cshtml"
         foreach(var ingredient in recipe.GetIngredients()){

#line default
#line hidden
            BeginContext(827, 14, true);
            WriteLiteral("          <li>");
            EndContext();
            BeginContext(842, 10, false);
#line 19 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\IndexRatingPartial.cshtml"
         Write(ingredient);

#line default
#line hidden
            EndContext();
            BeginContext(852, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 20 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\IndexRatingPartial.cshtml"
        }

#line default
#line hidden
            BeginContext(870, 22, true);
            WriteLiteral("      </ul>\r\n      <p>");
            EndContext();
            BeginContext(893, 14, false);
#line 22 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\IndexRatingPartial.cshtml"
    Write(recipe.Content);

#line default
#line hidden
            EndContext();
            BeginContext(907, 38, true);
            WriteLiteral("</p>\r\n      <p class=\"Rating\">Rating: ");
            EndContext();
            BeginContext(946, 18, false);
#line 23 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\IndexRatingPartial.cshtml"
                           Write(recipe.GetRating());

#line default
#line hidden
            EndContext();
            BeginContext(964, 36, true);
            WriteLiteral("</p>\r\n      <p class=\"Likes\">Likes: ");
            EndContext();
            BeginContext(1001, 18, false);
#line 24 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\IndexRatingPartial.cshtml"
                         Write(recipe.Likes.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1019, 45, true);
            WriteLiteral("</p>\r\n      <p class=\"postDate\">Date Posted: ");
            EndContext();
            BeginContext(1065, 39, false);
#line 25 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\IndexRatingPartial.cshtml"
                                  Write(recipe.CreatedAt.ToString("MM/dd/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1104, 20, true);
            WriteLiteral("</p>\r\n    </div>  \r\n");
            EndContext();
#line 27 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\IndexRatingPartial.cshtml"
  }

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
