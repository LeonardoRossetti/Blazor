#pragma checksum "C:\Projects\Blazor\BlazorApp\BlazorWebAssembly\Shared\Tasks.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad1a510762784ac8d050a52805012abe70072c99"
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
#line 1 "C:\Projects\Blazor\BlazorApp\BlazorWebAssembly\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\Blazor\BlazorApp\BlazorWebAssembly\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Projects\Blazor\BlazorApp\BlazorWebAssembly\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Projects\Blazor\BlazorApp\BlazorWebAssembly\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Projects\Blazor\BlazorApp\BlazorWebAssembly\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Projects\Blazor\BlazorApp\BlazorWebAssembly\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Projects\Blazor\BlazorApp\BlazorWebAssembly\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Projects\Blazor\BlazorApp\BlazorWebAssembly\_Imports.razor"
using BlazorWebAssembly;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Projects\Blazor\BlazorApp\BlazorWebAssembly\_Imports.razor"
using BlazorWebAssembly.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Projects\Blazor\BlazorApp\BlazorWebAssembly\_Imports.razor"
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
#line 1 "C:\Projects\Blazor\BlazorApp\BlazorWebAssembly\Shared\Tasks.razor"
     Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(2, "\r\n<hr>\r\n\r\n");
#nullable restore
#line 4 "C:\Projects\Blazor\BlazorApp\BlazorWebAssembly\Shared\Tasks.razor"
 if (tasks == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenComponent<BlazorWebAssembly.Shared.Alert>(4);
            __builder.AddAttribute(5, "Message", "Loading...");
            __builder.AddAttribute(6, "ChildContent1", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(7, "\r\n            <img src=\"https://media.giphy.com/media/8L0Pky6C83SzkzU55a/giphy.gif\">\r\n        ");
            }
            ));
            __builder.AddAttribute(8, "ChildContent2", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(9, "\r\n            ");
                __builder2.AddMarkupContent(10, "<span>Error when loading tasks.</span>\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(11, "\r\n");
#nullable restore
#line 14 "C:\Projects\Blazor\BlazorApp\BlazorWebAssembly\Shared\Tasks.razor"
}
else if (!tasks.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(12, "    ");
            __builder.OpenComponent<BlazorWebAssembly.Shared.Alert>(13);
            __builder.AddAttribute(14, "Message", "No tasks were created...");
            __builder.AddAttribute(15, "ChildContent2", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(16, "\r\n            ");
                __builder2.AddMarkupContent(17, @"<div class=""row"">
                <div class=""col-6"">
                    <img src=""https://media.giphy.com/media/17mNCcKU1mJlrbXodo/giphy.gif"">
                </div>
                <div class=""col-6"">
                    <span>Please create one task.</span>
                </div>
            </div>
        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(18, "\r\n");
#nullable restore
#line 29 "C:\Projects\Blazor\BlazorApp\BlazorWebAssembly\Shared\Tasks.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(19, "    ");
            __builder.OpenElement(20, "table");
            __builder.AddAttribute(21, "class", "table");
            __builder.AddMarkupContent(22, "\r\n        ");
            __builder.AddMarkupContent(23, "<thead>\r\n            <tr>\r\n                <td>Action</td>\r\n                <td>Date</td>\r\n                <td>Description</td>\r\n                <td>Done</td>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(24, "tbody");
            __builder.AddMarkupContent(25, "\r\n");
#nullable restore
#line 42 "C:\Projects\Blazor\BlazorApp\BlazorWebAssembly\Shared\Tasks.razor"
             foreach (var item in tasks)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(26, "                ");
            __builder.OpenElement(27, "tr");
            __builder.AddMarkupContent(28, "\r\n                    ");
            __builder.OpenComponent<BlazorWebAssembly.Shared.TaskInvidual>(29);
            __builder.AddAttribute(30, "item", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorWebAssembly.Entities.TaskItem>(
#nullable restore
#line 45 "C:\Projects\Blazor\BlazorApp\BlazorWebAssembly\Shared\Tasks.razor"
                                        item

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(31, "RemoveTask", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorWebAssembly.Entities.TaskItem>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorWebAssembly.Entities.TaskItem>(this, 
#nullable restore
#line 45 "C:\Projects\Blazor\BlazorApp\BlazorWebAssembly\Shared\Tasks.razor"
                                                          RemoveTask

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(32, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n");
#nullable restore
#line 47 "C:\Projects\Blazor\BlazorApp\BlazorWebAssembly\Shared\Tasks.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(34, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n");
#nullable restore
#line 50 "C:\Projects\Blazor\BlazorApp\BlazorWebAssembly\Shared\Tasks.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(37, "\r\n");
#nullable restore
#line 52 "C:\Projects\Blazor\BlazorApp\BlazorWebAssembly\Shared\Tasks.razor"
 if (tasks != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(38, "    ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "form-group");
            __builder.AddMarkupContent(41, "\r\n        ");
            __builder.AddMarkupContent(42, "<label>Task</label>\r\n        ");
            __builder.OpenElement(43, "input");
            __builder.AddAttribute(44, "type", "text");
            __builder.AddAttribute(45, "placeholder", "Inform the task test");
            __builder.AddAttribute(46, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 56 "C:\Projects\Blazor\BlazorApp\BlazorWebAssembly\Shared\Tasks.razor"
                                                                     newTask

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(47, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newTask = __value, newTask));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n        ");
            __builder.OpenElement(49, "button");
            __builder.AddAttribute(50, "class", "btn btn-primary");
            __builder.AddAttribute(51, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 57 "C:\Projects\Blazor\BlazorApp\BlazorWebAssembly\Shared\Tasks.razor"
                                                  AddNewTask

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(52, "Create new task");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n");
#nullable restore
#line 59 "C:\Projects\Blazor\BlazorApp\BlazorWebAssembly\Shared\Tasks.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 62 "C:\Projects\Blazor\BlazorApp\BlazorWebAssembly\Shared\Tasks.razor"
      
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
#pragma warning restore 1591