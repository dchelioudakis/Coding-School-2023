using FuelStation.Blazor.Shared.DTO.Login;
using FuelStation.EF.Repositories;
using FuelStation.Model;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace FuelStation.Blazor.Server.Authentication {
    public class JwtAuthenticationManager {
        public const string JWT_SECURITY_KEY = "yPkCqn4kSWLtaJwXvN2jGzpQRyTZ3gdXkt7FeBJP";
        private const int JWT_TOKEN_VALIDITY_MINS = 20;

        private UserAccountService _userAccountService;
        private EmployeeRepo _employeeRepo;

        public JwtAuthenticationManager(UserAccountService userAccountService) {
            _userAccountService = userAccountService;
            _employeeRepo = new EmployeeRepo();
        }

        public UserSession? GenerateJwtToken(string userName, string password) {
            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(password))
                return null;

            /* Validating the User Credentials */
            //var userAccount = _userAccountService.GetUserAccountByUserName(userName);
            var tempEmployeesList =  _employeeRepo.GetAll();
            List<Employee> employeesList = new List<Employee>(tempEmployeesList);
            var askedEmployee = employeesList.Find(employee => employee.Username == userName);
            
                if (askedEmployee == null || askedEmployee.Password != password)
                return null;

            /* Generating JWT Token */
            var tokenExpiryTimeStamp = DateTime.Now.AddMinutes(JWT_TOKEN_VALIDITY_MINS);
            var tokenKey = Encoding.ASCII.GetBytes(JWT_SECURITY_KEY);
            var claimsIdentity = new ClaimsIdentity(new List<Claim>
                {
                    new Claim(ClaimTypes.Name, askedEmployee.Username),
                    new Claim(ClaimTypes.Role, askedEmployee.Type.ToString())
                });
            var signingCredentials = new SigningCredentials(
                new SymmetricSecurityKey(tokenKey),
                SecurityAlgorithms.HmacSha256Signature);
            var securityTokenDescriptor = new SecurityTokenDescriptor {
                Subject = claimsIdentity,
                Expires = tokenExpiryTimeStamp,
                SigningCredentials = signingCredentials
            };

            var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
            var securityToken = jwtSecurityTokenHandler.CreateToken(securityTokenDescriptor);
            var token = jwtSecurityTokenHandler.WriteToken(securityToken);

            /* Returning the User Session object */
            var userSession = new UserSession {
                UserName = askedEmployee.Username,
                Name = askedEmployee.Name,
                Surname = askedEmployee.Surname,
                EmployeeId = askedEmployee.Id,
                Role = askedEmployee.Type.ToString(),
                Token = token,
                ExpiresIn = (int)tokenExpiryTimeStamp.Subtract(DateTime.Now).TotalSeconds
            };
            return userSession;
        }
    }
}
