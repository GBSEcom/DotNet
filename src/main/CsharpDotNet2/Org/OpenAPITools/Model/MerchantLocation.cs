using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// The specific location (e.g. store or station) where the transaction takes place.
  /// </summary>
  [DataContract]
  public class MerchantLocation {
    /// <summary>
    /// The unique ID of this location.
    /// </summary>
    /// <value>The unique ID of this location.</value>
    [DataMember(Name="locationId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "locationId")]
    public string LocationId { get; set; }

    /// <summary>
    /// Gets or Sets MerchantAddress
    /// </summary>
    [DataMember(Name="merchantAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "merchantAddress")]
    public MerchantLocationMerchantAddress MerchantAddress { get; set; }

    /// <summary>
    /// Free-text field to describe a hierarchy the merchant would like to provide.
    /// </summary>
    /// <value>Free-text field to describe a hierarchy the merchant would like to provide.</value>
    [DataMember(Name="hierarchy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hierarchy")]
    public string Hierarchy { get; set; }

    /// <summary>
    /// The timezone offset from UTC to the merchants timezone configuration, specified in the format +hh:mm.
    /// </summary>
    /// <value>The timezone offset from UTC to the merchants timezone configuration, specified in the format +hh:mm.</value>
    [DataMember(Name="timezoneOffset", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "timezoneOffset")]
    public string TimezoneOffset { get; set; }

    /// <summary>
    /// A JSON object that can carry any additional information about the location that might be helpful for fraud detection.
    /// </summary>
    /// <value>A JSON object that can carry any additional information about the location that might be helpful for fraud detection.</value>
    [DataMember(Name="userDefined", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userDefined")]
    public Object UserDefined { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MerchantLocation {\n");
      sb.Append("  LocationId: ").Append(LocationId).Append("\n");
      sb.Append("  MerchantAddress: ").Append(MerchantAddress).Append("\n");
      sb.Append("  Hierarchy: ").Append(Hierarchy).Append("\n");
      sb.Append("  TimezoneOffset: ").Append(TimezoneOffset).Append("\n");
      sb.Append("  UserDefined: ").Append(UserDefined).Append("\n");
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
