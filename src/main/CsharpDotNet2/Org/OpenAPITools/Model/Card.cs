using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Properties for the payment method.
  /// </summary>
  [DataContract]
  public class Card {
    /// <summary>
    /// TransArmor token value. Either the token fields or card number field must contain a value.
    /// </summary>
    /// <value>TransArmor token value. Either the token fields or card number field must contain a value.</value>
    [DataMember(Name="taToken", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "taToken")]
    public string TaToken { get; set; }

    /// <summary>
    /// TransArmor token key to identify the merchant.
    /// </summary>
    /// <value>TransArmor token key to identify the merchant.</value>
    [DataMember(Name="taTokenKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "taTokenKey")]
    public string TaTokenKey { get; set; }

    /// <summary>
    /// The cardholder name as it appears on the card.
    /// </summary>
    /// <value>The cardholder name as it appears on the card.</value>
    [DataMember(Name="cardholderName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cardholderName")]
    public string CardholderName { get; set; }

    /// <summary>
    /// Use this field to send clear PAN or tokens other than TransArmor Token.
    /// </summary>
    /// <value>Use this field to send clear PAN or tokens other than TransArmor Token.</value>
    [DataMember(Name="cardNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cardNumber")]
    public string CardNumber { get; set; }

    /// <summary>
    /// Payment method expiration date. Format is MMYYYY.
    /// </summary>
    /// <value>Payment method expiration date. Format is MMYYYY.</value>
    [DataMember(Name="expDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expDate")]
    public string ExpDate { get; set; }

    /// <summary>
    /// CVV present indicator.
    /// </summary>
    /// <value>CVV present indicator.</value>
    [DataMember(Name="cvv", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cvv")]
    public string Cvv { get; set; }

    /// <summary>
    /// The company (usually a bank) that issued the card.
    /// </summary>
    /// <value>The company (usually a bank) that issued the card.</value>
    [DataMember(Name="issuer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "issuer")]
    public string Issuer { get; set; }

    /// <summary>
    /// A number that distinguishes between two plastic cards with the same card number in the event of the card being re-issued.
    /// </summary>
    /// <value>A number that distinguishes between two plastic cards with the same card number in the event of the card being re-issued.</value>
    [DataMember(Name="cardReissuedNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cardReissuedNumber")]
    public string CardReissuedNumber { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Card {\n");
      sb.Append("  TaToken: ").Append(TaToken).Append("\n");
      sb.Append("  TaTokenKey: ").Append(TaTokenKey).Append("\n");
      sb.Append("  CardholderName: ").Append(CardholderName).Append("\n");
      sb.Append("  CardNumber: ").Append(CardNumber).Append("\n");
      sb.Append("  ExpDate: ").Append(ExpDate).Append("\n");
      sb.Append("  Cvv: ").Append(Cvv).Append("\n");
      sb.Append("  Issuer: ").Append(Issuer).Append("\n");
      sb.Append("  CardReissuedNumber: ").Append(CardReissuedNumber).Append("\n");
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
