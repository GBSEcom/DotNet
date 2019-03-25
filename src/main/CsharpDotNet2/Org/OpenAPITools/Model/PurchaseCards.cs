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
  public class PurchaseCards {
    /// <summary>
    /// Gets or Sets Level2
    /// </summary>
    [DataMember(Name="Level2", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Level2")]
    public PurchaseCardsLevel2 Level2 { get; set; }

    /// <summary>
    /// Gets or Sets Level3
    /// </summary>
    [DataMember(Name="Level3", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Level3")]
    public PurchaseCardsLevel3 Level3 { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PurchaseCards {\n");
      sb.Append("  Level2: ").Append(Level2).Append("\n");
      sb.Append("  Level3: ").Append(Level3).Append("\n");
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
