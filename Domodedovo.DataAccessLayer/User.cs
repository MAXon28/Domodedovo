using System.ComponentModel.DataAnnotations;

namespace Domodedovo.DataAccessLayer
{
    /// <summary>
    /// Пользователь
    /// </summary>
    public class User
    {
        /// <summary>
        /// Идентификатор пользователя
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Имя пользователя
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Фамилия пользователя
        /// </summary>
        public string UserSurname { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Номер телефона
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Ссылка на фото пользователя
        /// </summary>
        public string PhotoUrl { get; set; }
    }
}