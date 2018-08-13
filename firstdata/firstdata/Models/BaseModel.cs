using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace firstdata.Models
{
    abstract public class BaseModel
    {
        public String ToJson(){
            String json = JsonConvert.SerializeObject(
                this,
                new JsonSerializerSettings
                {
                    ContractResolver = new CamelCasePropertyNamesContractResolver(),
                    NullValueHandling = NullValueHandling.Ignore
                }
            );
            return json;
        }
    }
}
