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
#nullable restore
#line 2 "x:\dir\subdir\Test\TestComponent.cshtml"
                                        __o = ActionText;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "x:\dir\subdir\Test\TestComponent.cshtml"
   if (!Collapsed)
  {
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "x:\dir\subdir\Test\TestComponent.cshtml"
 __o = ChildContent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "x:\dir\subdir\Test\TestComponent.cshtml"
          
  }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "x:\dir\subdir\Test\TestComponent.cshtml"
 
  [Parameter]
  public RenderFragment ChildContent { get; set; } = (context) => 

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "x:\dir\subdir\Test\TestComponent.cshtml"
                                                                __o = context;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "x:\dir\subdir\Test\TestComponent.cshtml"
                                                                                 
  [Parameter]
  public bool Collapsed { get; set; }
  string ActionText { get => Collapsed ? "Expand" : "Collapse"; }
  void Toggle()
  {
    Collapsed = !Collapsed;
  }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
