using Newtonsoft.Json;

namespace Domodedovo.ConsoleApp
{
    /// <summary>
    /// 
    /// </summary>
    public class User
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("name")]
        public UserNameInformation NameInformation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("picture")]
        public UserPhotoInformation PhotoInformation { get; set; }
    }
}