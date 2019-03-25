using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Model for Industry Specific information
  /// </summary>
  [DataContract]
  public class IndustrySpecificExtensions {
    /// <summary>
    /// Gets or Sets Airline
    /// </summary>
    [DataMember(Name="airline", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "airline")]
    public Airline Airline { get; set; }

    /// <summary>
    /// Gets or Sets Lodging
    /// </summary>
    [DataMember(Name="lodging", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lodging")]
    public Lodging Lodging { get; set; }

    /// <summary>
    /// Gets or Sets CarRental
    /// </summary>
    [DataMember(Name="carRental", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "carRental")]
    public CarRental CarRental { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IndustrySpecificExtensions {\n");
      sb.Append("  Airline: ").Append(Airline).Append("\n");
      sb.Append("  Lodging: ").Append(Lodging).Append("\n");
      sb.Append("  CarRental: ").Append(CarRental).Append("\n");
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
