#pragma checksum "C:\Projects\Blazor\Blazor\BlazorApp\BlazorWebAssembly\Shared\GenericList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72a71c5edae0c8f0136db2819cac39f047c3a596"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorWebAssembly.Shared
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
    public partial class GenericList<T> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "C:\Projects\Blazor\Blazor\BlazorApp\BlazorWebAssembly\Shared\GenericList.razor"
       
    [Parameter] public RenderFragment Loading { get; set; }
    [Parameter] public RenderFragment NoItems { get; set; }
    [Parameter] public List<T> ItemList { get; set; }
    [Parameter] public RenderFragment<T> ListRender { get; set; }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
