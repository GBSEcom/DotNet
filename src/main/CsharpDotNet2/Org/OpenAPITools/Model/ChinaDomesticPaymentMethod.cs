using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Payment method containing China Domestic information.
  /// </summary>
  [DataContract]
  public class ChinaDomesticPaymentMethod : PaymentMethod {
    /// <summary>
    /// Gets or Sets ChinaDomestic
    /// </summary>
    [DataMember(Name="chinaDomestic", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "chinaDomestic")]
    public ChinaDomestic ChinaDomestic { get; set; }

    /// <summary>
    /// Gets or Sets Brand
    /// </summary>
    [DataMember(Name="brand", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "brand")]
    public string Brand { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ChinaDomesticPaymentMethod {\n");
      sb.Append("  ChinaDomestic: ").Append(ChinaDomestic).Append("\n");
      sb.Append("  Brand: ").Append(Brand).Append("\n");
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
