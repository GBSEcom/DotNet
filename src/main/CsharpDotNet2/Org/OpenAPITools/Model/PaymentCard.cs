using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Payment card model.
  /// </summary>
  [DataContract]
  public class PaymentCard {
    /// <summary>
    /// Payment card number.
    /// </summary>
    /// <value>Payment card number.</value>
    [DataMember(Name="number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "number")]
    public string Number { get; set; }

    /// <summary>
    /// Gets or Sets ExpiryDate
    /// </summary>
    [DataMember(Name="expiryDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expiryDate")]
    public Expiration ExpiryDate { get; set; }

    /// <summary>
    /// Card verification value/number.
    /// </summary>
    /// <value>Card verification value/number.</value>
    [DataMember(Name="securityCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "securityCode")]
    public string SecurityCode { get; set; }

    /// <summary>
    /// Gets or Sets CardFunction
    /// </summary>
    [DataMember(Name="cardFunction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cardFunction")]
    public CardFunction CardFunction { get; set; }

    /// <summary>
    /// Name of the cardholder.
    /// </summary>
    /// <value>Name of the cardholder.</value>
    [DataMember(Name="cardholderName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cardholderName")]
    public string CardholderName { get; set; }

    /// <summary>
    /// Gets or Sets Authentication
    /// </summary>
    [DataMember(Name="authentication", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "authentication")]
    public Authentication Authentication { get; set; }

    /// <summary>
    /// The payment card BIN.
    /// </summary>
    /// <value>The payment card BIN.</value>
    [DataMember(Name="bin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bin")]
    public string Bin { get; set; }

    /// <summary>
    /// The last 4 numbers of a payment card.
    /// </summary>
    /// <value>The last 4 numbers of a payment card.</value>
    [DataMember(Name="last4", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "last4")]
    public string Last4 { get; set; }

    /// <summary>
    /// Required only if using dual branded card.
    /// </summary>
    /// <value>Required only if using dual branded card.</value>
    [DataMember(Name="brand", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "brand")]
    public string Brand { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PaymentCard {\n");
      sb.Append("  Number: ").Append(Number).Append("\n");
      sb.Append("  ExpiryDate: ").Append(ExpiryDate).Append("\n");
      sb.Append("  SecurityCode: ").Append(SecurityCode).Append("\n");
      sb.Append("  CardFunction: ").Append(CardFunction).Append("\n");
      sb.Append("  CardholderName: ").Append(CardholderName).Append("\n");
      sb.Append("  Authentication: ").Append(Authentication).Append("\n");
      sb.Append("  Bin: ").Append(Bin).Append("\n");
      sb.Append("  Last4: ").Append(Last4).Append("\n");
      sb.Append("  Brand: ").Append(Brand).Append("\n");
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
