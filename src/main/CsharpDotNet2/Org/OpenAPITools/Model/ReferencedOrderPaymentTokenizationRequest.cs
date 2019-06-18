using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Used to generate payment tokens with an existing order ID.
  /// </summary>
  [DataContract]
  public class ReferencedOrderPaymentTokenizationRequest : PaymentTokenizationRequest {
    /// <summary>
    /// Retrieves the payment instrument information from an existing order.
    /// </summary>
    /// <value>Retrieves the payment instrument information from an existing order.</value>
    [DataMember(Name="referencedOrderId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "referencedOrderId")]
    public string ReferencedOrderId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ReferencedOrderPaymentTokenizationRequest {\n");
      sb.Append("  ReferencedOrderId: ").Append(ReferencedOrderId).Append("\n");
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
