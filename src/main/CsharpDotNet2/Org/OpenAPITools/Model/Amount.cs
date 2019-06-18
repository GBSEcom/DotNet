using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Amount of the transaction.
  /// </summary>
  [DataContract]
  public class Amount {
    /// <summary>
    /// Amount total.
    /// </summary>
    /// <value>Amount total.</value>
    [DataMember(Name="total", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total")]
    public decimal? Total { get; set; }

    /// <summary>
    /// ISO 4217 currency code.
    /// </summary>
    /// <value>ISO 4217 currency code.</value>
    [DataMember(Name="currency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currency")]
    public string Currency { get; set; }

    /// <summary>
    /// Gets or Sets Components
    /// </summary>
    [DataMember(Name="components", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "components")]
    public AmountComponents Components { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Amount {\n");
      sb.Append("  Total: ").Append(Total).Append("\n");
      sb.Append("  Currency: ").Append(Currency).Append("\n");
      sb.Append("  Components: ").Append(Components).Append("\n");
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
