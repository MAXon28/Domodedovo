using AutoMapper;
using Domodedovo.DataAccessLayer;
using Domodedovo.Dto;
using Microsoft.EntityFrameworkCore;

namespace Domodedovo.BusinessLogicLayer
{
    /// <inheritdoc cref="IUserService"/>
    public class UserService : IUserService
    {
        public void AddUser(IEnumerable<UserDto> users)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<UserDto, User>()).CreateMapper();
            var newUsers = mapper.Map<IEnumerable<UserDto>, IEnumerable<User>>(users);

            using var context = new ApplicationContext();
            context.Users.AddRange(newUsers);
            context.SaveChanges();
        }

        public async Task<List<Contact>> GetContactsAsync(int pageNumber = 1)
        {
            using var context = new ApplicationContext();

            var users = await context.Users.Take(28).ToListAsync();

            var contacts = new List<Contact>();

            foreach (var user in users)
                contacts.Add(new Contact
                {
                    FullName = user.UserName + " " + user.UserSurname,
                    Email = user.Email,
                    Phone = user.Phone,
                    PhotoUrl = user.PhotoUrl
                });

            return contacts;
        }
    }
}