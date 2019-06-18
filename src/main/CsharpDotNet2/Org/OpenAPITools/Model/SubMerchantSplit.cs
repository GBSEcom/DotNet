using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Sub-merchant split object for SettlementSplit.
  /// </summary>
  [DataContract]
  public class SubMerchantSplit {
    /// <summary>
    /// ID of merchant for tracking.
    /// </summary>
    /// <value>ID of merchant for tracking.</value>
    [DataMember(Name="merchantID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "merchantID")]
    public string MerchantID { get; set; }

    /// <summary>
    /// The amount each sub-merchant receives.
    /// </summary>
    /// <value>The amount each sub-merchant receives.</value>
    [DataMember(Name="amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amount")]
    public decimal? Amount { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SubMerchantSplit {\n");
      sb.Append("  MerchantID: ").Append(MerchantID).Append("\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
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
