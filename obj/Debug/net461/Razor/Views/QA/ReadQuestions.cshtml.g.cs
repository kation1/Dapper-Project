#pragma checksum "C:\devbuild4\Labs\QL StackOverflow\Dapper Project\Views\QA\ReadQuestions.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a32bd2d58c6e46cfe4e226b6f642933ef65a435"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_QA_ReadQuestions), @"mvc.1.0.view", @"/Views/QA/ReadQuestions.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/QA/ReadQuestions.cshtml", typeof(AspNetCore.Views_QA_ReadQuestions))]
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
#line 1 "C:\devbuild4\Labs\QL StackOverflow\Dapper Project\Views\_ViewImports.cshtml"
using Dapper_Project;

#line default
#line hidden
#line 2 "C:\devbuild4\Labs\QL StackOverflow\Dapper Project\Views\_ViewImports.cshtml"
using Dapper_Project.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a32bd2d58c6e46cfe4e226b6f642933ef65a435", @"/Views/QA/ReadQuestions.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5e5a985084eba6a87f5f5a7756ec7c1601d37e2", @"/Views/_ViewImports.cshtml")]
    public class Views_QA_ReadQuestions : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Questions>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Category", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Title", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/QA/SearchQuestions"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\devbuild4\Labs\QL StackOverflow\Dapper Project\Views\QA\ReadQuestions.cshtml"
  
    ViewData["Title"] = "ReadQuestions";

#line default
#line hidden
            BeginContext(73, 38, true);
            WriteLiteral("\r\n<h2>Read Questions</h2>\r\n\r\n<table>\r\n");
            EndContext();
