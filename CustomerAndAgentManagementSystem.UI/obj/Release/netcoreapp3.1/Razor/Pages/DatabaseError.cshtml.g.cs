#pragma checksum "C:\Users\Dad S. Wonkulah Jr\source\repos\CustomerAndAgentManagementSystem\CustomerAndAgentManagementSystem.UI\Pages\DatabaseError.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ef861d60d2dace67322553eba09a7f6042ca190"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CustomerAndAgentManagementSystem.UI.Pages.Pages_DatabaseError), @"mvc.1.0.razor-page", @"/Pages/DatabaseError.cshtml")]
namespace CustomerAndAgentManagementSystem.UI.Pages
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
#line 1 "C:\Users\Dad S. Wonkulah Jr\source\repos\CustomerAndAgentManagementSystem\CustomerAndAgentManagementSystem.UI\Pages\_ViewImports.cshtml"
using CustomerAndAgentManagementSystem.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dad S. Wonkulah Jr\source\repos\CustomerAndAgentManagementSystem\CustomerAndAgentManagementSystem.UI\Pages\_ViewImports.cshtml"
using CustomerAndAgentManagementSystem.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Dad S. Wonkulah Jr\source\repos\CustomerAndAgentManagementSystem\CustomerAndAgentManagementSystem.UI\Pages\_ViewImports.cshtml"
using CustomerAndAgentManagementSystem.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ef861d60d2dace67322553eba09a7f6042ca190", @"/Pages/DatabaseError.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5e699aa78b1a17bd091e8a06d689aa328f942ae", @"/Pages/_ViewImports.cshtml")]
    public class Pages_DatabaseError : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/AgentList/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
#nullable restore
#line 3 "C:\Users\Dad S. Wonkulah Jr\source\repos\CustomerAndAgentManagementSystem\CustomerAndAgentManagementSystem.UI\Pages\DatabaseError.cshtml"
  
    ViewData["Title"] = "Cannot delete an agent";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h2 class=""display-4 mt-2"">
   Not Possiable<i class=""oi oi-delete"" style=""font-size:40px""></i>
</h2>
<hr />
<div class=""alert alert-danger"">
    <h5>
        Sorry!
    </h5>
    <hr />
    <p>
        You cannot delete an agent who is already asigned 
        to a customer, remember what i told you in the about the project 
        page. the relationship won't allow us do that, thanks for you understanding!
    </p>
</div>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ef861d60d2dace67322553eba09a7f6042ca1905007", async() => {
                WriteLiteral("\r\n    Click on the link to go back to the agent list\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CustomerAndAgentManagementSystem.UI.Pages.DatabaseErrorModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CustomerAndAgentManagementSystem.UI.Pages.DatabaseErrorModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CustomerAndAgentManagementSystem.UI.Pages.DatabaseErrorModel>)PageContext?.ViewData;
        public CustomerAndAgentManagementSystem.UI.Pages.DatabaseErrorModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591