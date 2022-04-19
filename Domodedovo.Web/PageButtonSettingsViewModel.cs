namespace Domodedovo.Web
{
    /// <summary>
    /// Настройки кнопок страниц
    /// </summary>
    public class PageButtonSettingsViewModel
    {
        /// <summary>
        /// Текущий номер страницы на кнопке
        /// </summary>
        public int CurrentNumber { get; set; }

        /// <summary>
        /// Имя css-класса, который показывает активна кнопка или нет
        /// </summary>
        public string StatusClassName { get; set; }
    }
}