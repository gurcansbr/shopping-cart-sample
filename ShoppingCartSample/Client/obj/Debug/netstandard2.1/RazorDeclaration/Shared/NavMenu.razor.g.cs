#pragma checksum "C:\Users\gurca\source\repos\ShoppingCartSample\ShoppingCartSample\Client\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d04f28f51e44fbf2586b451846ab037383dfb3b3"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ShoppingCartSample.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\gurca\source\repos\ShoppingCartSample\ShoppingCartSample\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gurca\source\repos\ShoppingCartSample\ShoppingCartSample\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gurca\source\repos\ShoppingCartSample\ShoppingCartSample\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\gurca\source\repos\ShoppingCartSample\ShoppingCartSample\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\gurca\source\repos\ShoppingCartSample\ShoppingCartSample\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\gurca\source\repos\ShoppingCartSample\ShoppingCartSample\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\gurca\source\repos\ShoppingCartSample\ShoppingCartSample\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\gurca\source\repos\ShoppingCartSample\ShoppingCartSample\Client\_Imports.razor"
using ShoppingCartSample.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\gurca\source\repos\ShoppingCartSample\ShoppingCartSample\Client\_Imports.razor"
using ShoppingCartSample.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\gurca\source\repos\ShoppingCartSample\ShoppingCartSample\Client\_Imports.razor"
using ShoppingCartSample.Shared.Models;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "C:\Users\gurca\source\repos\ShoppingCartSample\ShoppingCartSample\Client\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;
    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazor.Extensions.Storage.LocalStorage Storage { get; set; }
    }
}
#pragma warning restore 1591
