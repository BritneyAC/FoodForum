#pragma checksum "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce461d062390608b2018191859e17aca7a3725e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce461d062390608b2018191859e17aca7a3725e2", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0dbefc2e8829f90b94546d276e003e26c9851cf8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FoodForum.Models.AdminRecipe>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UserRecipes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProfilePage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Recipe", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Recipes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(37, 153, true);
            WriteLiteral("\r\n<div class=\"Wrapper\">\r\n  <div class=\"Header\">\r\n    <h1>Welcome To Britney, Sam, and Hank\'s Food Blog/Recipe Forum</h1>\r\n    <div class=\"HeaderLinks\">\r\n");
            EndContext();
#line 7 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\Index.cshtml"
       if(ViewBag.User == null){

#line default
#line hidden
            BeginContext(224, 11, true);
            WriteLiteral("        <p>");
            EndContext();
            BeginContext(235, 76, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b3a9f38841b4191be7d39c9997e44c1", async() => {
                BeginContext(285, 22, true);
                WriteLiteral("User Submitted Recipes");
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
            BeginContext(311, 15, true);
            WriteLiteral("  |  \r\n        ");
            EndContext();
            BeginContext(326, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26dc1a14fbfe4e2d9017bf3fa806a5fa", async() => {
                BeginContext(370, 5, true);
                WriteLiteral("Login");
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
            BeginContext(379, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 10 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\Index.cshtml"
      } else{
        if(ViewBag.User.AdminState == 1){

#line default
#line hidden
            BeginContext(443, 58, true);
            WriteLiteral("          <p><a href=\"/AdminPage\">AdminPage</a>  |  </p>\r\n");
            EndContext();
#line 13 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(512, 11, true);
            WriteLiteral("        <p>");
            EndContext();
            BeginContext(523, 76, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e693fd7a5008460d890e17062f635187", async() => {
                BeginContext(573, 22, true);
                WriteLiteral("User Submitted Recipes");
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
            BeginContext(599, 15, true);
            WriteLiteral("  |  \r\n        ");
            EndContext();
            BeginContext(614, 121, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2170d2b37fb24ac297e5f124c0bd64aa", async() => {
                BeginContext(708, 23, true);
                WriteLiteral("Go To Your Profile Page");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Username", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 15 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\Index.cshtml"
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
            BeginContext(735, 15, true);
            WriteLiteral("  |  \r\n        ");
            EndContext();
            BeginContext(750, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ad9aaf529a64b2fb1fa96f8d98dff33", async() => {
                BeginContext(795, 6, true);
                WriteLiteral("Logout");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
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
            BeginContext(805, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 17 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\Index.cshtml"
      }

#line default
#line hidden
            BeginContext(820, 595, true);
            WriteLiteral(@"    </div>
  </div>
  <div class=""RecipeList"">
    <h2>Here you can find all of our recipes and recipes we choose as the best from the User Submissions</h2>
    <div id=""Sorting"">
      <table class=""SortingTbl"">
        <thead class=""SortingThead"">
          <tr class=""SortingTR"">
            <td class=""SortingBtn"" id=""IndexRatingReverse""><h4>Sort By Rating ↑</h4></td>
            <td class=""SortingBtn"" id=""IndexLikes""><h4>Sort by Likes ↓</h4></td>
            <td class=""SortingBtn"" id=""IndexTime""><h4>Sort By Newest</h4></td>
          </tr>
        </thead>
      </table>
");
            EndContext();
#line 32 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\Index.cshtml"
       foreach(var recipe in ViewBag.RecipesByRating){

#line default
#line hidden
            BeginContext(1471, 44, true);
            WriteLiteral("        <div class=\"Recipe\">\r\n          <h3>");
            EndContext();
            BeginContext(1515, 97, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a797d46a051c40f2818642ec5bc7118f", async() => {
                BeginContext(1596, 12, false);
#line 34 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\Index.cshtml"
                                                                                         Write(recipe.Title);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Title", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 34 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\Index.cshtml"
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
            BeginContext(1612, 24, true);
            WriteLiteral("</h3>\r\n          <h5>By ");
            EndContext();
            BeginContext(1637, 20, false);
#line 35 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\Index.cshtml"
            Write(recipe.User.Username);

#line default
#line hidden
            EndContext();
            BeginContext(1657, 7, true);
            WriteLiteral("</h5>\r\n");
            EndContext();
#line 36 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\Index.cshtml"
           if(recipe.PictureURL != null){

#line default
#line hidden
            BeginContext(1707, 42, true);
            WriteLiteral("            <div class=\"RecipeListPicture\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 1749, "\"", 1798, 4);
            WriteAttributeValue("", 1757, "background-image:", 1757, 17, true);
            WriteAttributeValue(" ", 1774, "url(", 1775, 5, true);
#line 37 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\Index.cshtml"
WriteAttributeValue("", 1779, recipe.PictureURL, 1779, 18, false);

#line default
#line hidden
            WriteAttributeValue("", 1797, ")", 1797, 1, true);
            EndWriteAttribute();
            BeginContext(1799, 10, true);
            WriteLiteral(";></div>\r\n");
            EndContext();
#line 38 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\Index.cshtml"
          }

#line default
#line hidden
            BeginContext(1822, 16, true);
            WriteLiteral("          <ul>\r\n");
            EndContext();
#line 40 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\Index.cshtml"
             foreach(var ingredient in recipe.GetIngredients()){

#line default
#line hidden
            BeginContext(1904, 18, true);
            WriteLiteral("              <li>");
            EndContext();
            BeginContext(1923, 10, false);
#line 41 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\Index.cshtml"
             Write(ingredient);

#line default
#line hidden
            EndContext();
            BeginContext(1933, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 42 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1955, 30, true);
            WriteLiteral("          </ul>\r\n          <p>");
            EndContext();
            BeginContext(1986, 14, false);
#line 44 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\Index.cshtml"
        Write(recipe.Content);

#line default
#line hidden
            EndContext();
            BeginContext(2000, 42, true);
            WriteLiteral("</p>\r\n          <p class=\"Rating\">Rating: ");
            EndContext();
            BeginContext(2043, 18, false);
#line 45 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\Index.cshtml"
                               Write(recipe.GetRating());

#line default
#line hidden
            EndContext();
            BeginContext(2061, 40, true);
            WriteLiteral("</p>\r\n          <p class=\"Likes\">Likes: ");
            EndContext();
            BeginContext(2102, 18, false);
#line 46 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\Index.cshtml"
                             Write(recipe.Likes.Count);

#line default
#line hidden
            EndContext();
            BeginContext(2120, 49, true);
            WriteLiteral("</p>\r\n          <p class=\"postDate\">Date Posted: ");
            EndContext();
            BeginContext(2170, 39, false);
#line 47 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\Index.cshtml"
                                      Write(recipe.CreatedAt.ToString("MM/dd/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(2209, 24, true);
            WriteLiteral("</p>\r\n        </div>  \r\n");
            EndContext();
#line 49 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\Home\Index.cshtml"
      }

#line default
#line hidden
            BeginContext(2242, 28, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FoodForum.Models.AdminRecipe> Html { get; private set; }
    }
}
#pragma warning restore 1591
