using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Request to perform a dynamic pricing exchange rate inquiry.
  /// </summary>
  [DataContract]
  public class DynamicPricing : CurrencyConversion {
    /// <summary>
    /// The currency code to convert for dynamic pricing in ISO 4217 currency code format.
    /// </summary>
    /// <value>The currency code to convert for dynamic pricing in ISO 4217 currency code format.</value>
    [DataMember(Name="foreignCurrency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "foreignCurrency")]
    public string ForeignCurrency { get; set; }

    /// <summary>
    /// Foreign amount.
    /// </summary>
    /// <value>Foreign amount.</value>
    [DataMember(Name="foreignAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "foreignAmount")]
    public string ForeignAmount { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DynamicPricing {\n");
      sb.Append("  ForeignCurrency: ").Append(ForeignCurrency).Append("\n");
      sb.Append("  ForeignAmount: ").Append(ForeignAmount).Append("\n");
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
