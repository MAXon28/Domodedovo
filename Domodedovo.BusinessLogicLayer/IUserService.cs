using Domodedovo.Dto;

namespace Domodedovo.BusinessLogicLayer
{
    /// <summary>
    /// 
    /// </summary>
    public interface IUserService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="users">  </param>
        /// <returns></returns>
        public void AddUser(IEnumerable<UserDto> users);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pageNumber">  </param>
        /// <returns>  </returns>
        public Task<List<Contact>> GetContactsAsync(int pageNumber = 1);
    }
}