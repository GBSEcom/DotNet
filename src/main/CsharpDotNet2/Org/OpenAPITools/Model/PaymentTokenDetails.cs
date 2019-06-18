using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Response details for payment token creation.
  /// </summary>
  [DataContract]
  public class PaymentTokenDetails : CreatePaymentToken {
    /// <summary>
    /// The last 4 numbers of a payment card.
    /// </summary>
    /// <value>The last 4 numbers of a payment card.</value>
    [DataMember(Name="last4", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "last4")]
    public string Last4 { get; set; }

    /// <summary>
    /// Card brand, only for tokenization with payment.
    /// </summary>
    /// <value>Card brand, only for tokenization with payment.</value>
    [DataMember(Name="brand", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "brand")]
    public string Brand { get; set; }

    /// <summary>
    /// If the account the token was created from has been verified.
    /// </summary>
    /// <value>If the account the token was created from has been verified.</value>
    [DataMember(Name="accountVerification", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountVerification")]
    public bool? AccountVerification { get; set; }

    /// <summary>
    /// Inidcates the type of tokenization source.
    /// </summary>
    /// <value>Inidcates the type of tokenization source.</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PaymentTokenDetails {\n");
      sb.Append("  Last4: ").Append(Last4).Append("\n");
      sb.Append("  Brand: ").Append(Brand).Append("\n");
      sb.Append("  AccountVerification: ").Append(AccountVerification).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
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
