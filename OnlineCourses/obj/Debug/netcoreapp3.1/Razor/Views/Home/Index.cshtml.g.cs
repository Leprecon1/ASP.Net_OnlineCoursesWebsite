#pragma checksum "C:\Users\HP\source\repos\OnlineCourses\OnlineCourses\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77a3c442a443e80310b351322973e2d60613eff3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77a3c442a443e80310b351322973e2d60613eff3", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad581887bf40649e097e2647f45c3f10acbcc30a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "about", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("primary-btn2 mb-3 mb-sm-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Events", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("primary-btn ml-sm-3 ml-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form_area"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("myForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("mail.html"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("event-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\HP\source\repos\OnlineCourses\OnlineCourses\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!--================ Start Home Banner Area =================-->
<section class=""home_banner_area"">
    <div class=""banner_inner"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-12"">
                    <div class=""banner_content text-center"">
                        <p class=""text-uppercase"">
                            Best online education service In the world
                        </p>
                        <h2 class=""text-uppercase mt-4 mb-5"">
                            One Step Ahead This Season
                        </h2>
                        <div>
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "77a3c442a443e80310b351322973e2d60613eff37849", async() => {
                WriteLiteral("learn more");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "77a3c442a443e80310b351322973e2d60613eff39325", async() => {
                WriteLiteral("See events");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!--================ End Home Banner Area =================-->


<!--================ Start Feature Area =================-->
<section class=""feature_area section_gap_top"">
    <div class=""container"">
        <div class=""row justify-content-center"">
            <div class=""col-lg-5"">
                <div class=""main_title"">
                    <h2 class=""mb-3"">Awesome Feature</h2>
                    <p>
                        Replenish man have thing gathering lights yielding shall you
                    </p>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-4 col-md-6"">
                <div class=""single_feature"">
                    <div class=""icon""><span class=""flaticon-student""></span></div>
                    <div class=""desc"">
                        <h4 class=""mt-3 mb-2""");
            WriteLiteral(@">Scholarship Facility</h4>
                        <p>
                            One make creepeth, man bearing theira firmament won't great
                            heaven
                        </p>
                    </div>
                </div>
            </div>

            <div class=""col-lg-4 col-md-6"">
                <div class=""single_feature"">
                    <div class=""icon""><span class=""flaticon-book""></span></div>
                    <div class=""desc"">
                        <h4 class=""mt-3 mb-2"">Sell Online Course</h4>
                        <p>
                            One make creepeth, man bearing theira firmament won't great
                            heaven
                        </p>
                    </div>
                </div>
            </div>

            <div class=""col-lg-4 col-md-6"">
                <div class=""single_feature"">
                    <div class=""icon""><span class=""flaticon-earth""></span></div>
                    <div");
            WriteLiteral(@" class=""desc"">
                        <h4 class=""mt-3 mb-2"">Global Certification</h4>
                        <p>
                            One make creepeth, man bearing theira firmament won't great
                            heaven
                        </p>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!--================ End Feature Area =================-->

<!--================ Start Popular Courses Area =================-->
<div class=""popular_courses"">
    <div class=""container"">
        <div class=""row justify-content-center"">
            <div class=""col-lg-5"">
                <div class=""main_title"">
                    <h2 class=""mb-3"">Our Popular Courses</h2>
                    <p>
                        Replenish man have thing gathering lights yielding shall you
                    </p>
                </div>
            </div>
        </div>
        <div class=""row"">
            <!-- single course -");
            WriteLiteral("->\r\n            <div class=\"col-lg-12\">\r\n                <div class=\"owl-carousel active_course\">\r\n\r\n                    ");
#nullable restore
#line 106 "C:\Users\HP\source\repos\OnlineCourses\OnlineCourses\Views\Home\Index.cshtml"
               Write(await Component.InvokeAsync("PopularCourses"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";

                </div>
            </div>
        </div>
    </div>
</div>
<!--================ End Popular Courses Area =================-->
<!--================ Start Registration Area =================-->
<div class=""section_gap registration_area"">
    <div class=""container"">
        <div class=""row align-items-center"">
            <div class=""col-lg-7"">
                <div class=""row clock_sec clockdiv"" id=""clockdiv"">
                    <div class=""col-lg-12"">
                        <h1 class=""mb-3"">Register Now</h1>
                        <p>
                            There is a moment in the life of any aspiring astronomer that
                            it is time to buy that first telescope. It’s exciting to think
                            about setting up your own viewing station.
                        </p>
                    </div>
                    <div class=""col clockinner1 clockinner"">
                        <h1 class=""days"">150</h1>
                    ");
            WriteLiteral(@"    <span class=""smalltext"">Days</span>
                    </div>
                    <div class=""col clockinner clockinner1"">
                        <h1 class=""hours"">23</h1>
                        <span class=""smalltext"">Hours</span>
                    </div>
                    <div class=""col clockinner clockinner1"">
                        <h1 class=""minutes"">47</h1>
                        <span class=""smalltext"">Mins</span>
                    </div>
                    <div class=""col clockinner clockinner1"">
                        <h1 class=""seconds"">59</h1>
                        <span class=""smalltext"">Secs</span>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4 offset-lg-1"">
                <div class=""register_form"">
                    <h3>Courses for Free</h3>
                    <p>It is high time for learning</p>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "77a3c442a443e80310b351322973e2d60613eff316436", async() => {
                WriteLiteral("\r\n                        <div class=\"row\">\r\n              \r\n                            <div class=\"col-lg-12 text-center\">\r\n                                <button class=\"primary-btn\"");
                BeginWriteAttribute("onclick", " onclick=\"", 6465, "\"", 6525, 3);
                WriteAttributeValue("", 6475, "location.href=\'", 6475, 15, true);
#nullable restore
#line 157 "C:\Users\HP\source\repos\OnlineCourses\OnlineCourses\Views\Home\Index.cshtml"
WriteAttributeValue("", 6490, Url.Action("Register", "Account"), 6490, 34, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 6524, "\'", 6524, 1, true);
                EndWriteAttribute();
                WriteLiteral("\r\n                                        >Registration now</button>\r\n                            </div>\r\n                        </div>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
            </div>
        </div>
    </div>
</div>
<!--================ End Registration Area =================-->
<!--================ Start Trainers Area =================-->
<section class=""trainer_area section_gap_top"">
    <div class=""container"">
        <div class=""row justify-content-center"">
            <div class=""col-lg-5"">
                <div class=""main_title"">
                    <h2 class=""mb-3"">Our Expert Trainers</h2>
                    <p>
                        Replenish man have thing gathering lights yielding shall you
                    </p>
                </div>
            </div>
        </div>
        <div class=""row justify-content-center d-flex align-items-center"">

          ");
#nullable restore
#line 183 "C:\Users\HP\source\repos\OnlineCourses\OnlineCourses\Views\Home\Index.cshtml"
     Write(await Component.InvokeAsync("TopTeachers"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
    </div>
</section>
<!--================ End Trainers Area =================-->
<!--================ Start Events Area =================-->
<div class=""events_area"">
    <div class=""container"">
        <div class=""row justify-content-center"">
            <div class=""col-lg-5"">
                <div class=""main_title"">
                    <h2 class=""mb-3 text-white"">Upcoming Events</h2>
                    <p>
                        Replenish man have thing gathering lights yielding shall you
                    </p>
                </div>
            </div>
        </div>
        <div class=""row"">
         ");
#nullable restore
#line 202 "C:\Users\HP\source\repos\OnlineCourses\OnlineCourses\Views\Home\Index.cshtml"
    Write(await Component.InvokeAsync("LastUpcomingEvents"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            <div class=\"col-lg-12\">\r\n                <div class=\"text-center pt-lg-5 pt-3\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "77a3c442a443e80310b351322973e2d60613eff321101", async() => {
                WriteLiteral("\r\n                        View All Event <img src=\"img/next.png\"");
                BeginWriteAttribute("alt", " alt=\"", 8444, "\"", 8450, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
            </div>
        </div>
    </div>
</div>
<!--================ End Events Area =================-->
<!--================ Start Testimonial Area =================-->
<div class=""testimonial_area section_gap"">
    <div class=""container"">
        <div class=""row justify-content-center"">
            <div class=""col-lg-5"">
                <div class=""main_title"">
                    <h2 class=""mb-3"">Client say about me</h2>
                    <p>
                        Replenish man have thing gathering lights yielding shall you
                    </p>
                </div>
            </div>
        </div>

        <div class=""row"">
            <div class=""testi_slider owl-carousel"">
                <div class=""testi_item"">
                    <div class=""row"">
                        <div class=""col-lg-4 col-md-6"">
                            <img src=""img/testimonials/t1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 9430, "\"", 9436, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                        </div>
                        <div class=""col-lg-8"">
                            <div class=""testi_text"">
                                <h4>Elite Martin</h4>
                                <p>
                                    Him, made can't called over won't there on divide there
                                    male fish beast own his day third seed sixth seas unto.
                                    Saw from
                                </p>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""testi_item"">
                    <div class=""row"">
                        <div class=""col-lg-4 col-md-6"">
                            <img src=""img/testimonials/t2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 10258, "\"", 10264, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                        </div>
                        <div class=""col-lg-8"">
                            <div class=""testi_text"">
                                <h4>Davil Saden</h4>
                                <p>
                                    Him, made can't called over won't there on divide there
                                    male fish beast own his day third seed sixth seas unto.
                                    Saw from
                                </p>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""testi_item"">
                    <div class=""row"">
                        <div class=""col-lg-4 col-md-6"">
                            <img src=""img/testimonials/t1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 11085, "\"", 11091, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                        </div>
                        <div class=""col-lg-8"">
                            <div class=""testi_text"">
                                <h4>Elite Martin</h4>
                                <p>
                                    Him, made can't called over won't there on divide there
                                    male fish beast own his day third seed sixth seas unto.
                                    Saw from
                                </p>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""testi_item"">
                    <div class=""row"">
                        <div class=""col-lg-4 col-md-6"">
                            <img src=""img/testimonials/t2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 11913, "\"", 11919, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                        </div>
                        <div class=""col-lg-8"">
                            <div class=""testi_text"">
                                <h4>Davil Saden</h4>
                                <p>
                                    Him, made can't called over won't there on divide there
                                    male fish beast own his day third seed sixth seas unto.
                                    Saw from
                                </p>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""testi_item"">
                    <div class=""row"">
                        <div class=""col-lg-4 col-md-6"">
                            <img src=""img/testimonials/t1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 12740, "\"", 12746, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                        </div>
                        <div class=""col-lg-8"">
                            <div class=""testi_text"">
                                <h4>Elite Martin</h4>
                                <p>
                                    Him, made can't called over won't there on divide there
                                    male fish beast own his day third seed sixth seas unto.
                                    Saw from
                                </p>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""testi_item"">
                    <div class=""row"">
                        <div class=""col-lg-4 col-md-6"">
                            <img src=""img/testimonials/t2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 13568, "\"", 13574, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                        </div>
                        <div class=""col-lg-8"">
                            <div class=""testi_text"">
                                <h4>Davil Saden</h4>
                                <p>
                                    Him, made can't called over won't there on divide there
                                    male fish beast own his day third seed sixth seas unto.
                                    Saw from
                                </p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!--================ End Testimonial Area =================-->
");
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
