using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Object for sending visa store credential
  /// </summary>
  [DataContract]
  public class StoredCredential {
    /// <summary>
    /// Indicates if the transaction is first or subsequent. Valid values are 'FIRST' and 'SUBSEQUENT'
    /// </summary>
    /// <value>Indicates if the transaction is first or subsequent. Valid values are 'FIRST' and 'SUBSEQUENT'</value>
    [DataMember(Name="sequence", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sequence")]
    public string Sequence { get; set; }

    /// <summary>
    /// Indicates if the transaction is scheduled or part of a installment
    /// </summary>
    /// <value>Indicates if the transaction is scheduled or part of a installment</value>
    [DataMember(Name="scheduled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "scheduled")]
    public bool? Scheduled { get; set; }

    /// <summary>
    /// The transaction id received from schemes for the initial transaction. Required if sequence is 'SUBSEQUENT'
    /// </summary>
    /// <value>The transaction id received from schemes for the initial transaction. Required if sequence is 'SUBSEQUENT'</value>
    [DataMember(Name="referencedSchemeTransactionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "referencedSchemeTransactionId")]
    public string ReferencedSchemeTransactionId { get; set; }

    /// <summary>
    /// Indicates whether it is a merchant initiated or explicitly consented by card holder. Valid values are 'MERCHANT' and 'CARDHOLDER'
    /// </summary>
    /// <value>Indicates whether it is a merchant initiated or explicitly consented by card holder. Valid values are 'MERCHANT' and 'CARDHOLDER'</value>
    [DataMember(Name="initiator", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "initiator")]
    public string Initiator { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class StoredCredential {\n");
      sb.Append("  Sequence: ").Append(Sequence).Append("\n");
      sb.Append("  Scheduled: ").Append(Scheduled).Append("\n");
      sb.Append("  ReferencedSchemeTransactionId: ").Append(ReferencedSchemeTransactionId).Append("\n");
      sb.Append("  Initiator: ").Append(Initiator).Append("\n");
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
