#pragma checksum "C:\Projects\Blazor\Blazor\BlazorApp\BlazorWebAssembly\Shared\Tasks.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad294224a227f62a613f0b6ec6fe1040bcabe159"
// <auto-generated/>
#pragma warning disable 1591
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
    public partial class Tasks : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h1");
            __builder.AddContent(1, 
#nullable restore
#line 1 "C:\Projects\Blazor\Blazor\BlazorApp\BlazorWebAssembly\Shared\Tasks.razor"
     Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(2, "\r\n<hr>\r\n\r\n    ");
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.AddMarkupContent(6, "<thead>\r\n            <tr>\r\n                <th>Action</th>\r\n                <th>Date</th>\r\n                <th>Description</th>\r\n                <th>Done</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(7, "tbody");
            __builder.AddMarkupContent(8, "\r\n            ");
            __Blazor.BlazorWebAssembly.Shared.Tasks.TypeInference.CreateGenericList_0(__builder, 9, 10, 
#nullable restore
#line 42 "C:\Projects\Blazor\Blazor\BlazorApp\BlazorWebAssembly\Shared\Tasks.razor"
                                   tasks

#line default
#line hidden
#nullable disable
            , 11, (context) => (__builder2) => {
                __builder2.AddMarkupContent(12, "\r\n                    ");
                __builder2.OpenComponent<BlazorWebAssembly.Shared.TaskInvidual>(13);
                __builder2.AddAttribute(14, "item", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorWebAssembly.Entities.TaskItem>(
#nullable restore
#line 44 "C:\Projects\Blazor\Blazor\BlazorApp\BlazorWebAssembly\Shared\Tasks.razor"
                                        context

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "RemoveTask", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorWebAssembly.Entities.TaskItem>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorWebAssembly.Entities.TaskItem>(this, 
#nullable restore
#line 44 "C:\Projects\Blazor\Blazor\BlazorApp\BlazorWebAssembly\Shared\Tasks.razor"
                                                             RemoveTask

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\r\n                ");
            }
            );
            __builder.AddMarkupContent(17, "\r\n\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n\r\n");
#nullable restore
#line 59 "C:\Projects\Blazor\Blazor\BlazorApp\BlazorWebAssembly\Shared\Tasks.razor"
 if (tasks != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(20, "    ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "form-group");
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.AddMarkupContent(24, "<label>Task</label>\r\n        ");
            __builder.OpenElement(25, "input");
            __builder.AddAttribute(26, "type", "text");
            __builder.AddAttribute(27, "placeholder", "Inform the task test");
            __builder.AddAttribute(28, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 63 "C:\Projects\Blazor\Blazor\BlazorApp\BlazorWebAssembly\Shared\Tasks.razor"
                                                                     newTask

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newTask = __value, newTask));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n        ");
            __builder.OpenElement(31, "button");
            __builder.AddAttribute(32, "class", "btn btn-primary");
            __builder.AddAttribute(33, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 64 "C:\Projects\Blazor\Blazor\BlazorApp\BlazorWebAssembly\Shared\Tasks.razor"
                                                  AddNewTask

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(34, "Create new task");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n");
#nullable restore
#line 66 "C:\Projects\Blazor\Blazor\BlazorApp\BlazorWebAssembly\Shared\Tasks.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 69 "C:\Projects\Blazor\Blazor\BlazorApp\BlazorWebAssembly\Shared\Tasks.razor"
      
    [Parameter] public List<TaskItem> tasks { get; set; }
    [Parameter] public string Title { get; set; }

    private string newTask = "";

    void AddNewTask()
    {
        if (!string.IsNullOrWhiteSpace(newTask))
        {
            tasks.Add(new TaskItem()
            {
                Creation = DateTime.Now,
                Description = newTask,
                ID = Guid.NewGuid()
            });
            newTask = "";
        }
    }

    void RemoveTask(TaskItem task)
    {
        tasks.Remove(tasks.First(t => t.ID == task.ID));
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.BlazorWebAssembly.Shared.Tasks
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateGenericList_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.List<T> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment<T> __arg1)
        {
        __builder.OpenComponent<global::BlazorWebAssembly.Shared.GenericList<T>>(seq);
        __builder.AddAttribute(__seq0, "ItemList", __arg0);
        __builder.AddAttribute(__seq1, "ListRender", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
