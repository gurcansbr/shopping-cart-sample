#pragma checksum "C:\Users\gurca\source\repos\ShoppingCartSample\ShoppingCartSample\Client\Pages\ShoppingCart.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4505318e3dbeb8b7424c2d44bfe74096db13e299"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ShoppingCartSample.Client.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/shoppingcart")]
    public partial class ShoppingCart : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 66 "C:\Users\gurca\source\repos\ShoppingCartSample\ShoppingCartSample\Client\Pages\ShoppingCart.razor"
       
    Cart cart;
    double total = 0;
    string Message = "";
    string type = "";

    // on render of page
    protected override async Task OnInitializedAsync()
    {
        cart = await Storage.GetItem<Cart>("Cart");
        if (cart == null)
        {
            cart = new Cart
            {
                Products = new List<CartLine>(),
            };
            await Storage.SetItem("Cart", cart);
        }
        total = cart.Products.Sum(c => c.Product.Price * c.Quantity);
    }

    // remove item from shopping cart
    async Task RemoveById(Product product)
    {
        //cart = await Storage.GetItem<Cart>("Cart");
        cart.Products.RemoveAll(c => c.Product.ProductId == product.ProductId);
        await Storage.SetItem<Cart>("Cart", cart);
        total = cart.Products.Sum(c => c.Product.Price * c.Quantity);
        Message = product.Title + " removed from your shopping cart";
        type = "danger";
    }

    async Task UpdateCart(CartLine cartItem, int quantity)
    {
        if(quantity > cartItem.Product.Stock)
        {
            Message = "There is no avaiable stock for " + cartItem.Product.Title;
            type = "danger";
            return;
        }

        var item = cart.Products.FirstOrDefault(c => c.Product.ProductId == cartItem.Product.ProductId);
        if (item != null)
        {
            if(quantity > 0)
            {
                item.Quantity = quantity;
                Message = cartItem.Product.Title + " quantity updated";
                type = "info";
            }
            else
            {
                cart.Products.Remove(cartItem);
                Message = cartItem.Product.Title + " was removed from your cart";
                type = "danger";
            }

            total = cart.Products.Sum(c => c.Product.Price * c.Quantity);
            await Storage.SetItem<Cart>("Cart", cart);
        }
    }

    void ContinueShopping()
    {
        NavigationManager.NavigateTo("/");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazor.Extensions.Storage.LocalStorage Storage { get; set; }
    }
}
#pragma warning restore 1591
