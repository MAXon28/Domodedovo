using Domodedovo.BusinessLogicLayer;
using Newtonsoft.Json;

namespace Domodedovo.ConsoleApp
{
    public class Program
    {
        /// <summary>
        /// Сервис пользователя
        /// </summary>
        private static IUserService _userService = new UserService();

        public static void Main()
        {
            Console.WriteLine("Начало загрузки рандомных пользователей.");
            var client = new HttpClient();
            HttpResponseMessage response = client.GetAsync("https://randomuser.me/api/?results=1000&inc=name,city,email,phone,picture").Result;
            response.EnsureSuccessStatusCode();
            var responseBody = response.Content.ReadAsStringAsync().Result;
            var obj = JsonConvert.DeserializeObject<RootObject>(responseBody);
            var users = obj.Users;

            var usersDto = users.Select(user => new UserDto
            {
                UserName = user.NameInformation.Name,
                UserSurname = user.NameInformation.Surname,
                Email = user.Email,
                Phone = user.Phone,
                PhotoUrl = user.PhotoInformation.LargePhotoUrl
            });

            _userService.AddUsers(usersDto);

            Console.WriteLine("Рандомные пользователи загружены в базу данных.");
        }
    }
}