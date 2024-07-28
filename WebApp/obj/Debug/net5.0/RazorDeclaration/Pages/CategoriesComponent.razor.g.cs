// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
