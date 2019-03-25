using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class ExchangeRateRequest {
    /// <summary>
    /// Type of exchange rate inquiry. Valid values are 'DCC' and 'DYNAMIC_PRICING'.
    /// </summary>
    /// <value>Type of exchange rate inquiry. Valid values are 'DCC' and 'DYNAMIC_PRICING'.</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// An optional Outlet ID for clients that support multiple stores in the same app.
    /// </summary>
    /// <value>An optional Outlet ID for clients that support multiple stores in the same app.</value>
    [DataMember(Name="storeId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "storeId")]
    public string StoreId { get; set; }

    /// <summary>
    /// A bank identification number (BIN) of the card to be used for DCC.
    /// </summary>
    /// <value>A bank identification number (BIN) of the card to be used for DCC.</value>
    [DataMember(Name="bin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bin")]
    public string Bin { get; set; }

    /// <summary>
    /// The original amount of the merchant currency for calculation.
    /// </summary>
    /// <value>The original amount of the merchant currency for calculation.</value>
    [DataMember(Name="baseAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "baseAmount")]
    public decimal? BaseAmount { get; set; }

    /// <summary>
    /// The currency code to convert for Dynamic Pricing.
    /// </summary>
    /// <value>The currency code to convert for Dynamic Pricing.</value>
    [DataMember(Name="foreignCurrency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "foreignCurrency")]
    public string ForeignCurrency { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ExchangeRateRequest {\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  StoreId: ").Append(StoreId).Append("\n");
      sb.Append("  Bin: ").Append(Bin).Append("\n");
      sb.Append("  BaseAmount: ").Append(BaseAmount).Append("\n");
      sb.Append("  ForeignCurrency: ").Append(ForeignCurrency).Append("\n");
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
