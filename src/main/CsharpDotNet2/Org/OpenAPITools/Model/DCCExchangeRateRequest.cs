using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Request to perform a DCC exchange rate inquiry.
  /// </summary>
  [DataContract]
  public class DCCExchangeRateRequest : ExchangeRateRequest {
    /// <summary>
    /// A bank identification number (BIN) of the card to be used for DCC.
    /// </summary>
    /// <value>A bank identification number (BIN) of the card to be used for DCC.</value>
    [DataMember(Name="bin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bin")]
    public string Bin { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DCCExchangeRateRequest {\n");
      sb.Append("  Bin: ").Append(Bin).Append("\n");
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
