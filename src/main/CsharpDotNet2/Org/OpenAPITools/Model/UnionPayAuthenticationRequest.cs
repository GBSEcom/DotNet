using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Request authentication of the payment card using the UnionPay SMS scheme.
  /// </summary>
  [DataContract]
  public class UnionPayAuthenticationRequest : Authentication {
    /// <summary>
    /// Mobile number for SMS verification.
    /// </summary>
    /// <value>Mobile number for SMS verification.</value>
    [DataMember(Name="smsPhoneNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "smsPhoneNumber")]
    public string SmsPhoneNumber { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UnionPayAuthenticationRequest {\n");
      sb.Append("  SmsPhoneNumber: ").Append(SmsPhoneNumber).Append("\n");
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
