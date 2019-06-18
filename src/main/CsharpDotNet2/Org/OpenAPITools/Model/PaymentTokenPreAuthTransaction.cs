using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Request to create pre-auth transaction using payment token.
  /// </summary>
  [DataContract]
  public class PaymentTokenPreAuthTransaction : PrimaryTransaction {
    /// <summary>
    /// Gets or Sets PaymentMethod
    /// </summary>
    [DataMember(Name="paymentMethod", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paymentMethod")]
    public PaymentTokenPaymentMethod PaymentMethod { get; set; }

    /// <summary>
    /// Gets or Sets StoredCredentials
    /// </summary>
    [DataMember(Name="storedCredentials", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "storedCredentials")]
    public StoredCredential StoredCredentials { get; set; }

    /// <summary>
    /// Gets or Sets SplitShipment
    /// </summary>
    [DataMember(Name="splitShipment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "splitShipment")]
    public SplitShipment SplitShipment { get; set; }

    /// <summary>
    /// Settle with multiple sub-merchants, sale and preAuth only.
    /// </summary>
    /// <value>Settle with multiple sub-merchants, sale and preAuth only.</value>
    [DataMember(Name="settlementSplit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "settlementSplit")]
    public List<SubMerchantSplit> SettlementSplit { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PaymentTokenPreAuthTransaction {\n");
      sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
      sb.Append("  StoredCredentials: ").Append(StoredCredentials).Append("\n");
      sb.Append("  SplitShipment: ").Append(SplitShipment).Append("\n");
      sb.Append("  SettlementSplit: ").Append(SettlementSplit).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public  new string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
