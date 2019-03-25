using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Payment card model
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
    /// Card Verification Value/Number
    /// </summary>
    /// <value>Card Verification Value/Number</value>
    [DataMember(Name="securityCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "securityCode")]
    public string SecurityCode { get; set; }

    /// <summary>
    /// Gets or Sets PaymentTokenization
    /// </summary>
    [DataMember(Name="paymentTokenization", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paymentTokenization")]
    public PaymentTokenization PaymentTokenization { get; set; }

    /// <summary>
    /// Card function. Optional, valid values are CREDIT or DEBIT.
    /// </summary>
    /// <value>Card function. Optional, valid values are CREDIT or DEBIT.</value>
    [DataMember(Name="cardFunction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cardFunction")]
    public string CardFunction { get; set; }

    /// <summary>
    /// Name of the cardholder on the card
    /// </summary>
    /// <value>Name of the cardholder on the card</value>
    [DataMember(Name="cardholderName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cardholderName")]
    public string CardholderName { get; set; }

    /// <summary>
    /// Gets or Sets AuthenticationRequest
    /// </summary>
    [DataMember(Name="authenticationRequest", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "authenticationRequest")]
    public AuthenticationRequest AuthenticationRequest { get; set; }

    /// <summary>
    /// Gets or Sets AuthenticationResult
    /// </summary>
    [DataMember(Name="authenticationResult", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "authenticationResult")]
    public PaymentCardAuthenticationResult AuthenticationResult { get; set; }

    /// <summary>
    /// The payment card BIN
    /// </summary>
    /// <value>The payment card BIN</value>
    [DataMember(Name="bin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bin")]
    public string Bin { get; set; }

    /// <summary>
    /// The last 4 payment card numbers
    /// </summary>
    /// <value>The last 4 payment card numbers</value>
    [DataMember(Name="last4", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "last4")]
    public string Last4 { get; set; }

    /// <summary>
    /// Optional, required only if using dual branded card
    /// </summary>
    /// <value>Optional, required only if using dual branded card</value>
    [DataMember(Name="brand", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "brand")]
    public string Brand { get; set; }

    /// <summary>
    /// The issuing country
    /// </summary>
    /// <value>The issuing country</value>
    [DataMember(Name="issuingCountry", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "issuingCountry")]
    public string IssuingCountry { get; set; }


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
      sb.Append("  PaymentTokenization: ").Append(PaymentTokenization).Append("\n");
      sb.Append("  CardFunction: ").Append(CardFunction).Append("\n");
      sb.Append("  CardholderName: ").Append(CardholderName).Append("\n");
      sb.Append("  AuthenticationRequest: ").Append(AuthenticationRequest).Append("\n");
      sb.Append("  AuthenticationResult: ").Append(AuthenticationResult).Append("\n");
      sb.Append("  Bin: ").Append(Bin).Append("\n");
      sb.Append("  Last4: ").Append(Last4).Append("\n");
      sb.Append("  Brand: ").Append(Brand).Append("\n");
      sb.Append("  IssuingCountry: ").Append(IssuingCountry).Append("\n");
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
