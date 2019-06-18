using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Request to verify card validity.
  /// </summary>
  [DataContract]
  public class CardVerificationRequest {
    /// <summary>
    /// Gets or Sets PaymentCard
    /// </summary>
    [DataMember(Name="paymentCard", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paymentCard")]
    public PaymentCard PaymentCard { get; set; }

    /// <summary>
    /// Gets or Sets BillingAddress
    /// </summary>
    [DataMember(Name="billingAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "billingAddress")]
    public Address BillingAddress { get; set; }

    /// <summary>
    /// An optional outlet ID for clients that support multiple stores in the same app.
    /// </summary>
    /// <value>An optional outlet ID for clients that support multiple stores in the same app.</value>
    [DataMember(Name="storeId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "storeId")]
    public string StoreId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CardVerificationRequest {\n");
      sb.Append("  PaymentCard: ").Append(PaymentCard).Append("\n");
      sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
      sb.Append("  StoreId: ").Append(StoreId).Append("\n");
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
