using Newtonsoft.Json;

namespace Domodedovo.ConsoleApp
{
    /// <summary>
    /// Информация о фото пользователя
    /// </summary>
    public class UserPhotoInformation
    {
        /// <summary>
        /// Большой размер фото
        /// </summary>
        [JsonProperty("large")]
        public string LargePhotoUrl { get; set; }

        /// <summary>
        /// Средний размер фото
        /// </summary>
        [JsonProperty("medium")]
        public string MediumPhotoUrl { get; set; }

        /// <summary>
        /// Маленький размер фото
        /// </summary>
        [JsonProperty("thumbnail")]
        public string ThumbnailPhotoUrl { get; set; }
    }
}