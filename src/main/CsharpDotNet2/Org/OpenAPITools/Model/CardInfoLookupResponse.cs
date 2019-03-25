using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Response from card info lookup request.
  /// </summary>
  [DataContract]
  public class CardInfoLookupResponse : BasicResponse {
    /// <summary>
    /// One or more card information retrieved based on BIN.
    /// </summary>
    /// <value>One or more card information retrieved based on BIN.</value>
    [DataMember(Name="cardDetails", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cardDetails")]
    public List<CardInfo> CardDetails { get; set; }

    /// <summary>
    /// Request status.
    /// </summary>
    /// <value>Request status.</value>
    [DataMember(Name="requestStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "requestStatus")]
    public string RequestStatus { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CardInfoLookupResponse {\n");
      sb.Append("  CardDetails: ").Append(CardDetails).Append("\n");
      sb.Append("  RequestStatus: ").Append(RequestStatus).Append("\n");
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
