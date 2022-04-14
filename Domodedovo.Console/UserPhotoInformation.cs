using Newtonsoft.Json;

namespace Domodedovo.ConsoleApp
{
    /// <summary>
    /// 
    /// </summary>
    public class UserPhotoInformation
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("large")]
        public string LargePhotoUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("medium")]
        public string MediumPhotoUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("thumbnail")]
        public string ThumbnailPhotoUrl { get; set; }
    }
}