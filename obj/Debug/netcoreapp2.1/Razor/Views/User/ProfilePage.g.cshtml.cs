#pragma checksum "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\User\ProfilePage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8f1b10ec1278d594144d53d1891de0c582a06c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_ProfilePage), @"mvc.1.0.view", @"/Views/User/ProfilePage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/ProfilePage.cshtml", typeof(AspNetCore.Views_User_ProfilePage))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8f1b10ec1278d594144d53d1891de0c582a06c2", @"/Views/User/ProfilePage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0dbefc2e8829f90b94546d276e003e26c9851cf8", @"/Views/_ViewImports.cshtml")]
    public class Views_User_ProfilePage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Recipe", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Recipes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 55, true);
            WriteLiteral("<div class=\"Wrapper\">\r\n  <div class=\"Header\">\r\n    <h1>");
            EndContext();
            BeginContext(56, 21, false);
#line 3 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\User\ProfilePage.cshtml"
   Write(ViewBag.User.Username);

#line default
#line hidden
            EndContext();
            BeginContext(77, 59, true);
            WriteLiteral("\'s Account Page</h1>\r\n    <div class=\"HeaderLinks\">\r\n      ");
            EndContext();
            BeginContext(136, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a7416c04e8249ea8f801b756b4b45b7", async() => {
                BeginContext(180, 4, true);
                WriteLiteral("Home");
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
            BeginContext(188, 7, true);
            WriteLiteral("  |  \r\n");
            EndContext();
#line 6 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\User\ProfilePage.cshtml"
       if(ViewBag.CurrentUser == null){

#line default
#line hidden
            BeginContext(236, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(244, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ad64e1de47048abb3a053fd99f8131e", async() => {
                BeginContext(288, 5, true);
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
            BeginContext(297, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 8 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\User\ProfilePage.cshtml"
      } else{

#line default
#line hidden
            BeginContext(314, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(322, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f16d19cc78a541b9a9e0140b069e60aa", async() => {
                BeginContext(367, 6, true);
                WriteLiteral("Logout");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
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
            BeginContext(377, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 10 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\User\ProfilePage.cshtml"
      }

#line default
#line hidden
            BeginContext(388, 161, true);
            WriteLiteral("    </div>\r\n  </div>\r\n  <div class=\"RecipeList\">\r\n    <h2>Here you can find all of our recipes and recipes we choose as the best from the User Submissions</h2>\r\n");
            EndContext();
#line 15 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\User\ProfilePage.cshtml"
     foreach(var recipe in ViewBag.LikedRecipes){

#line default
#line hidden
            BeginContext(600, 40, true);
            WriteLiteral("      <div class=\"Recipe\">\r\n        <h3>");
            EndContext();
            BeginContext(640, 111, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9847156eb7ed427a9e32ce3be75d7b36", async() => {
                BeginContext(728, 19, false);
#line 17 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\User\ProfilePage.cshtml"
                                                                                              Write(recipe.Recipe.Title);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Title", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 17 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\User\ProfilePage.cshtml"
                                                                 WriteLiteral(recipe.Recipe.Title);

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
            BeginContext(751, 22, true);
            WriteLiteral("</h3>\r\n        <h5>By ");
            EndContext();
            BeginContext(774, 20, false);
#line 18 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\User\ProfilePage.cshtml"
          Write(recipe.User.Username);

#line default
#line hidden
            EndContext();
            BeginContext(794, 7, true);
            WriteLiteral("</h5>\r\n");
            EndContext();
#line 19 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\User\ProfilePage.cshtml"
         if(recipe.Recipe.PictureURL != null){

#line default
#line hidden
            BeginContext(849, 40, true);
            WriteLiteral("          <div class=\"RecipeListPicture\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 889, "\"", 945, 4);
            WriteAttributeValue("", 897, "background-image:", 897, 17, true);
            WriteAttributeValue(" ", 914, "url(", 915, 5, true);
#line 20 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\User\ProfilePage.cshtml"
WriteAttributeValue("", 919, recipe.Recipe.PictureURL, 919, 25, false);

#line default
#line hidden
            WriteAttributeValue("", 944, ")", 944, 1, true);
            EndWriteAttribute();
            BeginContext(946, 10, true);
            WriteLiteral(";></div>\r\n");
            EndContext();
#line 21 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\User\ProfilePage.cshtml"
        }

#line default
#line hidden
            BeginContext(967, 14, true);
            WriteLiteral("        <ul>\r\n");
            EndContext();
#line 23 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\User\ProfilePage.cshtml"
           foreach(var ingredient in recipe.Recipe.GetIngredients()){

#line default
#line hidden
            BeginContext(1052, 16, true);
            WriteLiteral("            <li>");
            EndContext();
            BeginContext(1069, 10, false);
#line 24 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\User\ProfilePage.cshtml"
           Write(ingredient);

#line default
#line hidden
            EndContext();
            BeginContext(1079, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 25 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\User\ProfilePage.cshtml"
          }

#line default
#line hidden
            BeginContext(1099, 26, true);
            WriteLiteral("        </ul>\r\n        <p>");
            EndContext();
            BeginContext(1126, 21, false);
#line 27 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\User\ProfilePage.cshtml"
      Write(recipe.Recipe.Content);

#line default
#line hidden
            EndContext();
            BeginContext(1147, 40, true);
            WriteLiteral("</p>\r\n        <p class=\"Rating\">Rating: ");
            EndContext();
            BeginContext(1188, 25, false);
#line 28 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\User\ProfilePage.cshtml"
                             Write(recipe.Recipe.GetRating());

#line default
#line hidden
            EndContext();
            BeginContext(1213, 38, true);
            WriteLiteral("</p>\r\n        <p class=\"Likes\">Likes: ");
            EndContext();
            BeginContext(1252, 25, false);
#line 29 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\User\ProfilePage.cshtml"
                           Write(recipe.Recipe.Likes.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1277, 47, true);
            WriteLiteral("</p>\r\n        <p class=\"postDate\">Date Posted: ");
            EndContext();
            BeginContext(1325, 46, false);
#line 30 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\User\ProfilePage.cshtml"
                                    Write(recipe.Recipe.CreatedAt.ToString("MM/dd/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1371, 22, true);
            WriteLiteral("</p>\r\n      </div>  \r\n");
            EndContext();
#line 32 "C:\Users\Britney\Documents\CodingDojoWork\C#\FoodForum\Views\User\ProfilePage.cshtml"
    }

#line default
#line hidden
            BeginContext(1400, 16, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
