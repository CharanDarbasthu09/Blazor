using BlazorApp.Pages;
using BlazorApp.Utilities;
using Bunit;

using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.DependencyInjection;

using Moq;
using BlazorApp.Data;

namespace BlazorTests
{
  public class SignupTests
  {
    private readonly Mock<ILocalStorage> _localStorage = new();

    private readonly TestContext _testContext;
    public SignupTests()
    {
      _localStorage = new Mock<ILocalStorage>();
      _testContext = new TestContext();

      _testContext.Services.AddSingleton(_localStorage.Object);
    }

    [Fact]
    public void SignUp_MarkUp_Test()
    {
      var expectedMarkUp = "<h1>User Sign Up</h1>\r\n    <div class=\"modal-content\">\r\n      <div class=\"modal-header\">\r\n        <h5 class=\"modal-title\">Sign Up Form</h5>\r\n      </div>\r\n      <div class=\"modal-body\">\r\n        <div class=\"mb-3\">\r\n          <label for=\"loginEmail\" class=\"form-label\">User Name</label>\r\n          <input class=\"form-control\" id=\"userName\" placeholder=\"john\" autocomplete=\"off\" required=\"\" >\r\n        </div>\r\n        <div class=\"mb-3\">\r\n          <label for=\"loginEmail\" class=\"form-label\">Email</label>\r\n          <input type=\"email\" class=\"form-control\" id=\"loginEmail\" placeholder=\"name@example.com\" autocomplete=\"off\" required=\"\" >\r\n        </div>\r\n        <div class=\"mb-3\">\r\n          <label for=\"loginPassword\" class=\"form-label\">Password</label>\r\n          <input type=\"password\" class=\"form-control\" id=\"loginPassword\" required=\"\" >\r\n        </div>\r\n        <div class=\"mb-3\">\r\n          <label for=\"confirmPassword\" class=\"form-label\">Confirm Password</label>\r\n          <input type=\"password\" class=\"form-control\" id=\"confirmPassword\" required=\"\">\r\n        </div>\r\n      </div>\r\n      <div class=\"modal-footer\">\r\n        <button id=\"loginBtn\" type=\"button\" class=\"btn btn-success\" >Sign Up</button>\r\n      </div>\r\n      <div class=\"toast-container p-3 d-none\" data-bs-autohide=\"true\" data-bs-delay=\"5000\">\r\n        <div class=\"toast show\" role=\"alert\" aria-live=\"assertive\" aria-atomic=\"true\">\r\n          <div class=\"toast-header\">\r\n            <strong class=\"me-auto\"></strong>\r\n            <button type=\"button\" class=\"btn-close\" aria-label=\"Close\" ></button>\r\n          </div>\r\n          <div class=\"toast-body\"></div>\r\n        </div>\r\n      </div>\r\n    </div>";

      // Render Counter component.
      var component = _testContext.RenderComponent<Signup>();

      component.MarkupMatches(expectedMarkUp);
    }

    [Fact]
    public void SignUp_ButtonClick_Test()
    {
      var signUpComponent = _testContext.RenderComponent<Login>();
      var signUpBtn = signUpComponent.Find("button");
      var navMgr = _testContext.Services.GetRequiredService<NavigationManager>();

      signUpBtn.Click();
      signUpBtn.Click(detail: 3, ctrlKey: true);
      signUpBtn.Click(new MouseEventArgs());

      Assert.NotNull(signUpBtn);
      Assert.Equal("http://localhost/", navMgr.Uri);
    }
  }
}