#line 9 "C:\devbuild4\Labs\QL StackOverflow\Dapper Project\Views\QA\ReadQuestions.cshtml"
     foreach (Questions questions in Model)
    {


#line default
#line hidden
            BeginContext(165, 50, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 215, "\"", 254, 2);
            WriteAttributeValue("", 222, "/QA/ReadAnswers?id=", 222, 19, true);
#line 14 "C:\devbuild4\Labs\QL StackOverflow\Dapper Project\Views\QA\ReadQuestions.cshtml"
WriteAttributeValue("", 241, questions.ID, 241, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(255, 2, true);
            WriteLiteral("> ");
            EndContext();
            BeginContext(258, 15, false);
#line 14 "C:\devbuild4\Labs\QL StackOverflow\Dapper Project\Views\QA\ReadQuestions.cshtml"
                                                       Write(questions.Title);

#line default
#line hidden
            EndContext();
            BeginContext(273, 67, true);
            WriteLiteral("</a>  <br />\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(341, 16, false);
#line 17 "C:\devbuild4\Labs\QL StackOverflow\Dapper Project\Views\QA\ReadQuestions.cshtml"
           Write(questions.Detail);

#line default
#line hidden
            EndContext();
            BeginContext(357, 62, true);
            WriteLiteral(" <br />\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(420, 18, false);
#line 20 "C:\devbuild4\Labs\QL StackOverflow\Dapper Project\Views\QA\ReadQuestions.cshtml"
           Write(questions.Category);

#line default
#line hidden
            EndContext();
            BeginContext(438, 62, true);
            WriteLiteral(" <br />\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(501, 14, false);
#line 23 "C:\devbuild4\Labs\QL StackOverflow\Dapper Project\Views\QA\ReadQuestions.cshtml"
           Write(questions.Tags);

#line default
#line hidden
            EndContext();
            BeginContext(515, 28, true);
            WriteLiteral(" <br />\r\n            </td>\r\n");
            EndContext();
#line 25 "C:\devbuild4\Labs\QL StackOverflow\Dapper Project\Views\QA\ReadQuestions.cshtml"
             if (ViewBag.username == questions.Username)
            {

#line default
#line hidden
            BeginContext(616, 44, true);
            WriteLiteral("                <td>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 660, "\"", 698, 2);
            WriteAttributeValue("", 667, "/QA/EditQuestion?=", 667, 18, true);
#line 28 "C:\devbuild4\Labs\QL StackOverflow\Dapper Project\Views\QA\ReadQuestions.cshtml"
WriteAttributeValue("", 685, questions.ID, 685, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(699, 97, true);
            WriteLiteral("><button1>Edit</button1></a>\r\n                </td>\r\n                <td>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 796, "\"", 836, 2);
            WriteAttributeValue("", 803, "/QA/RemoveQuestion?=", 803, 20, true);
#line 31 "C:\devbuild4\Labs\QL StackOverflow\Dapper Project\Views\QA\ReadQuestions.cshtml"
WriteAttributeValue("", 823, questions.ID, 823, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(837, 77, true);
            WriteLiteral("><button2>Delete</button2></a>\r\n                </td>\r\n                <td>\r\n");
            EndContext();
#line 34 "C:\devbuild4\Labs\QL StackOverflow\Dapper Project\Views\QA\ReadQuestions.cshtml"
                     if (questions.Status == 1)
                    {

#line default
#line hidden
            BeginContext(986, 26, true);
            WriteLiteral("                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1012, "\"", 1063, 3);
            WriteAttributeValue("", 1019, "/QA/CompletionStatus?=", 1019, 22, true);
#line 36 "C:\devbuild4\Labs\QL StackOverflow\Dapper Project\Views\QA\ReadQuestions.cshtml"
WriteAttributeValue("", 1041, questions.ID, 1041, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 1054, "&status=0", 1054, 9, true);
            EndWriteAttribute();
            BeginContext(1064, 35, true);
            WriteLiteral("><button3>Mark Closed</button3></a>");
            EndContext();
#line 36 "C:\devbuild4\Labs\QL StackOverflow\Dapper Project\Views\QA\ReadQuestions.cshtml"
                                                                                                                 }

#line default
#line hidden
            BeginContext(1102, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 37 "C:\devbuild4\Labs\QL StackOverflow\Dapper Project\Views\QA\ReadQuestions.cshtml"
                     if (questions.Status == 0)
                    {

#line default
#line hidden
            BeginContext(1174, 26, true);
            WriteLiteral("                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1200, "\"", 1251, 3);
            WriteAttributeValue("", 1207, "/QA/CompletionStatus?=", 1207, 22, true);
#line 39 "C:\devbuild4\Labs\QL StackOverflow\Dapper Project\Views\QA\ReadQuestions.cshtml"
WriteAttributeValue("", 1229, questions.ID, 1229, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 1242, "&status=1", 1242, 9, true);
            EndWriteAttribute();
            BeginContext(1252, 33, true);
            WriteLiteral("><button3>Mark Open</button3></a>");
            EndContext();
#line 39 "C:\devbuild4\Labs\QL StackOverflow\Dapper Project\Views\QA\ReadQuestions.cshtml"
                                                                                                               }

#line default
#line hidden
            BeginContext(1288, 23, true);
            WriteLiteral("                </td>\r\n");
            EndContext();
#line 41 "C:\devbuild4\Labs\QL StackOverflow\Dapper Project\Views\QA\ReadQuestions.cshtml"
            }

#line default
#line hidden
            BeginContext(1326, 15, true);
            WriteLiteral("        </tr>\r\n");
            EndContext();
#line 43 "C:\devbuild4\Labs\QL StackOverflow\Dapper Project\Views\QA\ReadQuestions.cshtml"
    }

#line default
#line hidden
            BeginContext(1348, 20, true);
            WriteLiteral("</table>\r\n\r\n<br />\r\n");
            EndContext();
            BeginContext(1368, 359, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a32bd2d58c6e46cfe4e226b6f642933ef65a43512185", async() => {
                BeginContext(1416, 107, true);
                WriteLiteral("\r\n    <input type=\"text\" name=\"Search\" id=\"Search\" />\r\n    <select name=\"Category\" id=\"Category\">\r\n        ");
                EndContext();
                BeginContext(1523, 42, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a32bd2d58c6e46cfe4e226b6f642933ef65a43512690", async() => {
                    BeginContext(1548, 8, true);
                    WriteLiteral("Category");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1565, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1575, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a32bd2d58c6e46cfe4e226b6f642933ef65a43514166", async() => {
                    BeginContext(1598, 6, true);
                    WriteLiteral("Detail");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1613, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1623, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a32bd2d58c6e46cfe4e226b6f642933ef65a43515640", async() => {
                    BeginContext(1645, 5, true);
                    WriteLiteral("Title");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1659, 61, true);
                WriteLiteral("\r\n    </select>\r\n    <input type=\"submit\" value=\"Submit\" />\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1727, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Questions>> Html { get; private set; }
    }
}
#pragma warning restore 1591
