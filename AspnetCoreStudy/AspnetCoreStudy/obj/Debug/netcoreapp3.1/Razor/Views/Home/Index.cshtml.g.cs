#pragma checksum "/Users/hong-eunbin/Documents/GitHub/csharp-cod/AspnetCoreStudy/AspnetCoreStudy/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85b6d4fdc8534e37e631a0a212ca42e2e5db9404"
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
#line 1 "/Users/hong-eunbin/Documents/GitHub/csharp-cod/AspnetCoreStudy/AspnetCoreStudy/Views/_ViewImports.cshtml"
using AspnetCoreStudy;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/hong-eunbin/Documents/GitHub/csharp-cod/AspnetCoreStudy/AspnetCoreStudy/Views/_ViewImports.cshtml"
using AspnetCoreStudy.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85b6d4fdc8534e37e631a0a212ca42e2e5db9404", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"247f38fdf905f4446ce33d12a44d17f12eab94b0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/hong-eunbin/Documents/GitHub/csharp-cod/AspnetCoreStudy/AspnetCoreStudy/Views/Home/Index.cshtml"
  
    var name = "홍길동";
    var age = 10;

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 5 "/Users/hong-eunbin/Documents/GitHub/csharp-cod/AspnetCoreStudy/AspnetCoreStudy/Views/Home/Index.cshtml"
Write(name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" 님 환영합니다.</h1>\n\n");
#nullable restore
#line 7 "/Users/hong-eunbin/Documents/GitHub/csharp-cod/AspnetCoreStudy/AspnetCoreStudy/Views/Home/Index.cshtml"
 if (age == 10)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2>");
#nullable restore
#line 9 "/Users/hong-eunbin/Documents/GitHub/csharp-cod/AspnetCoreStudy/AspnetCoreStudy/Views/Home/Index.cshtml"
   Write(name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" 님은 ");
#nullable restore
#line 9 "/Users/hong-eunbin/Documents/GitHub/csharp-cod/AspnetCoreStudy/AspnetCoreStudy/Views/Home/Index.cshtml"
            Write(age);

#line default
#line hidden
#nullable disable
            WriteLiteral(" 살 입니다. </h2>\n");
#nullable restore
#line 10 "/Users/hong-eunbin/Documents/GitHub/csharp-cod/AspnetCoreStudy/AspnetCoreStudy/Views/Home/Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2>");
#nullable restore
#line 13 "/Users/hong-eunbin/Documents/GitHub/csharp-cod/AspnetCoreStudy/AspnetCoreStudy/Views/Home/Index.cshtml"
   Write(name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" 님 나이를 알 수 없습니다.</h2>\n");
#nullable restore
#line 14 "/Users/hong-eunbin/Documents/GitHub/csharp-cod/AspnetCoreStudy/AspnetCoreStudy/Views/Home/Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 16 "/Users/hong-eunbin/Documents/GitHub/csharp-cod/AspnetCoreStudy/AspnetCoreStudy/Views/Home/Index.cshtml"
 for (var index = 1; index < 10; index++)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>");
#nullable restore
#line 18 "/Users/hong-eunbin/Documents/GitHub/csharp-cod/AspnetCoreStudy/AspnetCoreStudy/Views/Home/Index.cshtml"
   Write(index);

#line default
#line hidden
#nullable disable
            WriteLiteral(" 번째 입니다. </h3>\n");
#nullable restore
#line 19 "/Users/hong-eunbin/Documents/GitHub/csharp-cod/AspnetCoreStudy/AspnetCoreStudy/Views/Home/Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>사용자 번호 : ");
#nullable restore
#line 21 "/Users/hong-eunbin/Documents/GitHub/csharp-cod/AspnetCoreStudy/AspnetCoreStudy/Views/Home/Index.cshtml"
        Write(Model.UserNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n<h1>사용자 이름 : ");
#nullable restore
#line 22 "/Users/hong-eunbin/Documents/GitHub/csharp-cod/AspnetCoreStudy/AspnetCoreStudy/Views/Home/Index.cshtml"
        Write(Model.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>");
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
