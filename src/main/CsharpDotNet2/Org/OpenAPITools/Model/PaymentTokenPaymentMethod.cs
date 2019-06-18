using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Payment method containing payment tokenization information.
  /// </summary>
  [DataContract]
  public class PaymentTokenPaymentMethod : PaymentMethod {
    /// <summary>
    /// Gets or Sets PaymentToken
    /// </summary>
    [DataMember(Name="paymentToken", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paymentToken")]
    public UsePaymentToken PaymentToken { get; set; }

    /// <summary>
    /// Gets or Sets PaymentFacilitator
    /// </summary>
    [DataMember(Name="paymentFacilitator", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paymentFacilitator")]
    public PaymentFacilitator PaymentFacilitator { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PaymentTokenPaymentMethod {\n");
      sb.Append("  PaymentToken: ").Append(PaymentToken).Append("\n");
      sb.Append("  PaymentFacilitator: ").Append(PaymentFacilitator).Append("\n");
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
