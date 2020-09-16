#pragma checksum "C:\Projects\Blazor\Blazor\BlazorApp\BlazorWebAssembly\Pages\Event1.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f3eab3892bb9565e3f9279b2523e6e88a89cc4f"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorWebAssembly.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Projects\Blazor\Blazor\BlazorApp\BlazorWebAssembly\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\Blazor\Blazor\BlazorApp\BlazorWebAssembly\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Projects\Blazor\Blazor\BlazorApp\BlazorWebAssembly\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Projects\Blazor\Blazor\BlazorApp\BlazorWebAssembly\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Projects\Blazor\Blazor\BlazorApp\BlazorWebAssembly\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Projects\Blazor\Blazor\BlazorApp\BlazorWebAssembly\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Projects\Blazor\Blazor\BlazorApp\BlazorWebAssembly\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Projects\Blazor\Blazor\BlazorApp\BlazorWebAssembly\_Imports.razor"
using BlazorWebAssembly;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Projects\Blazor\Blazor\BlazorApp\BlazorWebAssembly\_Imports.razor"
using BlazorWebAssembly.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Projects\Blazor\Blazor\BlazorApp\BlazorWebAssembly\_Imports.razor"
using BlazorWebAssembly.Entities;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/event1")]
    public partial class Event1 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<label>Press A to change the color</label>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "style", "background-color:" + " " + (
#nullable restore
#line 5 "C:\Projects\Blazor\Blazor\BlazorApp\BlazorWebAssembly\Pages\Event1.razor"
                               color

#line default
#line hidden
#nullable disable
            ) + ";" + " padding:" + " 50px");
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.OpenElement(4, "input");
            __builder.AddAttribute(5, "type", "text");
            __builder.AddAttribute(6, "onkeypress", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 7 "C:\Projects\Blazor\Blazor\BlazorApp\BlazorWebAssembly\Pages\Event1.razor"
                                (e => KeyPressed(e))

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "C:\Projects\Blazor\Blazor\BlazorApp\BlazorWebAssembly\Pages\Event1.razor"
       
    private string color = "red";

    void KeyPressed(KeyboardEventArgs args)
    {
        if (args.Key == "A" || args.Key == "a")
        {
            color = "blue";
            Console.WriteLine("They key A/a was pressed.");
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
