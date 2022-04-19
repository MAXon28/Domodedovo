using Domodedovo.BusinessLogicLayer;
using Domodedovo.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Domodedovo.API.Controllers
{
    /// <summary>
    /// ���������� ���������
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class ContactsController : ControllerBase
    {
        /// <summary>
        /// ������ ������������
        /// </summary>
        private readonly IUserService _userService;

        public ContactsController(IUserService userService) => _userService = userService;

        /// <summary>
        /// �������� ��������
        /// </summary>
        /// <param name="pageNumber"> ����� �������� </param>
        /// <returns> �������� </returns>
        [HttpGet]
        public async Task<IEnumerable<Contact>> Get(int pageNumber = 1) => await _userService.GetContactsAsync(pageNumber);

        /// <summary>
        /// �������� ��������
        /// </summary>
        /// <param name="pageNumber"> ����� �������� </param>
        /// <param name="typeOfSort"> ��� ���������� </param>
        /// <returns> �������� </returns>
        [HttpGet("Sort")]
        public async Task<IEnumerable<Contact>> Get(int pageNumber, int typeOfSort) => await _userService.GetContactsAsync(pageNumber, (SortType)typeOfSort);

        /// <summary>
        /// �������� ���������� �������
        /// </summary>
        /// <returns> ���������� ������� </returns>
        [HttpGet("GetPagesCount")]
        public async Task<int> GetPagesCount() => await _userService.GetPagesCountAsync();
    }
}