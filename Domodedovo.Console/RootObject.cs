using Newtonsoft.Json;

namespace Domodedovo.ConsoleApp
{
    /// <summary>
    /// 
    /// </summary>
    public class RootObject
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("results")]
        public List<User> Users { get; set; }
    }
}