using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Models;

namespace Operation
{
    public class JSONOperation
    {
        public string Serialize(Pool poolObj)
        {
            return JsonConvert.SerializeObject(poolObj, Formatting.Indented);
        }
        public Pool Deserialize(string text)
        {
            return JsonConvert.DeserializeObject<Pool>(text);
        }
    }
}
