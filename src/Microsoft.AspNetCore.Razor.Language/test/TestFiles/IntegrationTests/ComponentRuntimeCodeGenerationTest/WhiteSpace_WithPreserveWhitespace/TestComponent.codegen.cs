// <auto-generated/>
#pragma warning disable 1591
namespace Test
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
    public partial class TestComponent : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "\r\n    ");
            __builder.OpenElement(1, "elem");
            __builder.AddAttribute(2, "attr", 
#nullable restore
#line 3 "x:\dir\subdir\Test\TestComponent.cshtml"
                Foo

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(3, "\r\n        <child></child>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "x:\dir\subdir\Test\TestComponent.cshtml"
           
        int Foo = 18;
    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
