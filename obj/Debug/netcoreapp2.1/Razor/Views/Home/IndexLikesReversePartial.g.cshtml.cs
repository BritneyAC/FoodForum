#pragma checksum "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\IndexLikesReversePartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a24119ce7bac180ff4c998e29140aa3a511582f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_IndexLikesReversePartial), @"mvc.1.0.view", @"/Views/Home/IndexLikesReversePartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/IndexLikesReversePartial.cshtml", typeof(AspNetCore.Views_Home_IndexLikesReversePartial))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a24119ce7bac180ff4c998e29140aa3a511582f2", @"/Views/Home/IndexLikesReversePartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0dbefc2e8829f90b94546d276e003e26c9851cf8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_IndexLikesReversePartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            BeginContext(0, 367, true);
            WriteLiteral(@"  <table class=""SortingTbl"">
    <thead class=""SortingThead"">
      <tr class=""SortingTR"">
        <td class=""SortingBtn"" id=""IndexRating""><h4>Sort By Rating ↓</h4></td>
        <td class=""SortingBtn"" id=""IndexLikes""><h4>Sort By Likes ↓</h4></td>
        <td class=""SortingBtn"" id=""IndexTime""><h4>Sort By Newest</h4></td>
      </tr>
    </thead>
  </table>
");
            EndContext();
#line 10 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\IndexLikesReversePartial.cshtml"
   foreach(var recipe in ViewBag.RecipesByLikesReverse){

#line default
#line hidden
            BeginContext(425, 36, true);
            WriteLiteral("    <div class=\"Recipe\">\r\n      <h3>");
            EndContext();
            BeginContext(461, 97, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66509a413b5a48659c34c3cb6e0239b0", async() => {
                BeginContext(542, 12, false);
#line 12 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\IndexLikesReversePartial.cshtml"
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
#line 12 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\IndexLikesReversePartial.cshtml"
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
            BeginContext(558, 20, true);
            WriteLiteral("</h3>\r\n      <h5>By ");
            EndContext();
            BeginContext(579, 20, false);
#line 13 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\IndexLikesReversePartial.cshtml"
        Write(recipe.User.Username);

#line default
#line hidden
            EndContext();
            BeginContext(599, 7, true);
            WriteLiteral("</h5>\r\n");
            EndContext();
#line 14 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\IndexLikesReversePartial.cshtml"
       if(recipe.PictureURL != null){

#line default
#line hidden
            BeginContext(645, 38, true);
            WriteLiteral("        <div class=\"RecipeListPicture\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 683, "\"", 732, 4);
            WriteAttributeValue("", 691, "background-image:", 691, 17, true);
            WriteAttributeValue(" ", 708, "url(", 709, 5, true);
#line 15 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\IndexLikesReversePartial.cshtml"
WriteAttributeValue("", 713, recipe.PictureURL, 713, 18, false);

#line default
#line hidden
            WriteAttributeValue("", 731, ")", 731, 1, true);
            EndWriteAttribute();
            BeginContext(733, 10, true);
            WriteLiteral(";></div>\r\n");
            EndContext();
#line 16 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\IndexLikesReversePartial.cshtml"
      }

#line default
#line hidden
            BeginContext(752, 12, true);
            WriteLiteral("      <ul>\r\n");
            EndContext();
#line 18 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\IndexLikesReversePartial.cshtml"
         foreach(var ingredient in recipe.GetIngredients()){

#line default
#line hidden
            BeginContext(826, 14, true);
            WriteLiteral("          <li>");
            EndContext();
            BeginContext(841, 10, false);
#line 19 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\IndexLikesReversePartial.cshtml"
         Write(ingredient);

#line default
#line hidden
            EndContext();
            BeginContext(851, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 20 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\IndexLikesReversePartial.cshtml"
        }

#line default
#line hidden
            BeginContext(869, 22, true);
            WriteLiteral("      </ul>\r\n      <p>");
            EndContext();
            BeginContext(892, 14, false);
#line 22 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\IndexLikesReversePartial.cshtml"
    Write(recipe.Content);

#line default
#line hidden
            EndContext();
            BeginContext(906, 38, true);
            WriteLiteral("</p>\r\n      <p class=\"Rating\">Rating: ");
            EndContext();
            BeginContext(945, 18, false);
#line 23 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\IndexLikesReversePartial.cshtml"
                           Write(recipe.GetRating());

#line default
#line hidden
            EndContext();
            BeginContext(963, 36, true);
            WriteLiteral("</p>\r\n      <p class=\"Likes\">Likes: ");
            EndContext();
            BeginContext(1000, 18, false);
#line 24 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\IndexLikesReversePartial.cshtml"
                         Write(recipe.Likes.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1018, 45, true);
            WriteLiteral("</p>\r\n      <p class=\"postDate\">Date Posted: ");
            EndContext();
            BeginContext(1064, 39, false);
#line 25 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\IndexLikesReversePartial.cshtml"
                                  Write(recipe.CreatedAt.ToString("MM/dd/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1103, 20, true);
            WriteLiteral("</p>\r\n    </div>  \r\n");
            EndContext();
#line 27 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\IndexLikesReversePartial.cshtml"
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
