#pragma checksum "/Users/thekidnamedkd/Desktop/RestaurantFinder.Solution/App/Views/Cuisines/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7ee652a86c63359031462aab5e14660da1543be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cuisines_Create), @"mvc.1.0.view", @"/Views/Cuisines/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cuisines/Create.cshtml", typeof(AspNetCore.Views_Cuisines_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7ee652a86c63359031462aab5e14660da1543be", @"/Views/Cuisines/Create.cshtml")]
    public class Views_Cuisines_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FoodFinder.Models.Cuisine>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/thekidnamedkd/Desktop/RestaurantFinder.Solution/App/Views/Cuisines/Create.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(61, 33, true);
            WriteLiteral("\n<legend>Add a Cuisine</legend>\n\n");
            EndContext();
#line 9 "/Users/thekidnamedkd/Desktop/RestaurantFinder.Solution/App/Views/Cuisines/Create.cshtml"
 using(Html.BeginForm())
{
  

#line default
#line hidden
            BeginContext(124, 34, false);
#line 11 "/Users/thekidnamedkd/Desktop/RestaurantFinder.Solution/App/Views/Cuisines/Create.cshtml"
Write(Html.LabelFor(model => model.Type));

#line default
#line hidden
            EndContext();
            BeginContext(162, 36, false);
#line 12 "/Users/thekidnamedkd/Desktop/RestaurantFinder.Solution/App/Views/Cuisines/Create.cshtml"
Write(Html.TextBoxFor(model => model.Type));

#line default
#line hidden
            EndContext();
            BeginContext(199, 52, true);
            WriteLiteral("  <input type=\"submit\" value=\"Add a new Cuisine\" />\n");
            EndContext();
#line 14 "/Users/thekidnamedkd/Desktop/RestaurantFinder.Solution/App/Views/Cuisines/Create.cshtml"

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FoodFinder.Models.Cuisine> Html { get; private set; }
    }
}
#pragma warning restore 1591