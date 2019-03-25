using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// The merchant where this transaction occurred.
  /// </summary>
  [DataContract]
  public class Merchant {
    /// <summary>
    /// The 4-digit Merchant Category Code. The merchant might be associated with multiple MCCs. In that case the MCC provided here will be the one that better describes the current transaction.
    /// </summary>
    /// <value>The 4-digit Merchant Category Code. The merchant might be associated with multiple MCCs. In that case the MCC provided here will be the one that better describes the current transaction.</value>
    [DataMember(Name="mcc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mcc")]
    public string Mcc { get; set; }

    /// <summary>
    /// The unique ID of this merchant. Must be unique for the entire system (not just within a specific industry).
    /// </summary>
    /// <value>The unique ID of this merchant. Must be unique for the entire system (not just within a specific industry).</value>
    [DataMember(Name="merchantUniqueId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "merchantUniqueId")]
    public string MerchantUniqueId { get; set; }

    /// <summary>
    /// Gets or Sets Location
    /// </summary>
    [DataMember(Name="location", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "location")]
    public MerchantLocation Location { get; set; }

    /// <summary>
    /// A JSON object that can carry any additional information about the merchant that might be helpful for fraud detection.
    /// </summary>
    /// <value>A JSON object that can carry any additional information about the merchant that might be helpful for fraud detection.</value>
    [DataMember(Name="userDefined", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userDefined")]
    public Object UserDefined { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Merchant {\n");
      sb.Append("  Mcc: ").Append(Mcc).Append("\n");
      sb.Append("  MerchantUniqueId: ").Append(MerchantUniqueId).Append("\n");
      sb.Append("  Location: ").Append(Location).Append("\n");
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
