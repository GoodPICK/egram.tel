using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public class StickerEmojis : Structure
    {

        [JsonProperty("@type")]
        public override string DataType { get; set; } = "stickerEmojis";

        [JsonProperty("@extra")]
        public override string Extra { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("emojis")]
        public string[] Emojis { get; set; }

    }

}