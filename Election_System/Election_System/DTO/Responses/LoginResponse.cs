using Election_System.Enumerations;

namespace Election_System.DTO.Responses
{
    public class LoginResponse
    {
        public int? UserId { get; set; }
        public bool IsLoggedIn { get; set; }
        public string Message { get; set; }
        public Role? Role { get; set; }

        public LoginResponse(int userId, Role? role)
        {
            if (userId == 0)
            {
                UserId = null;
                IsLoggedIn = false;
                Message = "username or password not matching!";
                Role = null;
            }
            else
            {
                UserId = userId;
                IsLoggedIn = true;
                Message = "succesfull login";
                Role = role;
            }

        }

    }

}
