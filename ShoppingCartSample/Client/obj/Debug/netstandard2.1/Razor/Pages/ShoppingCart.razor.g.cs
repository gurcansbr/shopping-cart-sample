#pragma checksum "C:\Users\gurca\source\repos\ShoppingCartSample\ShoppingCartSample\Client\Pages\ShoppingCart.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4505318e3dbeb8b7424c2d44bfe74096db13e299"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<h3>Shopping Cart</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container mb-4");
            __builder.AddMarkupContent(3, "\r\n");
#nullable restore
#line 8 "C:\Users\gurca\source\repos\ShoppingCartSample\ShoppingCartSample\Client\Pages\ShoppingCart.razor"
     if (!string.IsNullOrEmpty(Message))
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "        ");
            __builder.OpenComponent<ShoppingCartSample.Client.Shared.Messages>(5);
            __builder.AddAttribute(6, "Message", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 10 "C:\Users\gurca\source\repos\ShoppingCartSample\ShoppingCartSample\Client\Pages\ShoppingCart.razor"
                            Message

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 10 "C:\Users\gurca\source\repos\ShoppingCartSample\ShoppingCartSample\Client\Pages\ShoppingCart.razor"
                                            type

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(8, "\r\n");
#nullable restore
#line 11 "C:\Users\gurca\source\repos\ShoppingCartSample\ShoppingCartSample\Client\Pages\ShoppingCart.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(9, "    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "row");
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "col-12");
            __builder.AddMarkupContent(15, "\r\n            ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "table-responsive");
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenElement(19, "table");
            __builder.AddAttribute(20, "class", "table table-striped");
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.AddMarkupContent(22, @"<thead>
                        <tr>
                            <th scope=""col""> </th>
                            <th scope=""col"">Product</th>
                            <th scope=""col"">Available</th>
                            <th scope=""col"" class=""text-center"">Quantity</th>
                            <th scope=""col"" class=""text-right"">Price</th>
                            <th></th>
                        </tr>
                    </thead>
                    ");
            __builder.OpenElement(23, "tbody");
            __builder.AddMarkupContent(24, "\r\n");
#nullable restore
#line 27 "C:\Users\gurca\source\repos\ShoppingCartSample\ShoppingCartSample\Client\Pages\ShoppingCart.razor"
                         if (cart != null)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\gurca\source\repos\ShoppingCartSample\ShoppingCartSample\Client\Pages\ShoppingCart.razor"
                             foreach (CartLine cartItem in cart.Products)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(25, "                                ");
            __builder.OpenElement(26, "tr");
            __builder.AddMarkupContent(27, "\r\n                                    ");
            __builder.AddMarkupContent(28, "<td><img src=\"https://dummyimage.com/50x50/55595c/fff\"> </td>\r\n                                    ");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 33 "C:\Users\gurca\source\repos\ShoppingCartSample\ShoppingCartSample\Client\Pages\ShoppingCart.razor"
                                         cartItem.Product.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                                    ");
            __builder.AddMarkupContent(32, "<td>In stock</td>\r\n                                    ");
            __builder.OpenElement(33, "td");
            __builder.OpenElement(34, "input");
            __builder.AddAttribute(35, "class", "form-control");
            __builder.AddAttribute(36, "type", "number");
            __builder.AddAttribute(37, "value", 
#nullable restore
#line 35 "C:\Users\gurca\source\repos\ShoppingCartSample\ShoppingCartSample\Client\Pages\ShoppingCart.razor"
                                                                                          cartItem.Quantity

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(38, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\gurca\source\repos\ShoppingCartSample\ShoppingCartSample\Client\Pages\ShoppingCart.razor"
                                                                                                                         (e) => UpdateCart(cartItem, Convert.ToInt32(e.Value))

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                                    ");
            __builder.OpenElement(40, "td");
            __builder.AddAttribute(41, "class", "text-right");
            __builder.AddContent(42, 
#nullable restore
#line 36 "C:\Users\gurca\source\repos\ShoppingCartSample\ShoppingCartSample\Client\Pages\ShoppingCart.razor"
                                                            cartItem.Product.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                                    ");
            __builder.OpenElement(44, "td");
            __builder.AddAttribute(45, "class", "text-right");
            __builder.OpenElement(46, "button");
            __builder.AddAttribute(47, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "C:\Users\gurca\source\repos\ShoppingCartSample\ShoppingCartSample\Client\Pages\ShoppingCart.razor"
                                                                               () => RemoveById(cartItem.Product)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(48, "class", "btn btn-sm btn-danger");
            __builder.AddMarkupContent(49, "<i class=\"fa fa-trash\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n");
#nullable restore
#line 39 "C:\Users\gurca\source\repos\ShoppingCartSample\ShoppingCartSample\Client\Pages\ShoppingCart.razor"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\gurca\source\repos\ShoppingCartSample\ShoppingCartSample\Client\Pages\ShoppingCart.razor"
                             
                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(52, "                        ");
            __builder.OpenElement(53, "tr");
            __builder.AddMarkupContent(54, "\r\n                            <td></td>\r\n                            <td></td>\r\n                            <td></td>\r\n                            <td></td>\r\n                            ");
            __builder.AddMarkupContent(55, "<td><strong>Total</strong></td>\r\n                            ");
            __builder.OpenElement(56, "td");
            __builder.AddAttribute(57, "class", "text-right");
            __builder.OpenElement(58, "strong");
            __builder.AddContent(59, 
#nullable restore
#line 47 "C:\Users\gurca\source\repos\ShoppingCartSample\ShoppingCartSample\Client\Pages\ShoppingCart.razor"
                                                            total

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n        ");
            __builder.OpenElement(66, "div");
            __builder.AddAttribute(67, "class", "col mb-2");
            __builder.AddMarkupContent(68, "\r\n            ");
            __builder.OpenElement(69, "div");
            __builder.AddAttribute(70, "class", "row");
            __builder.AddMarkupContent(71, "\r\n                ");
            __builder.OpenElement(72, "div");
            __builder.AddAttribute(73, "class", "col-sm-12  col-md-6");
            __builder.AddMarkupContent(74, "\r\n                    ");
            __builder.OpenElement(75, "button");
            __builder.AddAttribute(76, "class", "btn btn-block btn-light");
            __builder.AddAttribute(77, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 56 "C:\Users\gurca\source\repos\ShoppingCartSample\ShoppingCartSample\Client\Pages\ShoppingCart.razor"
                                                                       ContinueShopping

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(78, "Continue Shopping");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n                ");
            __builder.AddMarkupContent(81, "<div class=\"col-sm-12 col-md-6 text-right\">\r\n                    <button type=\"button\" class=\"btn btn-block btn-success text-uppercase\">Checkout</button>\r\n                </div>\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n");
            __builder.CloseElement();
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
