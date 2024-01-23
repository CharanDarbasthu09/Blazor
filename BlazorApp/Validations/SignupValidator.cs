using BlazorApp.Data;

using FluentValidation;

namespace BlazorApp.Validations
{
  public class SignupValidator : AbstractValidator<User>
  {
    public SignupValidator()
    {
      RuleFor(p => p.Email).NotEmpty()
      .WithMessage("You must enter a valid email.")
      .Matches(Constants.EmailRegex);
      RuleFor(p => p.UserName).NotEmpty().WithMessage("You must enter a valid user name");
      RuleFor(p => p.Password).NotEmpty().WithMessage("You must enter a valid password.");
    }
  }
}
