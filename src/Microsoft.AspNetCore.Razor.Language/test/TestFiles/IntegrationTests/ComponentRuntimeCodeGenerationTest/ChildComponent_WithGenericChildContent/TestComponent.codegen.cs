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
    public partial class TestComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::Test.MyComponent>(0);
            __builder.AddAttribute(1, "MyAttr", "abc");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<System.String>)((context) => (__builder2) => {
                __builder2.AddContent(3, "Some text");
                __builder2.OpenElement(4, "some-child");
                __builder2.AddAttribute(5, "a", "1");
#nullable restore
#line (1,55)-(1,81) 25 "x:\dir\subdir\Test\TestComponent.cshtml"
__builder2.AddContent(6, context.ToLowerInvariant());

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
