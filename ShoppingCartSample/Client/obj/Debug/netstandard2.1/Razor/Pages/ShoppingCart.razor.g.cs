#pragma checksum "C:\Users\gurca\source\repos\ShoppingCartSample\ShoppingCartSample\Client\Pages\ShoppingCart.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ab86f5c9f472803530a445d0c8463b0784dfa83"
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
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row");
            __builder.AddMarkupContent(6, "\r\n");
#nullable restore
#line 9 "C:\Users\gurca\source\repos\ShoppingCartSample\ShoppingCartSample\Client\Pages\ShoppingCart.razor"
         if (!string.IsNullOrEmpty(Message))
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "            ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "alert alert-success");
            __builder.AddMarkupContent(10, "\r\n                ");
            __builder.AddContent(11, 
#nullable restore
#line 12 "C:\Users\gurca\source\repos\ShoppingCartSample\ShoppingCartSample\Client\Pages\ShoppingCart.razor"
                 Message

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.AddMarkupContent(13, "<button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\r\n                    <span aria-hidden=\"true\">&times;</span>\r\n                </button>\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n");
#nullable restore
#line 17 "C:\Users\gurca\source\repos\ShoppingCartSample\ShoppingCartSample\Client\Pages\ShoppingCart.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(15, "        ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "col-12");
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "table-responsive");
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.OpenElement(22, "table");
            __builder.AddAttribute(23, "class", "table table-striped");
            __builder.AddMarkupContent(24, "\r\n                    ");
            __builder.AddMarkupContent(25, @"<thead>
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
            __builder.OpenElement(26, "tbody");
            __builder.AddMarkupContent(27, "\r\n");
#nullable restore
#line 32 "C:\Users\gurca\source\repos\ShoppingCartSample\ShoppingCartSample\Client\Pages\ShoppingCart.razor"
                         if (cart != null)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\gurca\source\repos\ShoppingCartSample\ShoppingCartSample\Client\Pages\ShoppingCart.razor"
                             foreach (CartLine cartItem in cart.Products)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(28, "                                ");
            __builder.OpenElement(29, "tr");
            __builder.AddMarkupContent(30, "\r\n                                    ");
            __builder.AddMarkupContent(31, "<td><img src=\"https://dummyimage.com/50x50/55595c/fff\"> </td>\r\n                                    ");
            __builder.OpenElement(32, "td");
            __builder.AddContent(33, 
#nullable restore
#line 38 "C:\Users\gurca\source\repos\ShoppingCartSample\ShoppingCartSample\Client\Pages\ShoppingCart.razor"
                                         cartItem.Product.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                                    ");
            __builder.AddMarkupContent(35, "<td>In stock</td>\r\n                                    ");
            __builder.OpenElement(36, "td");
            __builder.OpenElement(37, "input");
            __builder.AddAttribute(38, "class", "form-control");
            __builder.AddAttribute(39, "type", "text");
            __builder.AddAttribute(40, "value", 
#nullable restore
#line 40 "C:\Users\gurca\source\repos\ShoppingCartSample\ShoppingCartSample\Client\Pages\ShoppingCart.razor"
                                                                                        cartItem.Quantity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                                    ");
            __builder.OpenElement(42, "td");
            __builder.AddAttribute(43, "class", "text-right");
            __builder.AddContent(44, 
#nullable restore
#line 41 "C:\Users\gurca\source\repos\ShoppingCartSample\ShoppingCartSample\Client\Pages\ShoppingCart.razor"
                                                            cartItem.Product.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                                    ");
            __builder.OpenElement(46, "td");
            __builder.AddAttribute(47, "class", "text-right");
            __builder.OpenElement(48, "button");
            __builder.AddAttribute(49, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "C:\Users\gurca\source\repos\ShoppingCartSample\ShoppingCartSample\Client\Pages\ShoppingCart.razor"
                                                                               () => RemoveById(cartItem.Product)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(50, "class", "btn btn-sm btn-danger");
            __builder.AddMarkupContent(51, "<i class=\"fa fa-trash\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n");
#nullable restore
#line 44 "C:\Users\gurca\source\repos\ShoppingCartSample\ShoppingCartSample\Client\Pages\ShoppingCart.razor"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\gurca\source\repos\ShoppingCartSample\ShoppingCartSample\Client\Pages\ShoppingCart.razor"
                             
                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(54, "                        ");
            __builder.OpenElement(55, "tr");
            __builder.AddMarkupContent(56, "\r\n                            <td></td>\r\n                            <td></td>\r\n                            <td></td>\r\n                            <td></td>\r\n                            ");
            __builder.AddMarkupContent(57, "<td><strong>Total</strong></td>\r\n                            ");
            __builder.OpenElement(58, "td");
            __builder.AddAttribute(59, "class", "text-right");
            __builder.OpenElement(60, "strong");
            __builder.AddContent(61, 
#nullable restore
#line 52 "C:\Users\gurca\source\repos\ShoppingCartSample\ShoppingCartSample\Client\Pages\ShoppingCart.razor"
                                                            total

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n        ");
            __builder.OpenElement(68, "div");
            __builder.AddAttribute(69, "class", "col mb-2");
            __builder.AddMarkupContent(70, "\r\n            ");
            __builder.OpenElement(71, "div");
            __builder.AddAttribute(72, "class", "row");
            __builder.AddMarkupContent(73, "\r\n                ");
            __builder.OpenElement(74, "div");
            __builder.AddAttribute(75, "class", "col-sm-12  col-md-6");
            __builder.AddMarkupContent(76, "\r\n                    ");
            __builder.OpenElement(77, "button");
            __builder.AddAttribute(78, "class", "btn btn-block btn-light");
            __builder.AddAttribute(79, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 61 "C:\Users\gurca\source\repos\ShoppingCartSample\ShoppingCartSample\Client\Pages\ShoppingCart.razor"
                                                                       ContinueShopping

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(80, "Continue Shopping");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n                ");
            __builder.AddMarkupContent(83, "<div class=\"col-sm-12 col-md-6 text-right\">\r\n                    <button type=\"button\" class=\"btn btn-block btn-success text-uppercase\">Checkout</button>\r\n                </div>\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 71 "C:\Users\gurca\source\repos\ShoppingCartSample\ShoppingCartSample\Client\Pages\ShoppingCart.razor"
       
    Cart cart;
    double total = 0;
    string Message = "";

    // on render of page
    protected override async Task OnInitializedAsync()
    {
        cart = await Storage.GetItem<Cart>("Cart");
        total = cart.Products.Sum(c => c.Product.Price * c.Quantity);
    }

    // remove item from shopping cart
    async Task RemoveById(Product product)
    {
        cart = await Storage.GetItem<Cart>("Cart");
        cart.Products.RemoveAll(c => c.Product.ProductId == product.ProductId);
        await Storage.SetItem<Cart>("Cart", cart);
        total = cart.Products.Sum(c => c.Product.Price * c.Quantity);
        Message = product.Title + " removed from your shopping cart";
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