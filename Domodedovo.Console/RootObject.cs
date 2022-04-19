using Newtonsoft.Json;

namespace Domodedovo.ConsoleApp
{
    /// <summary>
    /// Класс для десериализации json
    /// </summary>
    public class RootObject
    {
        /// <summary>
        /// Пользователи
        /// </summary>
        [JsonProperty("results")]
        public List<User> Users { get; set; }
    }
}