﻿using Newtonsoft.Json.Linq;

namespace RabbitMQAzureMetrics.Extensions
{
    public static class JTokenExtension
    {
        public static T ValueFromPath<T>(this JToken jToken, string path)
        {
            var res = jToken.SelectToken(path);
            if (res == null || res.Type == JTokenType.Null) return default;
            return res.Value<T>();
        }
    }
}
