using AutoMapper;
using Domodedovo.DataAccessLayer;
using Domodedovo.Dto;
using Microsoft.EntityFrameworkCore;

namespace Domodedovo.BusinessLogicLayer
{
    /// <inheritdoc cref="IUserService"/>
    public class UserService : IUserService
    {
        public void AddUsers(IEnumerable<UserDto> users)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<UserDto, User>()).CreateMapper();
            var newUsers = mapper.Map<IEnumerable<UserDto>, IEnumerable<User>>(users);

            using var context = new ApplicationContext();
            context.Users.AddRange(newUsers);
            context.SaveChanges();
        }

        public async Task<List<Contact>> GetContactsAsync(int pageNumber, SortType sortType = SortType.InOrder)
        {
            using var context = new ApplicationContext();

            var users = sortType switch
            {
                SortType.InOrder => await context.Users.Skip(28 * (pageNumber - 1)).Take(28).ToListAsync(),
                SortType.BySurname => await context.Users.OrderBy(user => user.UserSurname).Skip(28 * (pageNumber - 1)).Take(28).ToListAsync(),
                SortType.ByName => await context.Users.OrderBy(user => user.UserName).Skip(28 * (pageNumber - 1)).Take(28).ToListAsync(),
                _ => throw new NotImplementedException(),
            };

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

        public async Task<int> GetPagesCountAsync()
        {
            using var context = new ApplicationContext();

            var usersCount = await context.Users.CountAsync();

            var pagesCount = usersCount / 28;
            return usersCount % 28 > 0 ? pagesCount + 1 : pagesCount;
        }
    }
}