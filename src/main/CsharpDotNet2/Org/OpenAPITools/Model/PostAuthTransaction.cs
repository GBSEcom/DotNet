using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Request to perform post auth transaction.
  /// </summary>
  [DataContract]
  public class PostAuthTransaction : SecondaryTransaction {
    /// <summary>
    /// Gets or Sets TransactionAmount
    /// </summary>
    [DataMember(Name="transactionAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transactionAmount")]
    public Amount TransactionAmount { get; set; }

    /// <summary>
    /// Gets or Sets TransactionOrigin
    /// </summary>
    [DataMember(Name="transactionOrigin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transactionOrigin")]
    public TransactionOrigin TransactionOrigin { get; set; }

    /// <summary>
    /// Gets or Sets SplitShipment
    /// </summary>
    [DataMember(Name="splitShipment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "splitShipment")]
    public SplitShipment SplitShipment { get; set; }

    /// <summary>
    /// Gets or Sets SoftDescriptor
    /// </summary>
    [DataMember(Name="softDescriptor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "softDescriptor")]
    public SoftDescriptor SoftDescriptor { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PostAuthTransaction {\n");
      sb.Append("  TransactionAmount: ").Append(TransactionAmount).Append("\n");
      sb.Append("  TransactionOrigin: ").Append(TransactionOrigin).Append("\n");
      sb.Append("  SplitShipment: ").Append(SplitShipment).Append("\n");
      sb.Append("  SoftDescriptor: ").Append(SoftDescriptor).Append("\n");
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
