#pragma checksum "/Users/alexvahrusev/Downloads/Week07 - Hunt/Week07/ContosoUniversityRazorProject/Pages/Departments/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7683fef5fcd09fecb48e7b08368b31f67978baa5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ContosoUniversityRazorProject.Pages.Departments.Pages_Departments_Details), @"mvc.1.0.razor-page", @"/Pages/Departments/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Departments/Details.cshtml", typeof(ContosoUniversityRazorProject.Pages.Departments.Pages_Departments_Details), null)]
namespace ContosoUniversityRazorProject.Pages.Departments
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/Users/alexvahrusev/Downloads/Week07 - Hunt/Week07/ContosoUniversityRazorProject/Pages/_ViewImports.cshtml"
using ContosoUniversityRazorProject;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7683fef5fcd09fecb48e7b08368b31f67978baa5", @"/Pages/Departments/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0b71937d60ddc9798266e125a08cde483ccf049", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Departments_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(76, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "/Users/alexvahrusev/Downloads/Week07 - Hunt/Week07/ContosoUniversityRazorProject/Pages/Departments/Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(121, 124, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Department</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(246, 51, false);
#line 15 "/Users/alexvahrusev/Downloads/Week07 - Hunt/Week07/ContosoUniversityRazorProject/Pages/Departments/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Department.Name));

#line default
#line hidden
            EndContext();
            BeginContext(297, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(341, 47, false);
#line 18 "/Users/alexvahrusev/Downloads/Week07 - Hunt/Week07/ContosoUniversityRazorProject/Pages/Departments/Details.cshtml"
       Write(Html.DisplayFor(model => model.Department.Name));

#line default
#line hidden
            EndContext();
            BeginContext(388, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(432, 53, false);
#line 21 "/Users/alexvahrusev/Downloads/Week07 - Hunt/Week07/ContosoUniversityRazorProject/Pages/Departments/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Department.Budget));

#line default
#line hidden
            EndContext();
            BeginContext(485, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(529, 49, false);
#line 24 "/Users/alexvahrusev/Downloads/Week07 - Hunt/Week07/ContosoUniversityRazorProject/Pages/Departments/Details.cshtml"
       Write(Html.DisplayFor(model => model.Department.Budget));

#line default
#line hidden
            EndContext();
            BeginContext(578, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(622, 56, false);
#line 27 "/Users/alexvahrusev/Downloads/Week07 - Hunt/Week07/ContosoUniversityRazorProject/Pages/Departments/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Department.StartDate));

#line default
#line hidden
            EndContext();
            BeginContext(678, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(722, 52, false);
#line 30 "/Users/alexvahrusev/Downloads/Week07 - Hunt/Week07/ContosoUniversityRazorProject/Pages/Departments/Details.cshtml"
       Write(Html.DisplayFor(model => model.Department.StartDate));

#line default
#line hidden
            EndContext();
            BeginContext(774, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(818, 57, false);
#line 33 "/Users/alexvahrusev/Downloads/Week07 - Hunt/Week07/ContosoUniversityRazorProject/Pages/Departments/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Department.RowVersion));

#line default
#line hidden
            EndContext();
            BeginContext(875, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(919, 53, false);
#line 36 "/Users/alexvahrusev/Downloads/Week07 - Hunt/Week07/ContosoUniversityRazorProject/Pages/Departments/Details.cshtml"
       Write(Html.DisplayFor(model => model.Department.RowVersion));

#line default
#line hidden
            EndContext();
            BeginContext(972, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1016, 60, false);
#line 39 "/Users/alexvahrusev/Downloads/Week07 - Hunt/Week07/ContosoUniversityRazorProject/Pages/Departments/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Department.Administrator));

#line default
#line hidden
            EndContext();
            BeginContext(1076, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1120, 69, false);
#line 42 "/Users/alexvahrusev/Downloads/Week07 - Hunt/Week07/ContosoUniversityRazorProject/Pages/Departments/Details.cshtml"
       Write(Html.DisplayFor(model => model.Department.Administrator.FirstMidName));

#line default
#line hidden
            EndContext();
            BeginContext(1189, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1236, 75, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af3df778995248a6bd079f89f139ed24", async() => {
                BeginContext(1303, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 47 "/Users/alexvahrusev/Downloads/Week07 - Hunt/Week07/ContosoUniversityRazorProject/Pages/Departments/Details.cshtml"
                           WriteLiteral(Model.Department.DepartmentID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1311, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1319, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8856d4e6a930445092853cd3af1fe3e4", async() => {
                BeginContext(1341, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1357, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContosoUniversityRazorProject.Pages.Departments.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ContosoUniversityRazorProject.Pages.Departments.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ContosoUniversityRazorProject.Pages.Departments.DetailsModel>)PageContext?.ViewData;
        public ContosoUniversityRazorProject.Pages.Departments.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
