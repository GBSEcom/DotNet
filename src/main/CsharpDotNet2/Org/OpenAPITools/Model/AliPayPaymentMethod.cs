using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Payment method containing AliPay information.
  /// </summary>
  [DataContract]
  public class AliPayPaymentMethod : PaymentMethod {
    /// <summary>
    /// Gets or Sets AliPay
    /// </summary>
    [DataMember(Name="aliPay", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "aliPay")]
    public AliPay AliPay { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AliPayPaymentMethod {\n");
      sb.Append("  AliPay: ").Append(AliPay).Append("\n");
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
