using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// The payment object for PayPal transactions. The recipientEmail element is required for this payment type.
  /// </summary>
  [DataContract]
  public class PayPal {
    /// <summary>
    /// Email address of the recipient
    /// </summary>
    /// <value>Email address of the recipient</value>
    [DataMember(Name="recipientEmail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recipientEmail")]
    public string RecipientEmail { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PayPal {\n");
      sb.Append("  RecipientEmail: ").Append(RecipientEmail).Append("\n");
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
