#pragma checksum "C:\Projects\Blazor\Blazor\BlazorApp\BlazorServer\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fbbdcafeed663f3eae98c23e0debf6e9c03a6244"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorServer.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Projects\Blazor\Blazor\BlazorApp\BlazorServer\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\Blazor\Blazor\BlazorApp\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Projects\Blazor\Blazor\BlazorApp\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Projects\Blazor\Blazor\BlazorApp\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Projects\Blazor\Blazor\BlazorApp\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Projects\Blazor\Blazor\BlazorApp\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Projects\Blazor\Blazor\BlazorApp\BlazorServer\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Projects\Blazor\Blazor\BlazorApp\BlazorServer\_Imports.razor"
using BlazorServer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Projects\Blazor\Blazor\BlazorApp\BlazorServer\_Imports.razor"
using BlazorServer.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Projects\Blazor\Blazor\BlazorApp\BlazorServer\_Imports.razor"
using BlazorServer.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Counter</h1>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Current count: ");
            __builder.AddContent(3, 
#nullable restore
#line 8 "C:\Projects\Blazor\Blazor\BlazorApp\BlazorServer\Pages\Counter.razor"
                   currentCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenElement(5, "p");
            __builder.AddContent(6, "Scoped count: ");
            __builder.AddContent(7, 
#nullable restore
#line 10 "C:\Projects\Blazor\Blazor\BlazorApp\BlazorServer\Pages\Counter.razor"
                  scoped.Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.OpenElement(9, "p");
            __builder.AddContent(10, "Singleton count: ");
            __builder.AddContent(11, 
#nullable restore
#line 11 "C:\Projects\Blazor\Blazor\BlazorApp\BlazorServer\Pages\Counter.razor"
                     singleton.Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n");
            __builder.OpenElement(13, "p");
            __builder.AddContent(14, "Transient count: ");
            __builder.AddContent(15, 
#nullable restore
#line 12 "C:\Projects\Blazor\Blazor\BlazorApp\BlazorServer\Pages\Counter.razor"
                     transient.Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n\r\n<br>\r\n");
            __builder.AddMarkupContent(17, "<b>To test the services: add some values, go to other pages and come back here.</b>\r\n<br>\r\n\r\n");
            __builder.OpenElement(18, "button");
            __builder.AddAttribute(19, "class", "btn btn-primary");
            __builder.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Projects\Blazor\Blazor\BlazorApp\BlazorServer\Pages\Counter.razor"
                                          IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(21, "Click me");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "C:\Projects\Blazor\Blazor\BlazorApp\BlazorServer\Pages\Counter.razor"
       
    private int currentCount = 0;

    private void IncrementCount()
    {
        currentCount++;
        scoped.Value++;
        transient.Value++;
        singleton.Value++;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ServiceTransient transient { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ServiceSingleton singleton { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ServiceScoped scoped { get; set; }
    }
}
#pragma warning restore 1591
