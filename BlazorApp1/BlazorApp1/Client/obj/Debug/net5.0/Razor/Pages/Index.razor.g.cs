#pragma checksum "C:\Users\Ismail\OneDrive - Sheffield Hallam University\Documents\GitHub\GSM-PROJECT\BlazorApp1\BlazorApp1\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67b61cb753c42eabeaea865c5a47277cfd5878a2"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/{categoryurl}")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "C:\Users\Ismail\OneDrive - Sheffield Hallam University\Documents\GitHub\GSM-PROJECT\BlazorApp1\BlazorApp1\Client\Pages\Index.razor"
 if (category != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "h1");
            __builder.AddContent(1, "Welceome to the ");
#nullable restore
#line 7 "C:\Users\Ismail\OneDrive - Sheffield Hallam University\Documents\GitHub\GSM-PROJECT\BlazorApp1\BlazorApp1\Client\Pages\Index.razor"
__builder.AddContent(2, category.Name);

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, " section!");
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenComponent<BlazorApp1.Client.Shared.ProductList>(5);
            __builder.AddAttribute(6, "CategoryId", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#nullable restore
#line 8 "C:\Users\Ismail\OneDrive - Sheffield Hallam University\Documents\GitHub\GSM-PROJECT\BlazorApp1\BlazorApp1\Client\Pages\Index.razor"
                              category.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 9 "C:\Users\Ismail\OneDrive - Sheffield Hallam University\Documents\GitHub\GSM-PROJECT\BlazorApp1\BlazorApp1\Client\Pages\Index.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(7, "<h1> Welcome to GSM SHOP!</h1>\r\n    ");
            __builder.OpenComponent<BlazorApp1.Client.Shared.ProductList>(8);
            __builder.CloseComponent();
#nullable restore
#line 14 "C:\Users\Ismail\OneDrive - Sheffield Hallam University\Documents\GitHub\GSM-PROJECT\BlazorApp1\BlazorApp1\Client\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "C:\Users\Ismail\OneDrive - Sheffield Hallam University\Documents\GitHub\GSM-PROJECT\BlazorApp1\BlazorApp1\Client\Pages\Index.razor"
 
    [Parameter]

    public string CategoryUrl { get; set; }

    private Category category = null;

    protected override void OnParametersSet()
    {
        if (CategoryUrl != null) //making sure category url is not null
        {

            category = CategoryService.Categories.FirstOrDefault(c => c.Url.ToLower().Equals(CategoryUrl.ToLower()));

        }
        else
        {
            category = null;
        }

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICategoryService CategoryService { get; set; }
    }
}
#pragma warning restore 1591
