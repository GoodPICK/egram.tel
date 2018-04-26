using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public class TestVectorStringObject : Structure
    {

        [JsonProperty("@type")]
        public override string DataType { get; set; } = "testVectorStringObject";

        [JsonProperty("@extra")]
        public override string Extra { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("value")]
        public TestString[] Value { get; set; }

    }

}