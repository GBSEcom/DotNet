using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Request to perform an exchange rate inquiry. Abstract class, do not use this class directly, use one of its children.
  /// </summary>
  [DataContract]
  public class ExchangeRateRequest {
    /// <summary>
    /// Object name of the exchange rate request.
    /// </summary>
    /// <value>Object name of the exchange rate request.</value>
    [DataMember(Name="requestType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "requestType")]
    public string RequestType { get; set; }

    /// <summary>
    /// The original amount of the merchant currency for calculation.
    /// </summary>
    /// <value>The original amount of the merchant currency for calculation.</value>
    [DataMember(Name="baseAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "baseAmount")]
    public decimal? BaseAmount { get; set; }

    /// <summary>
    /// An optional outlet ID for clients that support multiple stores in the same app.
    /// </summary>
    /// <value>An optional outlet ID for clients that support multiple stores in the same app.</value>
    [DataMember(Name="storeId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "storeId")]
    public string StoreId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ExchangeRateRequest {\n");
      sb.Append("  RequestType: ").Append(RequestType).Append("\n");
      sb.Append("  BaseAmount: ").Append(BaseAmount).Append("\n");
      sb.Append("  StoreId: ").Append(StoreId).Append("\n");
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
