using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Level 3 data for monitoring and controlling corporate expenditures.
  /// </summary>
  [DataContract]
  public class PurchaseCardsLevel3 {
    /// <summary>
    /// Line items.
    /// </summary>
    /// <value>Line items.</value>
    [DataMember(Name="lineItems", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lineItems")]
    public List<PurchaseCardsLevel3LineItems> LineItems { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PurchaseCardsLevel3 {\n");
      sb.Append("  LineItems: ").Append(LineItems).Append("\n");
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
