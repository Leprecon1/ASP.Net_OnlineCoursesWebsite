#pragma checksum "C:\Users\HP\source\repos\OnlineCourses\OnlineCourses\Views\Shared\Components\TopTeachers\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e59c702017fe40c2e3d2296b46d9dc51f2707d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_TopTeachers_Default), @"mvc.1.0.view", @"/Views/Shared/Components/TopTeachers/Default.cshtml")]
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
#line 1 "C:\Users\HP\source\repos\OnlineCourses\OnlineCourses\Views\_ViewImports.cshtml"
using OnlineCourses;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\source\repos\OnlineCourses\OnlineCourses\Views\_ViewImports.cshtml"
using OnlineCourses.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e59c702017fe40c2e3d2296b46d9dc51f2707d3", @"/Views/Shared/Components/TopTeachers/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad581887bf40649e097e2647f45c3f10acbcc30a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_TopTeachers_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\HP\source\repos\OnlineCourses\OnlineCourses\Views\Shared\Components\TopTeachers\Default.cshtml"
 foreach (var teacher in Model.TopTeachers)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-lg-3 col-md-6 col-sm-12 single-trainer\">\r\n        <div class=\"thumb d-flex justify-content-sm-center\">\r\n\r\n            <img class=\"img-fluid\"");
            BeginWriteAttribute("src", "  src=\"", 210, "\"", 280, 2);
            WriteAttributeValue("", 217, "data:image/jpeg;base64,", 217, 23, true);
#nullable restore
#line 7 "C:\Users\HP\source\repos\OnlineCourses\OnlineCourses\Views\Shared\Components\TopTeachers\Default.cshtml"
WriteAttributeValue("", 240, Convert.ToBase64String(teacher.Photo), 240, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 281, "\"", 287, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </div>\r\n        <div class=\"meta-text text-sm-center\">\r\n            <h4>");
#nullable restore
#line 10 "C:\Users\HP\source\repos\OnlineCourses\OnlineCourses\Views\Shared\Components\TopTeachers\Default.cshtml"
           Write(teacher.TeacherName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n            <p class=\"designation\">");
#nullable restore
#line 11 "C:\Users\HP\source\repos\OnlineCourses\OnlineCourses\Views\Shared\Components\TopTeachers\Default.cshtml"
                              Write(teacher.Specialization);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <div class=\"mb-4\">\r\n                <p>\r\n                    ");
#nullable restore
#line 14 "C:\Users\HP\source\repos\OnlineCourses\OnlineCourses\Views\Shared\Components\TopTeachers\Default.cshtml"
               Write(teacher.About);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </p>
            </div>
            <div class=""align-items-center justify-content-center d-flex"">
                <a href=""#""><i class=""ti-facebook""></i></a>
                <a href=""#""><i class=""ti-twitter""></i></a>
                <a href=""#""><i class=""ti-linkedin""></i></a>
                <a href=""#""><i class=""ti-pinterest""></i></a>
            </div>
        </div>
    </div>
");
#nullable restore
#line 25 "C:\Users\HP\source\repos\OnlineCourses\OnlineCourses\Views\Shared\Components\TopTeachers\Default.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
