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
        #pragma warning disable 219
        private void __RazorDirectiveTokenHelpers__() {
        }
        #pragma warning restore 219
        #pragma warning disable 0414
        private static System.Object __o = null;
        #pragma warning restore 0414
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __o = new global::System.Action<System.EventArgs>(
#nullable restore
#line 1 "x:\dir\subdir\Test\TestComponent.cshtml"
                        e => { Increment(); }

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(-1, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
            }
            ));
#nullable restore
#line 1 "x:\dir\subdir\Test\TestComponent.cshtml"
__o = typeof(global::Test.MyComponent);

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 3 "x:\dir\subdir\Test\TestComponent.cshtml"
       
    private int counter;
    private void Increment() {
        counter++;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
