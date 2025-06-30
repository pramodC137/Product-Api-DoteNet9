namespace DotNet9_FirstApi.Models.API
{
    public class LoginResponseModel
    {
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public int ExpiresIn { get; set; } 
        public string AccessToken { get; set; }
    }
}
