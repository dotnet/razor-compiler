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
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "myvalue", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 1 "x:\dir\subdir\Test\TestComponent.cshtml"
             ParentValue

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "myevent", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ParentValue = __value, ParentValue));
            __builder.SetUpdatesAttributeName("myvalue");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 2 "x:\dir\subdir\Test\TestComponent.cshtml"
       
    public string ParentValue { get; set; } = "hi";

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
