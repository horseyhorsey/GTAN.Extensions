using Newtonsoft.Json;
using System.Collections.Generic;

namespace GTAN.Data
{
    public partial class WeaponData
    {
        public static Dictionary<string, WeaponData> FromJson(string json) => JsonConvert.DeserializeObject<Dictionary<string, WeaponData>>(json);
    }

    public partial class WeaponData
    {
        [JsonProperty("HashKey")]
        public string HashKey { get; set; }

        [JsonProperty("NameGXT")]
        public string NameGxt { get; set; }

        [JsonProperty("DescriptionGXT")]
        public string DescriptionGxt { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Description")]
        public string Description { get; set; }

        [JsonProperty("Group")]
        public string Group { get; set; }

        [JsonProperty("ModelHashKey")]
        public string ModelHashKey { get; set; }

        [JsonProperty("DefaultClipSize")]
        public int DefaultClipSize { get; set; }

        [JsonProperty("Components")]
        public Dictionary<string, Component> Components { get; set; }

        [JsonProperty("Tints")]
        public Tint[] Tints { get; set; }

        [JsonProperty("DLC")]
        public string Dlc { get; set; }
    }

    public partial class Component
    {
        [JsonProperty("HashKey")]
        public string HashKey { get; set; }

        [JsonProperty("NameGXT")]
        public string NameGxt { get; set; }

        [JsonProperty("DescriptionGXT")]
        public string DescriptionGxt { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Description")]
        public string Description { get; set; }

        [JsonProperty("ModelHashKey")]
        public string ModelHashKey { get; set; }

        [JsonProperty("IsDefault")]
        public bool IsDefault { get; set; }
    }

    public partial class Tint
    {
        [JsonProperty("NameGXT")]
        public string NameGxt { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }
    }
}
