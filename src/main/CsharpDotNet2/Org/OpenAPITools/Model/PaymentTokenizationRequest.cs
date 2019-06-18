using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Used to generate payment tokens. Abstract class, do not use this class directly, use one of its children.
  /// </summary>
  [DataContract]
  public class PaymentTokenizationRequest {
    /// <summary>
    /// Object name of tokenization request.
    /// </summary>
    /// <value>Object name of tokenization request.</value>
    [DataMember(Name="requestType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "requestType")]
    public string RequestType { get; set; }

    /// <summary>
    /// An optional outlet ID for clients that support multiple stores in the same app.
    /// </summary>
    /// <value>An optional outlet ID for clients that support multiple stores in the same app.</value>
    [DataMember(Name="storeId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "storeId")]
    public string StoreId { get; set; }

    /// <summary>
    /// Gets or Sets BillingAddress
    /// </summary>
    [DataMember(Name="billingAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "billingAddress")]
    public Address BillingAddress { get; set; }

    /// <summary>
    /// Gets or Sets CreateToken
    /// </summary>
    [DataMember(Name="createToken", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "createToken")]
    public CreatePaymentToken CreateToken { get; set; }

    /// <summary>
    /// If the account should be verified prior to token creation.
    /// </summary>
    /// <value>If the account should be verified prior to token creation.</value>
    [DataMember(Name="accountVerification", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountVerification")]
    public bool? AccountVerification { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PaymentTokenizationRequest {\n");
      sb.Append("  RequestType: ").Append(RequestType).Append("\n");
      sb.Append("  StoreId: ").Append(StoreId).Append("\n");
      sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
      sb.Append("  CreateToken: ").Append(CreateToken).Append("\n");
      sb.Append("  AccountVerification: ").Append(AccountVerification).Append("\n");
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
