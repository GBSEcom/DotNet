using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Provides shared fields for all PrimaryTransaction request types. Abstract class, do not use this class directly, use one of its children.
  /// </summary>
  [DataContract]
  public class PrimaryTransaction {
    /// <summary>
    /// Object name of the primary transaction request.
    /// </summary>
    /// <value>Object name of the primary transaction request.</value>
    [DataMember(Name="requestType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "requestType")]
    public string RequestType { get; set; }

    /// <summary>
    /// An optional outlet ID for clients that support multiple stores in the same app.
    /// </summary>
    /// <value>An optional outlet ID for clients that support multiple stores in the same app.</value>
    [DataMember(Name="storeId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "storeId")]
    public string StoreId { get; set; }

    /// <summary>
    /// The unique merchant transaction ID from the request header, if supplied.
    /// </summary>
    /// <value>The unique merchant transaction ID from the request header, if supplied.</value>
    [DataMember(Name="merchantTransactionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "merchantTransactionId")]
    public string MerchantTransactionId { get; set; }

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
    /// Gets or Sets Order
    /// </summary>
    [DataMember(Name="order", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "order")]
    public Order Order { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PrimaryTransaction {\n");
      sb.Append("  RequestType: ").Append(RequestType).Append("\n");
      sb.Append("  StoreId: ").Append(StoreId).Append("\n");
      sb.Append("  MerchantTransactionId: ").Append(MerchantTransactionId).Append("\n");
      sb.Append("  TransactionAmount: ").Append(TransactionAmount).Append("\n");
      sb.Append("  TransactionOrigin: ").Append(TransactionOrigin).Append("\n");
      sb.Append("  Order: ").Append(Order).Append("\n");
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
