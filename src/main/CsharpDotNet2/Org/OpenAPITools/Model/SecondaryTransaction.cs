using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Model for secondary financial transactions. Abstract class, do not use this class directly, use one of its children.
  /// </summary>
  [DataContract]
  public class SecondaryTransaction {
    /// <summary>
    /// Object name of the secondary transaction request.
    /// </summary>
    /// <value>Object name of the secondary transaction request.</value>
    [DataMember(Name="requestType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "requestType")]
    public string RequestType { get; set; }

    /// <summary>
    /// An optional outlet ID for clients that support multiple stores in the same developer app.
    /// </summary>
    /// <value>An optional outlet ID for clients that support multiple stores in the same developer app.</value>
    [DataMember(Name="storeId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "storeId")]
    public string StoreId { get; set; }

    /// <summary>
    /// Comment for the secondary transaction.
    /// </summary>
    /// <value>Comment for the secondary transaction.</value>
    [DataMember(Name="comments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "comments")]
    public string Comments { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SecondaryTransaction {\n");
      sb.Append("  RequestType: ").Append(RequestType).Append("\n");
      sb.Append("  StoreId: ").Append(StoreId).Append("\n");
      sb.Append("  Comments: ").Append(Comments).Append("\n");
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
