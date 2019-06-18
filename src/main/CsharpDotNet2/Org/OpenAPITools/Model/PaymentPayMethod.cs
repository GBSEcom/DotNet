using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Info about the payment method.
  /// </summary>
  [DataContract]
  public class PaymentPayMethod {
    /// <summary>
    /// Unique ID for the payment method type.
    /// </summary>
    /// <value>Unique ID for the payment method type.</value>
    [DataMember(Name="methodType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "methodType")]
    public string MethodType { get; set; }

    /// <summary>
    /// The unique ID of this payment method if it was previously registered with a registration/method or if it is currently being registered. Must be unique for the entire system (not just within a specific merchant or industry). Mandatory if being used inside a registration/method.
    /// </summary>
    /// <value>The unique ID of this payment method if it was previously registered with a registration/method or if it is currently being registered. Must be unique for the entire system (not just within a specific merchant or industry). Mandatory if being used inside a registration/method.</value>
    [DataMember(Name="methodId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "methodId")]
    public string MethodId { get; set; }

    /// <summary>
    /// The address that should be used to send billing information for this payment method.
    /// </summary>
    /// <value>The address that should be used to send billing information for this payment method.</value>
    [DataMember(Name="methodAlias", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "methodAlias")]
    public string MethodAlias { get; set; }

    /// <summary>
    /// Gets or Sets Card
    /// </summary>
    [DataMember(Name="card", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "card")]
    public Card Card { get; set; }

    /// <summary>
    /// The wallet provider. This field should be normalized before sending through the API.
    /// </summary>
    /// <value>The wallet provider. This field should be normalized before sending through the API.</value>
    [DataMember(Name="provider", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "provider")]
    public string Provider { get; set; }

    /// <summary>
    /// A JSON object that can carry any additional information about the method that might be helpful for fraud detection.
    /// </summary>
    /// <value>A JSON object that can carry any additional information about the method that might be helpful for fraud detection.</value>
    [DataMember(Name="userDefined", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userDefined")]
    public Object UserDefined { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PaymentPayMethod {\n");
      sb.Append("  MethodType: ").Append(MethodType).Append("\n");
      sb.Append("  MethodId: ").Append(MethodId).Append("\n");
      sb.Append("  MethodAlias: ").Append(MethodAlias).Append("\n");
      sb.Append("  Card: ").Append(Card).Append("\n");
      sb.Append("  Provider: ").Append(Provider).Append("\n");
      sb.Append("  UserDefined: ").Append(UserDefined).Append("\n");
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
