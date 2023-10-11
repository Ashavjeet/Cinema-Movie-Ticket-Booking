using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesAppProjectFSD.Models
{
    public static class SessionHelper
    {
        public static void SetObjectAsJson (this ISession seesion, string key, object value)
        {
            seesion.SetString(key, JsonConvert.SerializeObject(value));
        }
        public static T GetObjectFromJson<T>(this ISession seesion, string key)
        {
            var value = seesion.GetString(key);
            return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
        }
    }
}
