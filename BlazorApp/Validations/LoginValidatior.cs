using BlazorApp.Data;

using FluentValidation;
using FluentValidation.Results;

namespace BlazorApp.Validations
{
  public class LoginValidatior : AbstractValidator<User>
  {
    public new ValidationResult Validate(User user) => new LoginValidatior().Validate(user);

    public LoginValidatior()
    {
      RuleFor(user => user.Email).NotEmpty().WithMessage("Email Sholuld not be empty.");
      RuleFor(user => user.Email)
        .Matches(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z")
        .WithMessage("Email Id is not valid.");
      RuleFor(user => user.Password).NotEmpty().WithMessage("Password should not be empty.");
    }
  }
}
