using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Request to create sale transaction using payment card.
  /// </summary>
  [DataContract]
  public class PaymentCardSaleTransaction : PrimaryTransaction {
    /// <summary>
    /// Gets or Sets PaymentMethod
    /// </summary>
    [DataMember(Name="paymentMethod", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paymentMethod")]
    public PaymentCardPaymentMethod PaymentMethod { get; set; }

    /// <summary>
    /// Gets or Sets StoredCredentials
    /// </summary>
    [DataMember(Name="storedCredentials", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "storedCredentials")]
    public StoredCredential StoredCredentials { get; set; }

    /// <summary>
    /// Settle with multiple sub-merchants, sale and preAuth only.
    /// </summary>
    /// <value>Settle with multiple sub-merchants, sale and preAuth only.</value>
    [DataMember(Name="settlementSplit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "settlementSplit")]
    public List<SubMerchantSplit> SettlementSplit { get; set; }

    /// <summary>
    /// Gets or Sets CreateToken
    /// </summary>
    [DataMember(Name="createToken", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "createToken")]
    public CreatePaymentToken CreateToken { get; set; }

    /// <summary>
    /// Gets or Sets CurrencyConversion
    /// </summary>
    [DataMember(Name="currencyConversion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currencyConversion")]
    public CurrencyConversion CurrencyConversion { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PaymentCardSaleTransaction {\n");
      sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
      sb.Append("  StoredCredentials: ").Append(StoredCredentials).Append("\n");
      sb.Append("  SettlementSplit: ").Append(SettlementSplit).Append("\n");
      sb.Append("  CreateToken: ").Append(CreateToken).Append("\n");
      sb.Append("  CurrencyConversion: ").Append(CurrencyConversion).Append("\n");
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
