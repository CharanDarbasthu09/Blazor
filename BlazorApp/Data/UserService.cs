using BlazorApp.Utilities;

namespace BlazorApp.Data
{
  public class UserService
  {
    private readonly ILocalStorage _localStorage;
    public UserService(ILocalStorage localStorage) => _localStorage = localStorage;

    //public async Task<string[]> GetUsersAsync() => await _localStorage.GetStringArrayAsync()
  }
}
