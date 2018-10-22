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
  public class PaymentCard {
    /// <summary>
    /// Payment card number
    /// </summary>
    /// <value>Payment card number</value>
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
    /// CVV
    /// </summary>
    /// <value>CVV</value>
    [DataMember(Name="securityCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "securityCode")]
    public string SecurityCode { get; set; }

    /// <summary>
    /// Gets or Sets CardFunction
    /// </summary>
    [DataMember(Name="cardFunction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cardFunction")]
    public string CardFunction { get; set; }

    /// <summary>
    /// Gets or Sets CardholderName
    /// </summary>
    [DataMember(Name="cardholderName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cardholderName")]
    public string CardholderName { get; set; }

    /// <summary>
    /// Gets or Sets AuthenticationRequest
    /// </summary>
    [DataMember(Name="authenticationRequest", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "authenticationRequest")]
    public PaymentCardAuthenticationRequest AuthenticationRequest { get; set; }

    /// <summary>
    /// Gets or Sets AuthenticationResult
    /// </summary>
    [DataMember(Name="authenticationResult", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "authenticationResult")]
    public PaymentCardAuthenticationResult AuthenticationResult { get; set; }

    /// <summary>
    /// Optional, required only if using dual branded card
    /// </summary>
    /// <value>Optional, required only if using dual branded card</value>
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
      sb.Append("  AuthenticationRequest: ").Append(AuthenticationRequest).Append("\n");
      sb.Append("  AuthenticationResult: ").Append(AuthenticationResult).Append("\n");
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
