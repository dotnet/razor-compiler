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
            __builder.OpenComponent<global::Test.MyComponent<int>>(0);
            __builder.AddAttribute(1, "Item", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<int>(
#nullable restore
#line 1 "x:\dir\subdir\Test\TestComponent.cshtml"
                             3

#line default
#line hidden
#nullable disable
            ));
            __builder.AddComponentReferenceCapture(2, (__value) => {
#nullable restore
#line 1 "x:\dir\subdir\Test\TestComponent.cshtml"
                                      _my = (Test.MyComponent<int>)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 3 "x:\dir\subdir\Test\TestComponent.cshtml"
       
    private MyComponent<int> _my;
    public void Foo() { System.GC.KeepAlive(_my); }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
