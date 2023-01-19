#pragma checksum "C:\Users\Ismail\OneDrive - Sheffield Hallam University\Documents\GitHub\GSM-PROJECT\BlazorApp1\BlazorApp1\Client\Pages\Shop.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81e68eb2468b4e3e5cdd7ff8a05561fa7d1ca7c9"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp1.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Ismail\OneDrive - Sheffield Hallam University\Documents\GitHub\GSM-PROJECT\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ismail\OneDrive - Sheffield Hallam University\Documents\GitHub\GSM-PROJECT\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ismail\OneDrive - Sheffield Hallam University\Documents\GitHub\GSM-PROJECT\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ismail\OneDrive - Sheffield Hallam University\Documents\GitHub\GSM-PROJECT\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Ismail\OneDrive - Sheffield Hallam University\Documents\GitHub\GSM-PROJECT\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Ismail\OneDrive - Sheffield Hallam University\Documents\GitHub\GSM-PROJECT\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Ismail\OneDrive - Sheffield Hallam University\Documents\GitHub\GSM-PROJECT\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Ismail\OneDrive - Sheffield Hallam University\Documents\GitHub\GSM-PROJECT\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Ismail\OneDrive - Sheffield Hallam University\Documents\GitHub\GSM-PROJECT\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using BlazorApp1.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Ismail\OneDrive - Sheffield Hallam University\Documents\GitHub\GSM-PROJECT\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using BlazorApp1.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Ismail\OneDrive - Sheffield Hallam University\Documents\GitHub\GSM-PROJECT\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using BlazorApp1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Ismail\OneDrive - Sheffield Hallam University\Documents\GitHub\GSM-PROJECT\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using BlazorApp1.Client.Services.ProductService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Ismail\OneDrive - Sheffield Hallam University\Documents\GitHub\GSM-PROJECT\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using BlazorApp1.Client.Services.CategoryService;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/shop")]
    public partial class Shop : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Shop</h3>");
#nullable restore
#line 6 "C:\Users\Ismail\OneDrive - Sheffield Hallam University\Documents\GitHub\GSM-PROJECT\BlazorApp1\BlazorApp1\Client\Pages\Shop.razor"
     foreach (var category in CategoryService.Categories)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "li");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(2);
            __builder.AddAttribute(3, "class", "nav-link");
            __builder.AddAttribute(4, "href", 
#nullable restore
#line 9 "C:\Users\Ismail\OneDrive - Sheffield Hallam University\Documents\GitHub\GSM-PROJECT\BlazorApp1\BlazorApp1\Client\Pages\Shop.razor"
                                             category.Url

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(6, "span");
                __builder2.AddAttribute(7, "class", "oi-" + (
#nullable restore
#line 10 "C:\Users\Ismail\OneDrive - Sheffield Hallam University\Documents\GitHub\GSM-PROJECT\BlazorApp1\BlazorApp1\Client\Pages\Shop.razor"
                               category.Icon

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(8, "aria-hidden", "true");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(9, "\r\n            ");
#nullable restore
#line 11 "C:\Users\Ismail\OneDrive - Sheffield Hallam University\Documents\GitHub\GSM-PROJECT\BlazorApp1\BlazorApp1\Client\Pages\Shop.razor"
__builder2.AddContent(10, category.Name);

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 15 "C:\Users\Ismail\OneDrive - Sheffield Hallam University\Documents\GitHub\GSM-PROJECT\BlazorApp1\BlazorApp1\Client\Pages\Shop.razor"
    }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "C:\Users\Ismail\OneDrive - Sheffield Hallam University\Documents\GitHub\GSM-PROJECT\BlazorApp1\BlazorApp1\Client\Pages\Shop.razor"
       
     protected override async Task OnInitializedAsync()
    {
       await  CategoryService.LoadCategories(); //loading all the categories
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICategoryService CategoryService { get; set; }
    }
}
#pragma warning restore 1591
