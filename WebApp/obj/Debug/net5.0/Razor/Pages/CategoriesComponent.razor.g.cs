#pragma checksum "C:\Users\DELL\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\Pages\CategoriesComponent.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1c5831f29e5522f1cf71273ae30974bde3f5af85e0ed16e9452dcafd27917647"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApp.Pages
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
#line 2 "C:\Users\DELL\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\Pages\CategoriesComponent.razor"
           [Authorize(Policy = "AdminOnly")]

#line default
#line hidden
#nullable disable

    [global::Microsoft.AspNetCore.Components.RouteAttribute(
    // language=Route,Component
#nullable restore
#line 1 "C:\Users\DELL\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\Pages\CategoriesComponent.razor"
      "/categories"

#line default
#line hidden
#nullable disable
    )]
    #nullable restore
    public partial class CategoriesComponent : global::Microsoft.AspNetCore.Components.ComponentBase
    #nullable disable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Manage Categories</h3>\r\n<br>");
#nullable restore
#line 10 "C:\Users\DELL\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\Pages\CategoriesComponent.razor"
 if (categories != null)
{


#line default
#line hidden
#nullable disable

            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table");
            __builder.AddMarkupContent(3, "<thead><tr><th>Name</th>\r\n                <th>Description</th>\r\n                <th></th></tr></thead>\r\n        ");
            __builder.OpenElement(4, "tbody");
#nullable restore
#line 22 "C:\Users\DELL\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\Pages\CategoriesComponent.razor"
             foreach (var category in categories)
            {

#line default
#line hidden
#nullable disable

            __builder.OpenElement(5, "tr");
            __builder.OpenElement(6, "td");
            __builder.AddContent(7, 
#nullable restore
#line 25 "C:\Users\DELL\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\Pages\CategoriesComponent.razor"
                         category.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n                    ");
            __builder.OpenElement(9, "td");
            __builder.AddContent(10, 
#nullable restore
#line 26 "C:\Users\DELL\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\Pages\CategoriesComponent.razor"
                         category.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n                    ");
            __builder.OpenElement(12, "td");
            __builder.OpenElement(13, "button");
            __builder.AddAttribute(14, "type", "button");
            __builder.AddAttribute(15, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "C:\Users\DELL\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\Pages\CategoriesComponent.razor"
                                                          () => EditCategory(category)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "class", "btn btn-link");
            __builder.AddContent(17, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                        ");
            __builder.OpenElement(19, "button");
            __builder.AddAttribute(20, "type", "button");
            __builder.AddAttribute(21, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "C:\Users\DELL\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\Pages\CategoriesComponent.razor"
                                                          () => DeleteCategory(category.CategoryId)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "class", "btn btn-link");
            __builder.AddContent(23, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 32 "C:\Users\DELL\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\Pages\CategoriesComponent.razor"
            }

#line default
#line hidden
#nullable disable

            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 35 "C:\Users\DELL\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\Pages\CategoriesComponent.razor"
}

#line default
#line hidden
#nullable disable

            __builder.AddMarkupContent(24, "<br>\r\n");
            __builder.OpenElement(25, "button");
            __builder.AddAttribute(26, "type", "button");
            __builder.AddAttribute(27, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "C:\Users\DELL\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\Pages\CategoriesComponent.razor"
                                OnClickAddCategory

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "class", "btn btn-primary");
            __builder.AddContent(29, "Add Category");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Users\DELL\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\Pages\CategoriesComponent.razor"
       

    private List<Category> categories;

    protected override void OnInitialized()
    {
        base.OnInitialized();
        LoadCategories();
    }

    private void OnClickAddCategory()
    {
        NavigationManager.NavigateTo("/addcategory");
    }

    private void EditCategory(Category category)
    {
        NavigationManager.NavigateTo($"/editcategory/{category.CategoryId}");
    }

    private void DeleteCategory(int categoryId)
    {
        DeleteCategoryUseCase.Delete(categoryId);
        LoadCategories();
    }

    private void LoadCategories()
    {
        categories = ViewCategoryUseCase.Execute()?.ToList();
    }

#line default
#line hidden
#nullable disable

        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 6 "C:\Users\DELL\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\Pages\CategoriesComponent.razor"
        UseCases.IDeleteCategoryUseCase

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 6 "C:\Users\DELL\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\Pages\CategoriesComponent.razor"
                                        DeleteCategoryUseCase

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 5 "C:\Users\DELL\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\Pages\CategoriesComponent.razor"
        UseCases.IViewCategoriesUseCase

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 5 "C:\Users\DELL\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\Pages\CategoriesComponent.razor"
                                        ViewCategoryUseCase

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 4 "C:\Users\DELL\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\Pages\CategoriesComponent.razor"
        NavigationManager

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 4 "C:\Users\DELL\Downloads\Supermarket_Management_System\SupermarketManagement\WebApp\Pages\CategoriesComponent.razor"
                          NavigationManager

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
    }
}
#pragma warning restore 1591
