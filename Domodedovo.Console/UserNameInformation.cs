using Newtonsoft.Json;

namespace Domodedovo.ConsoleApp
{
    /// <summary>
    /// Информация об имени пользователи
    /// </summary>
    public class UserNameInformation
    {
        /// <summary>
        /// Пол
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Имя
        /// </summary>
        [JsonProperty("first")]
        public string Name { get; set; }

        /// <summary>
        /// Фамилия
        /// </summary>
        [JsonProperty("last")]
        public string Surname { get; set; }
    }
}