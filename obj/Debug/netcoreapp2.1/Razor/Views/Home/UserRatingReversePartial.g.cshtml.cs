#pragma checksum "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\UserRatingReversePartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6d4bce66cde82b4446573e06693556ddc1cc3a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_UserRatingReversePartial), @"mvc.1.0.view", @"/Views/Home/UserRatingReversePartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/UserRatingReversePartial.cshtml", typeof(AspNetCore.Views_Home_UserRatingReversePartial))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6d4bce66cde82b4446573e06693556ddc1cc3a0", @"/Views/Home/UserRatingReversePartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0dbefc2e8829f90b94546d276e003e26c9851cf8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_UserRatingReversePartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            BeginContext(0, 364, true);
            WriteLiteral(@"  <table class=""SortingTbl"">
    <thead class=""SortingThead"">
      <tr class=""SortingTR"">
        <td class=""SortingBtn"" id=""UserRating""><h4>Sort By Rating ↓</h4></td>
        <td class=""SortingBtn"" id=""UserLikes""><h4>Sort By Likes ↓</h4></td>
        <td class=""SortingBtn"" id=""UserTime""><h4>Sort By Newest</h4></td>
      </tr>
    </thead>
  </table>
");
            EndContext();
#line 10 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\UserRatingReversePartial.cshtml"
   foreach(var recipe in ViewBag.RecipesByRatingReverse){

#line default
#line hidden
            BeginContext(423, 36, true);
            WriteLiteral("    <div class=\"Recipe\">\r\n      <h3>");
            EndContext();
            BeginContext(459, 97, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e110c0dd167b49068459d48563e9be0a", async() => {
                BeginContext(540, 12, false);
#line 12 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\UserRatingReversePartial.cshtml"
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
#line 12 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\UserRatingReversePartial.cshtml"
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
            BeginContext(556, 20, true);
            WriteLiteral("</h3>\r\n      <h5>By ");
            EndContext();
            BeginContext(577, 20, false);
#line 13 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\UserRatingReversePartial.cshtml"
        Write(recipe.User.Username);

#line default
#line hidden
            EndContext();
            BeginContext(597, 7, true);
            WriteLiteral("</h5>\r\n");
            EndContext();
#line 14 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\UserRatingReversePartial.cshtml"
       if(recipe.PictureURL != null){

#line default
#line hidden
            BeginContext(643, 38, true);
            WriteLiteral("        <div class=\"RecipeListPicture\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 681, "\"", 730, 4);
            WriteAttributeValue("", 689, "background-image:", 689, 17, true);
            WriteAttributeValue(" ", 706, "url(", 707, 5, true);
#line 15 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\UserRatingReversePartial.cshtml"
WriteAttributeValue("", 711, recipe.PictureURL, 711, 18, false);

#line default
#line hidden
            WriteAttributeValue("", 729, ")", 729, 1, true);
            EndWriteAttribute();
            BeginContext(731, 10, true);
            WriteLiteral(";></div>\r\n");
            EndContext();
#line 16 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\UserRatingReversePartial.cshtml"
      }

#line default
#line hidden
            BeginContext(750, 12, true);
            WriteLiteral("      <ul>\r\n");
            EndContext();
#line 18 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\UserRatingReversePartial.cshtml"
         foreach(var ingredient in recipe.GetIngredients()){

#line default
#line hidden
            BeginContext(824, 14, true);
            WriteLiteral("          <li>");
            EndContext();
            BeginContext(839, 10, false);
#line 19 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\UserRatingReversePartial.cshtml"
         Write(ingredient);

#line default
#line hidden
            EndContext();
            BeginContext(849, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 20 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\UserRatingReversePartial.cshtml"
        }

#line default
#line hidden
            BeginContext(867, 22, true);
            WriteLiteral("      </ul>\r\n      <p>");
            EndContext();
            BeginContext(890, 14, false);
#line 22 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\UserRatingReversePartial.cshtml"
    Write(recipe.Content);

#line default
#line hidden
            EndContext();
            BeginContext(904, 38, true);
            WriteLiteral("</p>\r\n      <p class=\"Rating\">Rating: ");
            EndContext();
            BeginContext(943, 18, false);
#line 23 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\UserRatingReversePartial.cshtml"
                           Write(recipe.GetRating());

#line default
#line hidden
            EndContext();
            BeginContext(961, 36, true);
            WriteLiteral("</p>\r\n      <p class=\"Likes\">Likes: ");
            EndContext();
            BeginContext(998, 18, false);
#line 24 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\UserRatingReversePartial.cshtml"
                         Write(recipe.Likes.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1016, 45, true);
            WriteLiteral("</p>\r\n      <p class=\"postDate\">Date Posted: ");
            EndContext();
            BeginContext(1062, 39, false);
#line 25 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\UserRatingReversePartial.cshtml"
                                  Write(recipe.CreatedAt.ToString("MM/dd/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1101, 20, true);
            WriteLiteral("</p>\r\n    </div>  \r\n");
            EndContext();
#line 27 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\UserRatingReversePartial.cshtml"
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
