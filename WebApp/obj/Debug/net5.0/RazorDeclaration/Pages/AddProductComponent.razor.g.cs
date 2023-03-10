// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WebApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\mycManagement\SupermarketManagement\WebApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\mycManagement\SupermarketManagement\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\mycManagement\SupermarketManagement\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\mycManagement\SupermarketManagement\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\mycManagement\SupermarketManagement\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\mycManagement\SupermarketManagement\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\mycManagement\SupermarketManagement\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\mycManagement\SupermarketManagement\WebApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\mycManagement\SupermarketManagement\WebApp\_Imports.razor"
using WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\mycManagement\SupermarketManagement\WebApp\_Imports.razor"
using WebApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\mycManagement\SupermarketManagement\WebApp\_Imports.razor"
using WebApp.Controls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\mycManagement\SupermarketManagement\WebApp\_Imports.razor"
using CoreBusiness;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "E:\mycManagement\SupermarketManagement\WebApp\_Imports.razor"
using UseCases;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/addproduct")]
    public partial class AddProductComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "E:\mycManagement\SupermarketManagement\WebApp\Pages\AddProductComponent.razor"
       

    private Product product;
    private IEnumerable<Category> categories;

    protected override void OnInitialized()
    {
        base.OnInitialized();

        product = new Product();
        categories = ViewCategoriesUseCase.Execute();
    }

    private void OnValidSumit()
    {
        AddProductUseCase.Execute(product);
        NavigationManager.NavigateTo("/products");
    }

    private void OnCancel()
    {
        NavigationManager.NavigateTo("/products");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IViewCategoriesUseCase ViewCategoriesUseCase { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAddProductUseCase AddProductUseCase { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
