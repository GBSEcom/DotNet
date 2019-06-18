using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Request to create a new payment schedule using a referenced order ID.
  /// </summary>
  [DataContract]
  public class ReferencedOrderPaymentSchedulesRequest : PaymentSchedulesRequest {
    /// <summary>
    /// Order ID used to create recurring payment from existing transaction.
    /// </summary>
    /// <value>Order ID used to create recurring payment from existing transaction.</value>
    [DataMember(Name="referencedOrderId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "referencedOrderId")]
    public string ReferencedOrderId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ReferencedOrderPaymentSchedulesRequest {\n");
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
