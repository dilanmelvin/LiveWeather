using Supabase.Gotrue;

namespace LiveWeather.Services
{
    public interface IAuthService
    {
        Task SignUp(string email, string password);
        Task SignIn(string email, string password);
        Task SignOut();
        bool IsAuthenticated();
        User? GetUser();
        event Action<Constants.AuthState>? OnAuthStateChanged;
    }
}

