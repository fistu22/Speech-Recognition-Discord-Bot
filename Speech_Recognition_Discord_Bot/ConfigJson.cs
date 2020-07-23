﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Speech_Recognition_Discord_Bot
{
    public struct ConfigJson
    {
        [JsonProperty("token")]
        public string Token { get; private set; }
        [JsonProperty("prefix")]
        public string Prefix { get; private set; }
    }
}
