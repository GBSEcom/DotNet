using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class PaymentMethod {
    /// <summary>
    /// The type of payment method. Note that PayPal can only process a 'Credit'  primary transaction with Order.Billing.Contact.email being mandatory. PayPal secondary transactions (void/return/postauth) are processed the same as any other secondary transactions.
    /// </summary>
    /// <value>The type of payment method. Note that PayPal can only process a 'Credit'  primary transaction with Order.Billing.Contact.email being mandatory. PayPal secondary transactions (void/return/postauth) are processed the same as any other secondary transactions.</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Gets or Sets PaymentCard
    /// </summary>
    [DataMember(Name="paymentCard", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paymentCard")]
    public PaymentCard PaymentCard { get; set; }

    /// <summary>
    /// Gets or Sets Sepa
    /// </summary>
    [DataMember(Name="sepa", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sepa")]
    public Sepa Sepa { get; set; }

    /// <summary>
    /// Gets or Sets PayPal
    /// </summary>
    [DataMember(Name="payPal", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "payPal")]
    public PayPal PayPal { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PaymentMethod {\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  PaymentCard: ").Append(PaymentCard).Append("\n");
      sb.Append("  Sepa: ").Append(Sepa).Append("\n");
      sb.Append("  PayPal: ").Append(PayPal).Append("\n");
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
