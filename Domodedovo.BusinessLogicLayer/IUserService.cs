using Domodedovo.Dto;

namespace Domodedovo.BusinessLogicLayer
{
    /// <summary>
    /// Сервис пользователя
    /// </summary>
    public interface IUserService
    {
        /// <summary>
        /// Добавить пользователей
        /// </summary>
        /// <param name="users"> Пользователи </param>
        public void AddUsers(IEnumerable<UserDto> users);

        /// <summary>
        /// Получить контакты
        /// </summary>
        /// <param name="dialNumber"> Номер набора (для пагинации по 28 элементов на страницу) </param>
        /// <param name="sortType"> Тип сортировки </param>
        /// <returns> Список контактов </returns>
        public Task<List<Contact>> GetContactsAsync(int dialNumber, SortType sortType = SortType.InOrder);

        /// <summary>
        /// Получить количество страниц в контактах
        /// </summary>
        /// <returns> Количество страниц в контактах </returns>
        public Task<int> GetPagesCountAsync();
    }
}