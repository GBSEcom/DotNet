using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Request authentication of the payment card to verify the cardholder and be eligible for liability shift.
  /// </summary>
  [DataContract]
  public class AuthenticationRequest {
    /// <summary>
    /// Indicates what kind of authentication scheme the merchant wants to use on the card.
    /// </summary>
    /// <value>Indicates what kind of authentication scheme the merchant wants to use on the card.</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Use this to enter the customer mobile number for SMS verification
    /// </summary>
    /// <value>Use this to enter the customer mobile number for SMS verification</value>
    [DataMember(Name="smsPhoneNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "smsPhoneNumber")]
    public string SmsPhoneNumber { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AuthenticationRequest {\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  SmsPhoneNumber: ").Append(SmsPhoneNumber).Append("\n");
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
