using Domodedovo.BusinessLogicLayer;
using Domodedovo.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Domodedovo.API.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class ContactsController : ControllerBase
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly IUserService _userService;

        public ContactsController(IUserService userService) => _userService = userService;

        [HttpGet]
        public async Task<IEnumerable<Contact>> Get() => await _userService.GetContactsAsync();
    }
}