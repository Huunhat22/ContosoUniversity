#pragma checksum "D:\HUUNHAT\Learning_Web\Dot_Net_Core\ContosoUniversity\ContosoUniversity\Views\Instructors\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c714be1d05bf26f62f74d96a33903491c86174ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Instructors_Index), @"mvc.1.0.view", @"/Views/Instructors/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Instructors/Index.cshtml", typeof(AspNetCore.Views_Instructors_Index))]
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
#line 1 "D:\HUUNHAT\Learning_Web\Dot_Net_Core\ContosoUniversity\ContosoUniversity\Views\_ViewImports.cshtml"
using ContosoUniversity;

#line default
#line hidden
#line 2 "D:\HUUNHAT\Learning_Web\Dot_Net_Core\ContosoUniversity\ContosoUniversity\Views\_ViewImports.cshtml"
using ContosoUniversity.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c714be1d05bf26f62f74d96a33903491c86174ee", @"/Views/Instructors/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c8c63dad9db0b17e31c66667dec1a52add46bdf", @"/Views/_ViewImports.cshtml")]
    public class Views_Instructors_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ContosoUniversity.Models.SchoolViewModels.InstructorIndexData>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(18, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(81, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(189, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "D:\HUUNHAT\Learning_Web\Dot_Net_Core\ContosoUniversity\ContosoUniversity\Views\Instructors\Index.cshtml"
  
    ViewData["Title"] = "Instructor";

#line default
#line hidden
            BeginContext(237, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(266, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f11a7d381ac947b6a42def899903f2f3", async() => {
                BeginContext(289, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(303, 257, true);
            WriteLiteral(@"
</p>
<table class=""table"">
    <thead>
        <tr>
            <th>Last Name</th>
            <th>First MidName</th>
            <th>HireDate</th>
            <th>Offic</th>
            <th>Courses</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 27 "D:\HUUNHAT\Learning_Web\Dot_Net_Core\ContosoUniversity\ContosoUniversity\Views\Instructors\Index.cshtml"
         foreach (var item in Model.Instructors)
        {

            string selectedRow = "";
            if (item.ID == (int?)ViewData["InstructorID"])
            {
                selectedRow = "success";
            }

#line default
#line hidden
            BeginContext(793, 15, true);
            WriteLiteral("            <tr");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 808, "\"", 828, 1);
#line 35 "D:\HUUNHAT\Learning_Web\Dot_Net_Core\ContosoUniversity\ContosoUniversity\Views\Instructors\Index.cshtml"
WriteAttributeValue("", 816, selectedRow, 816, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(829, 45, true);
            WriteLiteral(">\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(875, 43, false);
#line 37 "D:\HUUNHAT\Learning_Web\Dot_Net_Core\ContosoUniversity\ContosoUniversity\Views\Instructors\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(918, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(986, 47, false);
#line 40 "D:\HUUNHAT\Learning_Web\Dot_Net_Core\ContosoUniversity\ContosoUniversity\Views\Instructors\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.FirstMidName));

#line default
#line hidden
            EndContext();
            BeginContext(1033, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1101, 43, false);
#line 43 "D:\HUUNHAT\Learning_Web\Dot_Net_Core\ContosoUniversity\ContosoUniversity\Views\Instructors\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.HireDate));

#line default
#line hidden
            EndContext();
            BeginContext(1144, 47, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
            EndContext();
#line 46 "D:\HUUNHAT\Learning_Web\Dot_Net_Core\ContosoUniversity\ContosoUniversity\Views\Instructors\Index.cshtml"
                     if (item.OfficeAssigment != null)
                    {
                        

#line default
#line hidden
            BeginContext(1295, 29, false);
#line 48 "D:\HUUNHAT\Learning_Web\Dot_Net_Core\ContosoUniversity\ContosoUniversity\Views\Instructors\Index.cshtml"
                   Write(item.OfficeAssigment.Location);

#line default
#line hidden
            EndContext();
#line 48 "D:\HUUNHAT\Learning_Web\Dot_Net_Core\ContosoUniversity\ContosoUniversity\Views\Instructors\Index.cshtml"
                                                      
                    }

#line default
#line hidden
            BeginContext(1349, 45, true);
            WriteLiteral("                </td>\r\n                <td>\r\n");
            EndContext();
#line 52 "D:\HUUNHAT\Learning_Web\Dot_Net_Core\ContosoUniversity\ContosoUniversity\Views\Instructors\Index.cshtml"
                      
                        foreach (var course in item.CourseAssignments)
                        {
                            

#line default
#line hidden
            BeginContext(1546, 22, false);
#line 55 "D:\HUUNHAT\Learning_Web\Dot_Net_Core\ContosoUniversity\ContosoUniversity\Views\Instructors\Index.cshtml"
                       Write(course.Course.CourseID);

#line default
#line hidden
            EndContext();
            BeginContext(1568, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1571, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1573, 19, false);
#line 55 "D:\HUUNHAT\Learning_Web\Dot_Net_Core\ContosoUniversity\ContosoUniversity\Views\Instructors\Index.cshtml"
                                                  Write(course.Course.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1592, 9, true);
            WriteLiteral(" <br />\r\n");
            EndContext();
#line 56 "D:\HUUNHAT\Learning_Web\Dot_Net_Core\ContosoUniversity\ContosoUniversity\Views\Instructors\Index.cshtml"
                        }
                    

#line default
#line hidden
            BeginContext(1651, 65, true);
            WriteLiteral("                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1716, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1acee6fd859a4107a956c0cf06f50fb8", async() => {
                BeginContext(1762, 6, true);
                WriteLiteral("Select");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 60 "D:\HUUNHAT\Learning_Web\Dot_Net_Core\ContosoUniversity\ContosoUniversity\Views\Instructors\Index.cshtml"
                                            WriteLiteral(item.ID);

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
            BeginContext(1772, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(1794, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03aa12e1646046899f0f52b48297e179", async() => {
                BeginContext(1839, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 61 "D:\HUUNHAT\Learning_Web\Dot_Net_Core\ContosoUniversity\ContosoUniversity\Views\Instructors\Index.cshtml"
                                           WriteLiteral(item.ID);

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
            BeginContext(1847, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(1871, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6917dd00188e483bb086f71121dd5774", async() => {
                BeginContext(1919, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 62 "D:\HUUNHAT\Learning_Web\Dot_Net_Core\ContosoUniversity\ContosoUniversity\Views\Instructors\Index.cshtml"
                                              WriteLiteral(item.ID);

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
            BeginContext(1930, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(1954, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "272f2a1c239546c7b0f06b2acdf08b94", async() => {
                BeginContext(2001, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 63 "D:\HUUNHAT\Learning_Web\Dot_Net_Core\ContosoUniversity\ContosoUniversity\Views\Instructors\Index.cshtml"
                                             WriteLiteral(item.ID);

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
            BeginContext(2011, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 66 "D:\HUUNHAT\Learning_Web\Dot_Net_Core\ContosoUniversity\ContosoUniversity\Views\Instructors\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2066, 28, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n");
            EndContext();
#line 72 "D:\HUUNHAT\Learning_Web\Dot_Net_Core\ContosoUniversity\ContosoUniversity\Views\Instructors\Index.cshtml"
 if (Model.Courses != null)
{

#line default
#line hidden
            BeginContext(2225, 195, true);
            WriteLiteral("    <h3>Courses Taught by Selected Instructor</h3>\r\n    <table class=\"table\">\r\n        <tr>\r\n            <th></th>\r\n            <th>Number</th>\r\n            <th>Department</th>\r\n        </tr>\r\n\r\n");
            EndContext();
#line 82 "D:\HUUNHAT\Learning_Web\Dot_Net_Core\ContosoUniversity\ContosoUniversity\Views\Instructors\Index.cshtml"
         foreach (var item in Model.Courses)
        {
            string selectedRow = "";
            if (item.CourseID == (int?)ViewData["CourseID"])
            {
                selectedRow = "success";
            }

#line default
#line hidden
            BeginContext(2649, 15, true);
            WriteLiteral("            <tr");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2664, "\"", 2684, 1);
#line 89 "D:\HUUNHAT\Learning_Web\Dot_Net_Core\ContosoUniversity\ContosoUniversity\Views\Instructors\Index.cshtml"
WriteAttributeValue("", 2672, selectedRow, 2672, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2685, 45, true);
            WriteLiteral(">\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2731, 68, false);
#line 91 "D:\HUUNHAT\Learning_Web\Dot_Net_Core\ContosoUniversity\ContosoUniversity\Views\Instructors\Index.cshtml"
               Write(Html.ActionLink("Select", "Index", new { courseID = item.CourseID }));

#line default
#line hidden
            EndContext();
            BeginContext(2799, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2867, 13, false);
#line 94 "D:\HUUNHAT\Learning_Web\Dot_Net_Core\ContosoUniversity\ContosoUniversity\Views\Instructors\Index.cshtml"
               Write(item.CourseID);

#line default
#line hidden
            EndContext();
            BeginContext(2880, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2948, 10, false);
#line 97 "D:\HUUNHAT\Learning_Web\Dot_Net_Core\ContosoUniversity\ContosoUniversity\Views\Instructors\Index.cshtml"
               Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(2958, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3026, 20, false);
#line 100 "D:\HUUNHAT\Learning_Web\Dot_Net_Core\ContosoUniversity\ContosoUniversity\Views\Instructors\Index.cshtml"
               Write(item.Department.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3046, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 103 "D:\HUUNHAT\Learning_Web\Dot_Net_Core\ContosoUniversity\ContosoUniversity\Views\Instructors\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(3101, 16, true);
            WriteLiteral("\r\n    </table>\r\n");
            EndContext();
#line 106 "D:\HUUNHAT\Learning_Web\Dot_Net_Core\ContosoUniversity\ContosoUniversity\Views\Instructors\Index.cshtml"
}


#line default
#line hidden
#line 109 "D:\HUUNHAT\Learning_Web\Dot_Net_Core\ContosoUniversity\ContosoUniversity\Views\Instructors\Index.cshtml"
 if(Model.Enrollments != null)
{

#line default
#line hidden
            BeginContext(3259, 163, true);
            WriteLiteral("    <h3>Student Enrolled in Selected Course</h3>\r\n    <table class=\"table\">\r\n        <tr>\r\n            <th>Name</th>\r\n            <th>Grade</th>\r\n        </tr>\r\n\r\n");
            EndContext();
#line 118 "D:\HUUNHAT\Learning_Web\Dot_Net_Core\ContosoUniversity\ContosoUniversity\Views\Instructors\Index.cshtml"
         foreach (var item in Model.Enrollments)
        {

#line default
#line hidden
            BeginContext(3483, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3544, 21, false);
#line 122 "D:\HUUNHAT\Learning_Web\Dot_Net_Core\ContosoUniversity\ContosoUniversity\Views\Instructors\Index.cshtml"
               Write(item.Student.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(3565, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3633, 40, false);
#line 125 "D:\HUUNHAT\Learning_Web\Dot_Net_Core\ContosoUniversity\ContosoUniversity\Views\Instructors\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Grade));

#line default
#line hidden
            EndContext();
            BeginContext(3673, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 128 "D:\HUUNHAT\Learning_Web\Dot_Net_Core\ContosoUniversity\ContosoUniversity\Views\Instructors\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(3728, 14, true);
            WriteLiteral("    </table>\r\n");
            EndContext();
#line 130 "D:\HUUNHAT\Learning_Web\Dot_Net_Core\ContosoUniversity\ContosoUniversity\Views\Instructors\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContosoUniversity.Models.SchoolViewModels.InstructorIndexData> Html { get; private set; }
    }
}
#pragma warning restore 1591
