using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// The payment object for AliPay transactions. Use this to populate Alipay payment method details.
  /// </summary>
  [DataContract]
  public class AliPay {
    /// <summary>
    /// Use this to indicate the type of machine-readable payment data for scanning.
    /// </summary>
    /// <value>Use this to indicate the type of machine-readable payment data for scanning.</value>
    [DataMember(Name="paymentDataType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paymentDataType")]
    public string PaymentDataType { get; set; }

    /// <summary>
    /// Use this to send payment related information, such as customer identity ID.
    /// </summary>
    /// <value>Use this to send payment related information, such as customer identity ID.</value>
    [DataMember(Name="paymentData", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paymentData")]
    public string PaymentData { get; set; }

    /// <summary>
    /// Use this to send an order title that shows up in the statement.
    /// </summary>
    /// <value>Use this to send an order title that shows up in the statement.</value>
    [DataMember(Name="orderTitle", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "orderTitle")]
    public string OrderTitle { get; set; }

    /// <summary>
    /// Use this to send order details that show up in the statement.
    /// </summary>
    /// <value>Use this to send order details that show up in the statement.</value>
    [DataMember(Name="orderDetails", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "orderDetails")]
    public string OrderDetails { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AliPay {\n");
      sb.Append("  PaymentDataType: ").Append(PaymentDataType).Append("\n");
      sb.Append("  PaymentData: ").Append(PaymentData).Append("\n");
      sb.Append("  OrderTitle: ").Append(OrderTitle).Append("\n");
      sb.Append("  OrderDetails: ").Append(OrderDetails).Append("\n");
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
