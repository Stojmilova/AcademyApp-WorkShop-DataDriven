#pragma checksum "C:\Users\Stojmilova\Desktop\ASP.NET Data-Driven\Workshop-Vezba od Cas-Class04\SEDC.AcademyApp\AcademyApp.WebApp\Views\Student\Students.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f78878c8e967fe71f60d417d3d715e1030e6e91c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Students), @"mvc.1.0.view", @"/Views/Student/Students.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Student/Students.cshtml", typeof(AspNetCore.Views_Student_Students))]
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
#line 1 "C:\Users\Stojmilova\Desktop\ASP.NET Data-Driven\Workshop-Vezba od Cas-Class04\SEDC.AcademyApp\AcademyApp.WebApp\Views\_ViewImports.cshtml"
using AcademyApp.WebApp;

#line default
#line hidden
#line 2 "C:\Users\Stojmilova\Desktop\ASP.NET Data-Driven\Workshop-Vezba od Cas-Class04\SEDC.AcademyApp\AcademyApp.WebApp\Views\_ViewImports.cshtml"
using AcademyApp.WebApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f78878c8e967fe71f60d417d3d715e1030e6e91c", @"/Views/Student/Students.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61aa9a3b9ed66c754ba1ab2de98644157c72f3d4", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Students : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<StudentsViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Stojmilova\Desktop\ASP.NET Data-Driven\Workshop-Vezba od Cas-Class04\SEDC.AcademyApp\AcademyApp.WebApp\Views\Student\Students.cshtml"
  
    ViewBag.Title = "List of Students";

#line default
#line hidden
            BeginContext(82, 27, true);
            WriteLiteral("\r\n<div class=\"jumbotron\">\r\n");
            EndContext();
#line 8 "C:\Users\Stojmilova\Desktop\ASP.NET Data-Driven\Workshop-Vezba od Cas-Class04\SEDC.AcademyApp\AcademyApp.WebApp\Views\Student\Students.cshtml"
     foreach (var student in Model)
    {

#line default
#line hidden
            BeginContext(153, 41, true);
            WriteLiteral("        <ul>\r\n            <li>StudentID: ");
            EndContext();
            BeginContext(195, 10, false);
#line 11 "C:\Users\Stojmilova\Desktop\ASP.NET Data-Driven\Workshop-Vezba od Cas-Class04\SEDC.AcademyApp\AcademyApp.WebApp\Views\Student\Students.cshtml"
                      Write(student.Id);

#line default
#line hidden
            EndContext();
            BeginContext(205, 34, true);
            WriteLiteral("</li>\r\n            <li>FirstName: ");
            EndContext();
            BeginContext(240, 17, false);
#line 12 "C:\Users\Stojmilova\Desktop\ASP.NET Data-Driven\Workshop-Vezba od Cas-Class04\SEDC.AcademyApp\AcademyApp.WebApp\Views\Student\Students.cshtml"
                      Write(student.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(257, 33, true);
            WriteLiteral("</li>\r\n            <li>LastName: ");
            EndContext();
            BeginContext(291, 16, false);
#line 13 "C:\Users\Stojmilova\Desktop\ASP.NET Data-Driven\Workshop-Vezba od Cas-Class04\SEDC.AcademyApp\AcademyApp.WebApp\Views\Student\Students.cshtml"
                     Write(student.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(307, 28, true);
            WriteLiteral("</li>\r\n            <li>Age: ");
            EndContext();
            BeginContext(336, 11, false);
#line 14 "C:\Users\Stojmilova\Desktop\ASP.NET Data-Driven\Workshop-Vezba od Cas-Class04\SEDC.AcademyApp\AcademyApp.WebApp\Views\Student\Students.cshtml"
                Write(student.Age);

#line default
#line hidden
            EndContext();
            BeginContext(347, 38, true);
            WriteLiteral("</li>\r\n            <li>TypeOfAcademy: ");
            EndContext();
            BeginContext(386, 21, false);
#line 15 "C:\Users\Stojmilova\Desktop\ASP.NET Data-Driven\Workshop-Vezba od Cas-Class04\SEDC.AcademyApp\AcademyApp.WebApp\Views\Student\Students.cshtml"
                          Write(student.TypeOfAcademy);

#line default
#line hidden
            EndContext();
            BeginContext(407, 42, true);
            WriteLiteral("</li>\r\n            <li>List of Projects:\r\n");
            EndContext();
#line 17 "C:\Users\Stojmilova\Desktop\ASP.NET Data-Driven\Workshop-Vezba od Cas-Class04\SEDC.AcademyApp\AcademyApp.WebApp\Views\Student\Students.cshtml"
                 foreach (var project in student.Projects)
                {

#line default
#line hidden
            BeginContext(528, 74, true);
            WriteLiteral("                    <ul style=\"text-decoration: underline; \">Project num: ");
            EndContext();
            BeginContext(603, 10, false);
#line 19 "C:\Users\Stojmilova\Desktop\ASP.NET Data-Driven\Workshop-Vezba od Cas-Class04\SEDC.AcademyApp\AcademyApp.WebApp\Views\Student\Students.cshtml"
                                                                     Write(project.Id);

#line default
#line hidden
            EndContext();
            BeginContext(613, 37, true);
            WriteLiteral("\r\n                        <li>Title: ");
            EndContext();
            BeginContext(651, 13, false);
#line 20 "C:\Users\Stojmilova\Desktop\ASP.NET Data-Driven\Workshop-Vezba od Cas-Class04\SEDC.AcademyApp\AcademyApp.WebApp\Views\Student\Students.cshtml"
                              Write(project.Title);

#line default
#line hidden
            EndContext();
            BeginContext(664, 51, true);
            WriteLiteral("</li>\r\n                        <li>Estimated Time: ");
            EndContext();
            BeginContext(716, 21, false);
#line 21 "C:\Users\Stojmilova\Desktop\ASP.NET Data-Driven\Workshop-Vezba od Cas-Class04\SEDC.AcademyApp\AcademyApp.WebApp\Views\Student\Students.cshtml"
                                       Write(project.EstimatedTime);

#line default
#line hidden
            EndContext();
            BeginContext(737, 47, true);
            WriteLiteral("</li>\r\n                        <li>Time Spend: ");
            EndContext();
            BeginContext(785, 17, false);
#line 22 "C:\Users\Stojmilova\Desktop\ASP.NET Data-Driven\Workshop-Vezba od Cas-Class04\SEDC.AcademyApp\AcademyApp.WebApp\Views\Student\Students.cshtml"
                                   Write(project.TimeSpend);

#line default
#line hidden
            EndContext();
            BeginContext(802, 62, true);
            WriteLiteral("</li>\r\n                    </ul>\r\n                    <br />\r\n");
            EndContext();
#line 25 "C:\Users\Stojmilova\Desktop\ASP.NET Data-Driven\Workshop-Vezba od Cas-Class04\SEDC.AcademyApp\AcademyApp.WebApp\Views\Student\Students.cshtml"
                }

#line default
#line hidden
            BeginContext(883, 34, true);
            WriteLiteral("            </li>\r\n        </ul>\r\n");
            EndContext();
#line 28 "C:\Users\Stojmilova\Desktop\ASP.NET Data-Driven\Workshop-Vezba od Cas-Class04\SEDC.AcademyApp\AcademyApp.WebApp\Views\Student\Students.cshtml"
    }

#line default
#line hidden
            BeginContext(924, 8, true);
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<StudentsViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591