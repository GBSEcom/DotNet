using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Provides details of the payment method used.
  /// </summary>
  [DataContract]
  public class PaymentMethodDetails {
    /// <summary>
    /// Gets or Sets PaymentCard
    /// </summary>
    [DataMember(Name="paymentCard", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paymentCard")]
    public PaymentCard PaymentCard { get; set; }

    /// <summary>
    /// Gets or Sets PaymentMethodType
    /// </summary>
    [DataMember(Name="paymentMethodType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paymentMethodType")]
    public PaymentMethodType PaymentMethodType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PaymentMethodDetails {\n");
      sb.Append("  PaymentCard: ").Append(PaymentCard).Append("\n");
      sb.Append("  PaymentMethodType: ").Append(PaymentMethodType).Append("\n");
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
