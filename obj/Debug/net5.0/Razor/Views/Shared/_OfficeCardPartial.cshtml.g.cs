#pragma checksum "C:\Users\gnoul\Synced Folder\Google Drive\Web\_webapp\VNPT_Review\Views\Shared\_OfficeCardPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23555e9942a19b229ce216d424139d97a06bb1e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__OfficeCardPartial), @"mvc.1.0.view", @"/Views/Shared/_OfficeCardPartial.cshtml")]
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
#nullable restore
#line 1 "C:\Users\gnoul\Synced Folder\Google Drive\Web\_webapp\VNPT_Review\Views\_ViewImports.cshtml"
using VNPT_Review;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gnoul\Synced Folder\Google Drive\Web\_webapp\VNPT_Review\Views\_ViewImports.cshtml"
using VNPT_Review.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23555e9942a19b229ce216d424139d97a06bb1e7", @"/Views/Shared/_OfficeCardPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c760d82600bd198577a6cb6fddbf4edf7260d8da", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__OfficeCardPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VNPT_Review.Models.UOfficeReview>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Office", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("stretched-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\gnoul\Synced Folder\Google Drive\Web\_webapp\VNPT_Review\Views\Shared\_OfficeCardPartial.cshtml"
 if(Model.offices.Count() > 0)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\gnoul\Synced Folder\Google Drive\Web\_webapp\VNPT_Review\Views\Shared\_OfficeCardPartial.cshtml"
     foreach(var item in Model.offices)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-md-4 p-4 d-flex\">\r\n            <div class=\"card flex-fill text-center border-secondary\">\r\n                <div class=\"card-header\">\r\n                    <b>Mã phòng ban: </b>");
#nullable restore
#line 10 "C:\Users\gnoul\Synced Folder\Google Drive\Web\_webapp\VNPT_Review\Views\Shared\_OfficeCardPartial.cshtml"
                                    Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"card-body\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23555e9942a19b229ce216d424139d97a06bb1e76566", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 13 "C:\Users\gnoul\Synced Folder\Google Drive\Web\_webapp\VNPT_Review\Views\Shared\_OfficeCardPartial.cshtml"
                                                                      WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <h5 class=\"card-title text-primary\">");
#nullable restore
#line 14 "C:\Users\gnoul\Synced Folder\Google Drive\Web\_webapp\VNPT_Review\Views\Shared\_OfficeCardPartial.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <p class=\"card-text h2 font-weight-300\">");
#nullable restore
#line 15 "C:\Users\gnoul\Synced Folder\Google Drive\Web\_webapp\VNPT_Review\Views\Shared\_OfficeCardPartial.cshtml"
                                                       Write(item.Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"card-text fs-3\">\r\n");
#nullable restore
#line 17 "C:\Users\gnoul\Synced Folder\Google Drive\Web\_webapp\VNPT_Review\Views\Shared\_OfficeCardPartial.cshtml"
                          
                            var max = 5;
                            if(item.Rating == 0)
                            {
                                for(int i=0; i<max; i++)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <i class=\"fas fa-star\" style=\"color:#ffffff; text-shadow: 0 0 2px #000000\"></i>\r\n");
#nullable restore
#line 24 "C:\Users\gnoul\Synced Folder\Google Drive\Web\_webapp\VNPT_Review\Views\Shared\_OfficeCardPartial.cshtml"
                                }
                            }
                            else 
                            {
                                int i;
                                for(i=0; i<item.Rating; i++)
                                {
                                    if(i >= item.Rating - 1 && item.Rating % 1 != 0)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <i class=\"fas fa-star-half\" style=\"color:#fffc3d; text-shadow: 0 0 2px #000000\"></i>\r\n");
#nullable restore
#line 34 "C:\Users\gnoul\Synced Folder\Google Drive\Web\_webapp\VNPT_Review\Views\Shared\_OfficeCardPartial.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <i class=\"fas fa-star\" style=\"color:#fffc3d; text-shadow: 0 0 2px #000000\"></i>\r\n");
#nullable restore
#line 38 "C:\Users\gnoul\Synced Folder\Google Drive\Web\_webapp\VNPT_Review\Views\Shared\_OfficeCardPartial.cshtml"
                                    }
                                }
                                while(i < max) 
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <i class=\"fas fa-star\" style=\"color:#ffffff; text-shadow: 0 0 2px #000000\"></i>\r\n");
#nullable restore
#line 43 "C:\Users\gnoul\Synced Folder\Google Drive\Web\_webapp\VNPT_Review\Views\Shared\_OfficeCardPartial.cshtml"
                                    i++;
                                }
                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </p>\r\n                    <p>Hoạt động:  \r\n");
#nullable restore
#line 49 "C:\Users\gnoul\Synced Folder\Google Drive\Web\_webapp\VNPT_Review\Views\Shared\_OfficeCardPartial.cshtml"
                          
                            if(item.Active == 1) 
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <i class=\'fas fa-circle\' style=\'color:#83eb34\'></i> \r\n");
#nullable restore
#line 53 "C:\Users\gnoul\Synced Folder\Google Drive\Web\_webapp\VNPT_Review\Views\Shared\_OfficeCardPartial.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <i class=\'fas fa-circle\' style=\'color:#f03f24\'></i>");
#nullable restore
#line 56 "C:\Users\gnoul\Synced Folder\Google Drive\Web\_webapp\VNPT_Review\Views\Shared\_OfficeCardPartial.cshtml"
                                                                                   ;  
                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </p>\r\n");
#nullable restore
#line 60 "C:\Users\gnoul\Synced Folder\Google Drive\Web\_webapp\VNPT_Review\Views\Shared\_OfficeCardPartial.cshtml"
                     if(User.IsInRole("Admin"))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div style=\"z-index:3; position:relative;\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23555e9942a19b229ce216d424139d97a06bb1e714124", async() => {
                WriteLiteral("Sửa");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 63 "C:\Users\gnoul\Synced Folder\Google Drive\Web\_webapp\VNPT_Review\Views\Shared\_OfficeCardPartial.cshtml"
                                                                           WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23555e9942a19b229ce216d424139d97a06bb1e716649", async() => {
                WriteLiteral("Xoá");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 64 "C:\Users\gnoul\Synced Folder\Google Drive\Web\_webapp\VNPT_Review\Views\Shared\_OfficeCardPartial.cshtml"
                                                                             WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n");
#nullable restore
#line 66 "C:\Users\gnoul\Synced Folder\Google Drive\Web\_webapp\VNPT_Review\Views\Shared\_OfficeCardPartial.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 70 "C:\Users\gnoul\Synced Folder\Google Drive\Web\_webapp\VNPT_Review\Views\Shared\_OfficeCardPartial.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "C:\Users\gnoul\Synced Folder\Google Drive\Web\_webapp\VNPT_Review\Views\Shared\_OfficeCardPartial.cshtml"
     
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h5 class=\"text-center text-muted\">Hiện tại chưa có phòng ban nào.</h5>\r\n");
#nullable restore
#line 75 "C:\Users\gnoul\Synced Folder\Google Drive\Web\_webapp\VNPT_Review\Views\Shared\_OfficeCardPartial.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VNPT_Review.Models.UOfficeReview> Html { get; private set; }
    }
}
#pragma warning restore 1591
