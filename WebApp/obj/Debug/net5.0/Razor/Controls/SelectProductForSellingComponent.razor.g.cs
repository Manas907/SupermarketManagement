#pragma checksum "C:\Users\DELL\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\Controls\SelectProductForSellingComponent.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9ba2f72e32518fbb64a8b7dcdc4b1787fb2d6fb5c26e2e398cb939d784d646d9"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApp.Controls
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\DELL\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\_Imports.razor"
using System.Net.Http

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\DELL\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization

#nullable disable
    ;
#nullable restore
#line 3 "C:\Users\DELL\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization

#nullable disable
    ;
#nullable restore
#line 4 "C:\Users\DELL\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms

#nullable disable
    ;
#nullable restore
#line 5 "C:\Users\DELL\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing

#nullable disable
    ;
#nullable restore
#line 6 "C:\Users\DELL\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web

#nullable disable
    ;
#nullable restore
#line 7 "C:\Users\DELL\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization

#nullable disable
    ;
#nullable restore
#line 8 "C:\Users\DELL\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\_Imports.razor"
using Microsoft.JSInterop

#nullable disable
    ;
#nullable restore
#line 9 "C:\Users\DELL\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\_Imports.razor"
using WebApp

#nullable disable
    ;
#nullable restore
#line 10 "C:\Users\DELL\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\_Imports.razor"
using WebApp.Shared

#nullable disable
    ;
#nullable restore
#line 12 "C:\Users\DELL\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\_Imports.razor"
using WebApp.Controls

#nullable disable
    ;
#nullable restore
#line 13 "C:\Users\DELL\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\_Imports.razor"
using CoreBusiness

#nullable disable
    ;
#nullable restore
#line 14 "C:\Users\DELL\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\_Imports.razor"
using UseCases

#line default
#line hidden
#nullable disable
    ;
    #nullable restore
    public partial class SelectProductForSellingComponent : global::Microsoft.AspNetCore.Components.ComponentBase
    #nullable disable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "form-group");
            __builder.AddMarkupContent(2, "<label for=\"category\">Category</label>\r\n    ");
            __builder.OpenElement(3, "select");
            __builder.AddAttribute(4, "id", "category");
            __builder.AddAttribute(5, "class", "form-control");
            __builder.AddAttribute(6, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 6 "C:\Users\DELL\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\Controls\SelectProductForSellingComponent.razor"
                                 SelectedCategoryId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SelectedCategoryId = __value, SelectedCategoryId));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(8, "option");
            __builder.AddAttribute(9, "selected");
            __builder.CloseElement();
#nullable restore
#line 8 "C:\Users\DELL\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\Controls\SelectProductForSellingComponent.razor"
         foreach (var cat in categories)
        {

#line default
#line hidden
#nullable disable

            __builder.OpenElement(10, "option");
            __builder.AddAttribute(11, "value", 
#nullable restore
#line 10 "C:\Users\DELL\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\Controls\SelectProductForSellingComponent.razor"
                            cat.CategoryId

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(12, 
#nullable restore
#line 10 "C:\Users\DELL\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\Controls\SelectProductForSellingComponent.razor"
                                             cat.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 11 "C:\Users\DELL\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\Controls\SelectProductForSellingComponent.razor"
        }

#line default
#line hidden
#nullable disable

            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 14 "C:\Users\DELL\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\Controls\SelectProductForSellingComponent.razor"
 if (productsInCategory != null)
{

#line default
#line hidden
#nullable disable

            __builder.OpenElement(13, "table");
            __builder.AddAttribute(14, "class", "table");
            __builder.AddMarkupContent(15, "<thead><tr><th>Prod Name</th>\r\n                <th>Qty Left</th></tr></thead>\r\n        ");
            __builder.OpenElement(16, "tbody");
#nullable restore
#line 24 "C:\Users\DELL\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\Controls\SelectProductForSellingComponent.razor"
             foreach (var prod in productsInCategory)
            {

#line default
#line hidden
#nullable disable

            __builder.OpenElement(17, "tr");
            __builder.AddAttribute(18, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "C:\Users\DELL\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\Controls\SelectProductForSellingComponent.razor"
                                () => OnSelectProduct(prod)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "style", 
#nullable restore
#line 27 "C:\Users\DELL\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\Controls\SelectProductForSellingComponent.razor"
                             prod.ProductId == selectedProductId?"background-color:beige; cursor:pointer;":"cursor:pointer"

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 29 "C:\Users\DELL\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\Controls\SelectProductForSellingComponent.razor"
                         prod.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 32 "C:\Users\DELL\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\Controls\SelectProductForSellingComponent.razor"
                         prod.Quantity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 35 "C:\Users\DELL\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\Controls\SelectProductForSellingComponent.razor"
            }

#line default
#line hidden
#nullable disable

            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 38 "C:\Users\DELL\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\Controls\SelectProductForSellingComponent.razor"
}

#line default
#line hidden
#nullable disable

        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Users\DELL\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\Controls\SelectProductForSellingComponent.razor"
       

    private IEnumerable<Product> productsInCategory;
    private int selectedProductId;

    [Parameter]
    public EventCallback<Product> OnProductSelected{ get; set; }

    private int selectedCategoryId;
    private int SelectedCategoryId {
        get
        {
            return selectedCategoryId;
        }
        set
        {
            selectedCategoryId = value;
            productsInCategory = ViewProductsByCategoryId.Execute(value);
            OnSelectProduct(null);
            StateHasChanged();
        }
    }

    private IEnumerable<Category> categories;

    protected override void OnInitialized()
    {
        base.OnInitialized();
        categories = ViewCategoriesUseCase.Execute();
    }

    private void OnSelectProduct(Product product)
    {        
        OnProductSelected.InvokeAsync(product);
        if (product != null) selectedProductId = product.ProductId;

    }



#line default
#line hidden
#nullable disable

        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 2 "C:\Users\DELL\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\Controls\SelectProductForSellingComponent.razor"
        IViewProductsByCategoryId

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 2 "C:\Users\DELL\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\Controls\SelectProductForSellingComponent.razor"
                                  ViewProductsByCategoryId

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 1 "C:\Users\DELL\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\Controls\SelectProductForSellingComponent.razor"
        IViewCategoriesUseCase

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 1 "C:\Users\DELL\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\Controls\SelectProductForSellingComponent.razor"
                               ViewCategoriesUseCase

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
    }
}
#pragma warning restore 1591
