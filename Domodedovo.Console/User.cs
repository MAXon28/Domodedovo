using Newtonsoft.Json;

namespace Domodedovo.ConsoleApp
{
    /// <summary>
    /// Пользователь (класс для десериализации json)
    /// </summary>
    public class User
    {
        /// <summary>
        /// Информация об имени
        /// </summary>
        [JsonProperty("name")]
        public UserNameInformation NameInformation { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Телефон
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// Информация о фото
        /// </summary>
        [JsonProperty("picture")]
        public UserPhotoInformation PhotoInformation { get; set; }
    }
}