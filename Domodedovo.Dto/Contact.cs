namespace Domodedovo.Dto
{
    /// <summary>
    /// Контакт
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Полное имя пользователя
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Телефон
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Url фото пользователя
        /// </summary>
        public string PhotoUrl { get; set; }
    }
}