using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// The processor address validation response for compliance.
  /// </summary>
  [DataContract]
  public class AVSResponse {
    /// <summary>
    /// Response if street matches that on file.
    /// </summary>
    /// <value>Response if street matches that on file.</value>
    [DataMember(Name="streetMatch", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "streetMatch")]
    public string StreetMatch { get; set; }

    /// <summary>
    /// Response if postal code matches that on file.
    /// </summary>
    /// <value>Response if postal code matches that on file.</value>
    [DataMember(Name="postalCodeMatch", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "postalCodeMatch")]
    public string PostalCodeMatch { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AVSResponse {\n");
      sb.Append("  StreetMatch: ").Append(StreetMatch).Append("\n");
      sb.Append("  PostalCodeMatch: ").Append(PostalCodeMatch).Append("\n");
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
