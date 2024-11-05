using LiveWeather.Models;
using MongoDB.Bson;
using MudBlazor;
using Supabase.Gotrue;

namespace LiveWeather.Services
{
    public class SupabaseAuthService : IAuthService
    {
        private readonly Supabase.Client _client;
        private readonly ISnackbar _snackbar;
        private Supabase.Gotrue.User? user;

        public event Action<Constants.AuthState>? OnAuthStateChanged;

        public SupabaseAuthService(Supabase.Client client, ISnackbar snackbar)
        {
            _client = client;
            _snackbar = snackbar;
        }

        public async Task SignUp(string email, string password)
        {
            try
            {
                var res = await _client.Auth.SignUp(email, password);
                user = res?.User;
                _snackbar.Add("Signup Successfull", Severity.Success);
            }
            catch (Supabase.Gotrue.Exceptions.GotrueException e)
            {
                _snackbar.Add("Error: " + e.Reason, Severity.Error);
            }
            OnAuthStateChanged?.Invoke(Constants.AuthState.SignedIn);
        }

        public async Task SignIn(string email, string password)
        {
            try
            {
                var res = await _client.Auth.SignIn(email, password);
                user = res?.User;
                _snackbar.Add("SignIn Successfull", Severity.Success);
            }
            catch (Supabase.Gotrue.Exceptions.GotrueException e)
            {
                _snackbar.Add("Error: " + e.Reason, Severity.Error);
            }
            OnAuthStateChanged?.Invoke(Constants.AuthState.SignedIn);
        }

        public async Task SignOut()
        {
            user = null;
            await _client.Auth.SignOut();
            OnAuthStateChanged?.Invoke(Constants.AuthState.SignedOut);
        }

        public bool IsAuthenticated()
        {
            return _client.Auth.CurrentUser != null;
        }

        public Supabase.Gotrue.User? GetUser()
        {
            return _client.Auth.CurrentUser;
        }

    }
}
