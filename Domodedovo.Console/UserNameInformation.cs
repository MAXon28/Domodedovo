using Newtonsoft.Json;

namespace Domodedovo.ConsoleApp
{
    /// <summary>
    /// 
    /// </summary>
    public class UserNameInformation
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("first")]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("last")]
        public string Surname { get; set; }
    }
}