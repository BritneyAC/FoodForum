#pragma checksum "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\UserRecipes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e5eb58753208ed2099c39fd605667e3d3c3c3b3"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e5eb58753208ed2099c39fd605667e3d3c3c3b3", @"/Views/Home/UserRecipes.cshtml")]
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
            BeginContext(36, 178, true);
            WriteLiteral("\r\n<div class=\"Wrapper\">\r\n  <div class=\"Header\">\r\n    <h2>Welcome To Britney, Sam, and Hank\'s Mostly Vegan Food Blog/Forum</h2>\r\n    <div class=\"HeaderLinks\">\r\n      <p>\r\n        ");
            EndContext();
            BeginContext(214, 72, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c6273db9eb34ce0813057fa6c8538d2", async() => {
                BeginContext(258, 24, true);
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
            BeginContext(286, 7, true);
            WriteLiteral("  |  \r\n");
            EndContext();
#line 9 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\UserRecipes.cshtml"
         if (ViewBag.User != null){

#line default
#line hidden
            BeginContext(330, 13, true);
            WriteLiteral("          <p>");
            EndContext();
            BeginContext(343, 80, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90da9c248cce4a2994e14db4b65bf4cc", async() => {
                BeginContext(402, 17, true);
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
            BeginContext(423, 19, true);
            WriteLiteral("  |  \r\n            ");
            EndContext();
            BeginContext(442, 121, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb2c061e40b249b7af0786b210dd93bf", async() => {
                BeginContext(536, 23, true);
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
#line 11 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\UserRecipes.cshtml"
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
            BeginContext(563, 19, true);
            WriteLiteral("  |  \r\n            ");
            EndContext();
            BeginContext(582, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1fcf638a0db4470a94b044e54fdb5011", async() => {
                BeginContext(627, 6, true);
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
            BeginContext(637, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 13 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\UserRecipes.cshtml"
          } else{

#line default
#line hidden
            BeginContext(662, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(674, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d14b7aedb66942ca9f446a3f9d09b6f7", async() => {
                BeginContext(718, 5, true);
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
            BeginContext(727, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 15 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\UserRecipes.cshtml"
          }

#line default
#line hidden
            BeginContext(742, 565, true);
            WriteLiteral(@"        </p>
      </div>
  </div>
  <div class=""RecipeList"">
    <div id=""Sorting"">
      <h3>Here you can find all of the User Submitted Recipes</h3>
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
#line 31 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\UserRecipes.cshtml"
       foreach(var recipe in ViewBag.RecipesByRating){

#line default
#line hidden
            BeginContext(1363, 44, true);
            WriteLiteral("        <div class=\"Recipe\">\r\n          <h3>");
            EndContext();
            BeginContext(1407, 105, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f49cc156b8c444c831acd90848be239", async() => {
                BeginContext(1496, 12, false);
#line 33 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\UserRecipes.cshtml"
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
#line 33 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\UserRecipes.cshtml"
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
            BeginContext(1512, 24, true);
            WriteLiteral("</h3>\r\n          <h5>By ");
            EndContext();
            BeginContext(1537, 20, false);
#line 34 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\UserRecipes.cshtml"
            Write(recipe.User.Username);

#line default
#line hidden
            EndContext();
            BeginContext(1557, 7, true);
            WriteLiteral("</h5>\r\n");
            EndContext();
#line 35 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\UserRecipes.cshtml"
           if(recipe.PictureURL != null){

#line default
#line hidden
            BeginContext(1607, 99, true);
            WriteLiteral("            <div class=\"RecipeListPictureBackground\">\r\n              <div class=\"RecipeListPicture\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 1706, "\"", 1755, 4);
            WriteAttributeValue("", 1714, "background-image:", 1714, 17, true);
            WriteAttributeValue(" ", 1731, "url(", 1732, 5, true);
#line 37 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\UserRecipes.cshtml"
WriteAttributeValue("", 1736, recipe.PictureURL, 1736, 18, false);

#line default
#line hidden
            WriteAttributeValue("", 1754, ")", 1754, 1, true);
            EndWriteAttribute();
            BeginContext(1756, 30, true);
            WriteLiteral(";></div>\r\n            </div>\r\n");
            EndContext();
#line 39 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\UserRecipes.cshtml"
          }

#line default
#line hidden
            BeginContext(1799, 16, true);
            WriteLiteral("          <ul>\r\n");
            EndContext();
#line 41 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\UserRecipes.cshtml"
             foreach(var ingredient in recipe.GetIngredients()){

#line default
#line hidden
            BeginContext(1881, 18, true);
            WriteLiteral("              <li>");
            EndContext();
            BeginContext(1900, 10, false);
#line 42 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\UserRecipes.cshtml"
             Write(ingredient);

#line default
#line hidden
            EndContext();
            BeginContext(1910, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 43 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\UserRecipes.cshtml"
            }

#line default
#line hidden
            BeginContext(1932, 46, true);
            WriteLiteral("          </ul>\r\n          <p class=\"Content\">");
            EndContext();
            BeginContext(1979, 14, false);
#line 45 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\UserRecipes.cshtml"
                        Write(recipe.Content);

#line default
#line hidden
            EndContext();
            BeginContext(1993, 46, true);
            WriteLiteral("</p><br>\r\n          <p class=\"Rating\">Rating: ");
            EndContext();
            BeginContext(2040, 18, false);
#line 46 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\UserRecipes.cshtml"
                               Write(recipe.GetRating());

#line default
#line hidden
            EndContext();
            BeginContext(2058, 40, true);
            WriteLiteral("</p>\r\n          <p class=\"Likes\">Likes: ");
            EndContext();
            BeginContext(2099, 18, false);
#line 47 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\UserRecipes.cshtml"
                             Write(recipe.Likes.Count);

#line default
#line hidden
            EndContext();
            BeginContext(2117, 49, true);
            WriteLiteral("</p>\r\n          <p class=\"PostDate\">Date Posted: ");
            EndContext();
            BeginContext(2167, 39, false);
#line 48 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\UserRecipes.cshtml"
                                      Write(recipe.CreatedAt.ToString("MM/dd/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(2206, 24, true);
            WriteLiteral("</p>\r\n        </div>  \r\n");
            EndContext();
#line 50 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\UserRecipes.cshtml"
      }

#line default
#line hidden
            BeginContext(2239, 28, true);
            WriteLiteral("    </div>\r\n  </div>\r\n</div>");
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
