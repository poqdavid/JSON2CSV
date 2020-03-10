namespace JSON2CSV
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public partial class Settings
    {
        [JsonProperty("jsonpath")]
        public string JsonPath { get; set; }

        [JsonProperty("separator")]
        public string Separator { get; set; }

        [JsonProperty("folders")]
        public List<string> Folders { get; set; }
        
        
        public Settings()
        {
            this.JsonPath = "";
            this.Separator = "/";
            this.Folders = new List<string>();
        }

    }
}