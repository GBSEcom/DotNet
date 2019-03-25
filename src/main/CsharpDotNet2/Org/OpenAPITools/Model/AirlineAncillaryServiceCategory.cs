using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class AirlineAncillaryServiceCategory {
    /// <summary>
    /// Identifies the service purchased in the transaction if not a base ticket
    /// </summary>
    /// <value>Identifies the service purchased in the transaction if not a base ticket</value>
    [DataMember(Name="serviceCategory", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "serviceCategory")]
    public string ServiceCategory { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AirlineAncillaryServiceCategory {\n");
      sb.Append("  ServiceCategory: ").Append(ServiceCategory).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
