using BlazorApp.Data;

using FluentValidation;

namespace BlazorApp.Validations
{
  public class LoginValidator : AbstractValidator<User>
  {
    public LoginValidator()
    {
      RuleFor(p => p.Email).NotEmpty()
        .WithMessage("You must enter a valid email.")
         .Matches(Constants.EmailRegex);
      RuleFor(p => p.Password).NotEmpty().WithMessage("You must enter a valid password.");
    }
  }
}
