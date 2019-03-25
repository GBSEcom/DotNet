using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Identifying information about a merchant which appears on buyer&#39;s credit/debit card statements
  /// </summary>
  [DataContract]
  public class SoftDescriptor {
    /// <summary>
    /// Store \"doing-business-as\" name
    /// </summary>
    /// <value>Store \"doing-business-as\" name</value>
    [DataMember(Name="dba", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dba")]
    public string Dba { get; set; }

    /// <summary>
    /// The 4-digit Merchant Category Code. The merchant might be associated with multiple MCCs. In that case the MCC provided here will be the one that better describes the current transaction.
    /// </summary>
    /// <value>The 4-digit Merchant Category Code. The merchant might be associated with multiple MCCs. In that case the MCC provided here will be the one that better describes the current transaction.</value>
    [DataMember(Name="mcc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mcc")]
    public string Mcc { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SoftDescriptor {\n");
      sb.Append("  Dba: ").Append(Dba).Append("\n");
      sb.Append("  Mcc: ").Append(Mcc).Append("\n");
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
