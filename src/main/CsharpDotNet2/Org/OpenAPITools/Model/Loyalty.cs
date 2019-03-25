using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// The loyalty program information associated with this payment.
  /// </summary>
  [DataContract]
  public class Loyalty {
    /// <summary>
    /// A unique ID associated with the loyalty program account. Must be unique within the merchants system. Depending on loyalty programs the account might also serve as a credit/bank account. If this is the case the ID must be not be the PAN.
    /// </summary>
    /// <value>A unique ID associated with the loyalty program account. Must be unique within the merchants system. Depending on loyalty programs the account might also serve as a credit/bank account. If this is the case the ID must be not be the PAN.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// A string that identifies the program in which the customer is enrolled if the merchant supports several programs or levels.
    /// </summary>
    /// <value>A string that identifies the program in which the customer is enrolled if the merchant supports several programs or levels.</value>
    [DataMember(Name="program", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "program")]
    public string Program { get; set; }

    /// <summary>
    /// The balance of the loyalty program account in a program specific currency (e.g. points).
    /// </summary>
    /// <value>The balance of the loyalty program account in a program specific currency (e.g. points).</value>
    [DataMember(Name="balance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "balance")]
    public decimal? Balance { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Loyalty {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Program: ").Append(Program).Append("\n");
      sb.Append("  Balance: ").Append(Balance).Append("\n");
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
