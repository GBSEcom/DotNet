using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Order response containing recurring payment details.
  /// </summary>
  [DataContract]
  public class RecurringPaymentDetailsResponse : OrderResponse {
    /// <summary>
    /// Gets or Sets RecurringPaymentDetails
    /// </summary>
    [DataMember(Name="recurringPaymentDetails", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recurringPaymentDetails")]
    public RecurringPaymentDetails RecurringPaymentDetails { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RecurringPaymentDetailsResponse {\n");
      sb.Append("  RecurringPaymentDetails: ").Append(RecurringPaymentDetails).Append("\n");
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
