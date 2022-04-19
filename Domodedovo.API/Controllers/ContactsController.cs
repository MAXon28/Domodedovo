using Domodedovo.BusinessLogicLayer;
using Domodedovo.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Domodedovo.API.Controllers
{
    /// <summary>
    /// Контроллер контактов
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class ContactsController : ControllerBase
    {
        /// <summary>
        /// Сервис пользователя
        /// </summary>
        private readonly IUserService _userService;

        public ContactsController(IUserService userService) => _userService = userService;

        /// <summary>
        /// Получить контакты
        /// </summary>
        /// <param name="pageNumber"> Номер страницы </param>
        /// <returns> Контакты </returns>
        [HttpGet]
        public async Task<IEnumerable<Contact>> Get(int pageNumber = 1) => await _userService.GetContactsAsync(pageNumber);

        /// <summary>
        /// Получить контакты
        /// </summary>
        /// <param name="pageNumber"> Номер страницы </param>
        /// <param name="typeOfSort"> Тип сортировки </param>
        /// <returns> Контакты </returns>
        [HttpGet("Sort")]
        public async Task<IEnumerable<Contact>> Get(int pageNumber, int typeOfSort) => await _userService.GetContactsAsync(pageNumber, (SortType)typeOfSort);

        /// <summary>
        /// Получить количество страниц
        /// </summary>
        /// <returns> Количество страниц </returns>
        [HttpGet("GetPagesCount")]
        public async Task<int> GetPagesCount() => await _userService.GetPagesCountAsync();
    }
}