#pragma checksum "C:\Users\charan.darbasthu\source\BlazorApp\BlazorApp\Pages\Signup.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "621f7a545fbf41245da3ab93601cfb5b2d29066fff748dd20a790e4bd3452970"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Pages
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\charan.darbasthu\source\BlazorApp\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\charan.darbasthu\source\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\charan.darbasthu\source\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\charan.darbasthu\source\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\charan.darbasthu\source\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\charan.darbasthu\source\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\charan.darbasthu\source\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\charan.darbasthu\source\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\charan.darbasthu\source\BlazorApp\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\charan.darbasthu\source\BlazorApp\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\charan.darbasthu\source\BlazorApp\BlazorApp\Pages\Signup.razor"
using BlazorApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\charan.darbasthu\source\BlazorApp\BlazorApp\Pages\Signup.razor"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/signup")]
    public partial class Signup : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Web.PageTitle>(0);
            __builder.AddAttribute(1, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(2, "Sign Up");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.AddMarkupContent(4, "<h1>User Sign Up</h1>\r\n");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "modal-content");
            __builder.AddMarkupContent(7, "<div class=\"modal-header\"><h5 class=\"modal-title\">Sign Up Form</h5></div>\r\n  ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "modal-body");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "mb-3");
            __builder.AddMarkupContent(12, "<label for=\"loginEmail\" class=\"form-label\">User Name</label>\r\n      ");
            __builder.OpenElement(13, "input");
            __builder.AddAttribute(14, "class", "form-control");
            __builder.AddAttribute(15, "id", "userName");
            __builder.AddAttribute(16, "placeholder", "john");
            __builder.AddAttribute(17, "autocomplete", "off");
            __builder.AddAttribute(18, "required");
            __builder.AddAttribute(19, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "C:\Users\charan.darbasthu\source\BlazorApp\BlazorApp\Pages\Signup.razor"
                                                                                                            user.UserName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.UserName = __value, user.UserName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n    ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "mb-3");
            __builder.AddMarkupContent(24, "<label for=\"loginEmail\" class=\"form-label\">Email</label>\r\n      ");
            __builder.OpenElement(25, "input");
            __builder.AddAttribute(26, "type", "email");
            __builder.AddAttribute(27, "class", "form-control");
            __builder.AddAttribute(28, "id", "loginEmail");
            __builder.AddAttribute(29, "placeholder", "name@example.com");
            __builder.AddAttribute(30, "autocomplete", "off");
            __builder.AddAttribute(31, "required");
            __builder.AddAttribute(32, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "C:\Users\charan.darbasthu\source\BlazorApp\BlazorApp\Pages\Signup.razor"
                                                                                                                                       user.Email

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.Email = __value, user.Email));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n    ");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "mb-3");
            __builder.AddMarkupContent(37, "<label for=\"loginPassword\" class=\"form-label\">Password</label>\r\n      ");
            __builder.OpenElement(38, "input");
            __builder.AddAttribute(39, "type", "password");
            __builder.AddAttribute(40, "class", "form-control");
            __builder.AddAttribute(41, "id", "loginPassword");
            __builder.AddAttribute(42, "required");
            __builder.AddAttribute(43, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 25 "C:\Users\charan.darbasthu\source\BlazorApp\BlazorApp\Pages\Signup.razor"
                                                                                           user.Password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(44, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.Password = __value, user.Password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n    ");
            __builder.AddMarkupContent(46, "<div class=\"mb-3\"><label for=\"confirmPassword\" class=\"form-label\">Confirm Password</label>\r\n      <input type=\"password\" class=\"form-control\" id=\"confirmPassword\" required></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n\r\n  ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "modal-footer");
            __builder.OpenElement(50, "button");
            __builder.AddAttribute(51, "id", "loginBtn");
            __builder.AddAttribute(52, "type", "button");
            __builder.AddAttribute(53, "class", "btn btn-success");
            __builder.AddAttribute(54, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "C:\Users\charan.darbasthu\source\BlazorApp\BlazorApp\Pages\Signup.razor"
                                                                          SignUpAsync

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(55, "Sign Up");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n  ");
            __builder.OpenComponent<global::BlazorApp.Shared.Popup>(57);
            __builder.AddComponentReferenceCapture(58, (__value) => {
#nullable restore
#line 36 "C:\Users\charan.darbasthu\source\BlazorApp\BlazorApp\Pages\Signup.razor"
               popupRef = (BlazorApp.Shared.Popup)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\charan.darbasthu\source\BlazorApp\BlazorApp\Pages\Signup.razor"
       
  private User user = new User();
  private Popup popupRef;

  public async Task SignUpAsync()
  {
    //var loginValidator = new LoginValidatior().Validate(user);
    // if (!loginValidator.IsValid)
    // {
    //   popupRef.Show(string.Join(",", loginValidator.Errors));
    //   return;
    // }

    if (!IsValid())
    {
      popupRef.Show("Please enter valid credentials.", "Error");
      return;
    }

    Nav.NavigateTo("/counter");
    await LocalStorage.SaveStringAsync("user", user.Email);
  }

  private bool IsValid() => !string.IsNullOrEmpty(user.UserName) &&
  !string.IsNullOrEmpty(user.Email) &&
  !string.IsNullOrEmpty(user.Password) &&
  Regex.IsMatch(user.Email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Utilities.ILocalStorage LocalStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Nav { get; set; }
    }
}
#pragma warning restore 1591