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
#nullable restore
#line 1 "x:\dir\subdir\Test\TestComponent.cshtml"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
    public partial class TestComponent : Microsoft.AspNetCore.Components.ComponentBase
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
            __o = Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 2 "x:\dir\subdir\Test\TestComponent.cshtml"
                 OnComponentHover

#line default
#line hidden
#nullable disable
            );
            __o = 
#nullable restore
#line 2 "x:\dir\subdir\Test\TestComponent.cshtml"
                                                       ParentBgColor

#line default
#line hidden
#nullable disable
            ;
        }
        #pragma warning restore 1998
#nullable restore
#line 3 "x:\dir\subdir\Test\TestComponent.cshtml"
       
    public string ParentBgColor { get; set; } = "#FFFFFF";

    public void OnComponentHover(MouseEventArgs e)
    {
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
