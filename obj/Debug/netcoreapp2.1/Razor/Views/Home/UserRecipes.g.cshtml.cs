#pragma checksum "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\UserRecipes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7375fe916a62ea92415450abbc52135baffd6ae8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_UserRecipes), @"mvc.1.0.view", @"/Views/Home/UserRecipes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/UserRecipes.cshtml", typeof(AspNetCore.Views_Home_UserRecipes))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7375fe916a62ea92415450abbc52135baffd6ae8", @"/Views/Home/UserRecipes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0dbefc2e8829f90b94546d276e003e26c9851cf8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_UserRecipes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FoodForum.Models.UserRecipe>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "NewUserRecipe", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "UserRecipes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProfilePage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UserRecipe", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(36, 145, true);
            WriteLiteral("\r\n<div class=\"Header\">\r\n  <h1>Welcome To Britney, Sam, and Hank\'s Mostly Vegan Food Blog/Forum</h1>\r\n  <div class=\"HeaderLinks\">\r\n    <p>\r\n      ");
            EndContext();
            BeginContext(181, 72, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9970f453d9749b0b1de40d9dc397318", async() => {
                BeginContext(225, 24, true);
                WriteLiteral("Back to our curated list");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(253, 7, true);
            WriteLiteral("  |  \r\n");
            EndContext();
#line 8 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\UserRecipes.cshtml"
       if (ViewBag.User != null){

#line default
#line hidden
            BeginContext(295, 11, true);
            WriteLiteral("        <p>");
            EndContext();
            BeginContext(306, 80, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "471eed5e85e049a583bdb3f73427c91f", async() => {
                BeginContext(365, 17, true);
                WriteLiteral("Post A New Recipe");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(386, 15, true);
            WriteLiteral("  |  \r\n        ");
            EndContext();
            BeginContext(401, 121, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e94bfe941d24e9f8c0a833f976c7257", async() => {
                BeginContext(495, 23, true);
                WriteLiteral("Go To Your Profile Page");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Username", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 10 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\UserRecipes.cshtml"
                                                                  WriteLiteral(ViewBag.User.Username);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Username"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Username", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Username"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(522, 15, true);
            WriteLiteral("  |  \r\n        ");
            EndContext();
            BeginContext(537, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "423d81390c1b497b91566efc2dd89ae9", async() => {
                BeginContext(582, 6, true);
                WriteLiteral("Logout");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(592, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 12 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\UserRecipes.cshtml"
      } else{

#line default
#line hidden
            BeginContext(613, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(621, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7a80066fbc34a3db0105256212ce075", async() => {
                BeginContext(665, 5, true);
                WriteLiteral("Login");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(674, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 14 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\UserRecipes.cshtml"
      }

#line default
#line hidden
            BeginContext(685, 553, true);
            WriteLiteral(@"    </p>
  </div>
</div>
  <div class=""RecipeList"">
    <h2>Here you can find all of the User Submitted Recipes</h2>
    <div id=""Sorting"">
      <table class=""SortingTbl"">
        <thead class=""SortingThead"">
          <tr class=""SortingTR"">
            <td class=""SortingBtn"" id=""UserRatingReverse""><h4>Sort By Rating ↑</h4></td>
            <td class=""SortingBtn"" id=""UserLikes""><h4>Sort By Likes ↓</h4></td>
            <td class=""SortingBtn"" id=""UserTime""><h4>Sort By Newest</h4></td>
          </tr>
        </thead>
      </table>
");
            EndContext();
#line 30 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\UserRecipes.cshtml"
       foreach(var recipe in ViewBag.RecipesByRating){

#line default
#line hidden
            BeginContext(1294, 44, true);
            WriteLiteral("        <div class=\"Recipe\">\r\n          <h3>");
            EndContext();
            BeginContext(1338, 105, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f9249cf96234cc1a5046154ca11d593", async() => {
                BeginContext(1427, 12, false);
#line 32 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\UserRecipes.cshtml"
                                                                                                 Write(recipe.Title);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Title", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 32 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\UserRecipes.cshtml"
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
            BeginContext(1443, 24, true);
            WriteLiteral("</h3>\r\n          <h5>By ");
            EndContext();
            BeginContext(1468, 20, false);
#line 33 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\UserRecipes.cshtml"
            Write(recipe.User.Username);

#line default
#line hidden
            EndContext();
            BeginContext(1488, 7, true);
            WriteLiteral("</h5>\r\n");
            EndContext();
#line 34 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\UserRecipes.cshtml"
           if(recipe.PictureURL != null){

#line default
#line hidden
            BeginContext(1538, 42, true);
            WriteLiteral("            <div class=\"RecipeListPicture\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 1580, "\"", 1629, 4);
            WriteAttributeValue("", 1588, "background-image:", 1588, 17, true);
            WriteAttributeValue(" ", 1605, "url(", 1606, 5, true);
#line 35 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\UserRecipes.cshtml"
WriteAttributeValue("", 1610, recipe.PictureURL, 1610, 18, false);

#line default
#line hidden
            WriteAttributeValue("", 1628, ")", 1628, 1, true);
            EndWriteAttribute();
            BeginContext(1630, 10, true);
            WriteLiteral(";></div>\r\n");
            EndContext();
#line 36 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\UserRecipes.cshtml"
          }

#line default
#line hidden
            BeginContext(1653, 16, true);
            WriteLiteral("          <ul>\r\n");
            EndContext();
#line 38 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\UserRecipes.cshtml"
             foreach(var ingredient in recipe.GetIngredients()){

#line default
#line hidden
            BeginContext(1735, 18, true);
            WriteLiteral("              <li>");
            EndContext();
            BeginContext(1754, 10, false);
#line 39 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\UserRecipes.cshtml"
             Write(ingredient);

#line default
#line hidden
            EndContext();
            BeginContext(1764, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 40 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\UserRecipes.cshtml"
            }

#line default
#line hidden
            BeginContext(1786, 30, true);
            WriteLiteral("          </ul>\r\n          <p>");
            EndContext();
            BeginContext(1817, 14, false);
#line 42 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\UserRecipes.cshtml"
        Write(recipe.Content);

#line default
#line hidden
            EndContext();
            BeginContext(1831, 42, true);
            WriteLiteral("</p>\r\n          <p class=\"Rating\">Rating: ");
            EndContext();
            BeginContext(1874, 18, false);
#line 43 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\UserRecipes.cshtml"
                               Write(recipe.GetRating());

#line default
#line hidden
            EndContext();
            BeginContext(1892, 40, true);
            WriteLiteral("</p>\r\n          <p class=\"Likes\">Likes: ");
            EndContext();
            BeginContext(1933, 18, false);
#line 44 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\UserRecipes.cshtml"
                             Write(recipe.Likes.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1951, 49, true);
            WriteLiteral("</p>\r\n          <p class=\"postDate\">Date Posted: ");
            EndContext();
            BeginContext(2001, 39, false);
#line 45 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\UserRecipes.cshtml"
                                      Write(recipe.CreatedAt.ToString("MM/dd/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(2040, 24, true);
            WriteLiteral("</p>\r\n        </div>  \r\n");
            EndContext();
#line 47 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\UserRecipes.cshtml"
      }

#line default
#line hidden
            BeginContext(2073, 16, true);
            WriteLiteral("  </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FoodForum.Models.UserRecipe> Html { get; private set; }
    }
}
#pragma warning restore 1591
