#pragma checksum "C:\Users\Venci\Desktop\New folder\SEDCRepository\sedc7-08-aspnetmvc\g4\Class 05 - Start\PizzaHut\PizzaHut\Views\PizzaType\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e0035ed2070fcab7d81ff9c9ae9dca7eeb91bee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PizzaType_Index), @"mvc.1.0.view", @"/Views/PizzaType/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/PizzaType/Index.cshtml", typeof(AspNetCore.Views_PizzaType_Index))]
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
#line 1 "C:\Users\Venci\Desktop\New folder\SEDCRepository\sedc7-08-aspnetmvc\g4\Class 05 - Start\PizzaHut\PizzaHut\Views\_ViewImports.cshtml"
using PizzaHut;

#line default
#line hidden
#line 2 "C:\Users\Venci\Desktop\New folder\SEDCRepository\sedc7-08-aspnetmvc\g4\Class 05 - Start\PizzaHut\PizzaHut\Views\_ViewImports.cshtml"
using PizzaHut.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e0035ed2070fcab7d81ff9c9ae9dca7eeb91bee", @"/Views/PizzaType/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8efdecd17e5559cbb270cc9907425448905b2398", @"/Views/_ViewImports.cshtml")]
    public class Views_PizzaType_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PizzaHut.Models.PizzaType>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Venci\Desktop\New folder\SEDCRepository\sedc7-08-aspnetmvc\g4\Class 05 - Start\PizzaHut\PizzaHut\Views\PizzaType\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(90, 24, true);
            WriteLiteral("\r\n<h2></h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(114, 72, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a93aacf7a87844c6907eb1ebf0298f9c", async() => {
                BeginContext(161, 21, true);
                WriteLiteral("Create New Pizza Type");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(186, 76, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n");
            EndContext();
            BeginContext(323, 72, true);
            WriteLiteral("                #\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(396, 40, false);
#line 20 "C:\Users\Venci\Desktop\New folder\SEDCRepository\sedc7-08-aspnetmvc\g4\Class 05 - Start\PizzaHut\PizzaHut\Views\PizzaType\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(436, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(492, 47, false);
#line 23 "C:\Users\Venci\Desktop\New folder\SEDCRepository\sedc7-08-aspnetmvc\g4\Class 05 - Start\PizzaHut\PizzaHut\Views\PizzaType\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(539, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(595, 41, false);
#line 26 "C:\Users\Venci\Desktop\New folder\SEDCRepository\sedc7-08-aspnetmvc\g4\Class 05 - Start\PizzaHut\PizzaHut\Views\PizzaType\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Photo));

#line default
#line hidden
            EndContext();
            BeginContext(636, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 32 "C:\Users\Venci\Desktop\New folder\SEDCRepository\sedc7-08-aspnetmvc\g4\Class 05 - Start\PizzaHut\PizzaHut\Views\PizzaType\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(754, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(803, 37, false);
#line 35 "C:\Users\Venci\Desktop\New folder\SEDCRepository\sedc7-08-aspnetmvc\g4\Class 05 - Start\PizzaHut\PizzaHut\Views\PizzaType\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ID));

#line default
#line hidden
            EndContext();
            BeginContext(840, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(896, 39, false);
#line 38 "C:\Users\Venci\Desktop\New folder\SEDCRepository\sedc7-08-aspnetmvc\g4\Class 05 - Start\PizzaHut\PizzaHut\Views\PizzaType\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(935, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(991, 46, false);
#line 41 "C:\Users\Venci\Desktop\New folder\SEDCRepository\sedc7-08-aspnetmvc\g4\Class 05 - Start\PizzaHut\PizzaHut\Views\PizzaType\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1037, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1093, 40, false);
#line 44 "C:\Users\Venci\Desktop\New folder\SEDCRepository\sedc7-08-aspnetmvc\g4\Class 05 - Start\PizzaHut\PizzaHut\Views\PizzaType\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Photo));

#line default
#line hidden
            EndContext();
            BeginContext(1133, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1189, 51, false);
#line 47 "C:\Users\Venci\Desktop\New folder\SEDCRepository\sedc7-08-aspnetmvc\g4\Class 05 - Start\PizzaHut\PizzaHut\Views\PizzaType\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id=item.ID }));

#line default
#line hidden
            EndContext();
            BeginContext(1240, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1261, 59, false);
#line 48 "C:\Users\Venci\Desktop\New folder\SEDCRepository\sedc7-08-aspnetmvc\g4\Class 05 - Start\PizzaHut\PizzaHut\Views\PizzaType\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { id = item.ID }));

#line default
#line hidden
            EndContext();
            BeginContext(1320, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1341, 57, false);
#line 49 "C:\Users\Venci\Desktop\New folder\SEDCRepository\sedc7-08-aspnetmvc\g4\Class 05 - Start\PizzaHut\PizzaHut\Views\PizzaType\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { id = item.ID }));

#line default
#line hidden
            EndContext();
            BeginContext(1398, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 52 "C:\Users\Venci\Desktop\New folder\SEDCRepository\sedc7-08-aspnetmvc\g4\Class 05 - Start\PizzaHut\PizzaHut\Views\PizzaType\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1437, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PizzaHut.Models.PizzaType>> Html { get; private set; }
    }
}
#pragma warning restore 1591
