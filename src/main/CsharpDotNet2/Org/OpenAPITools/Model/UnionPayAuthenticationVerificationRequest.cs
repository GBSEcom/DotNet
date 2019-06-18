using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Authentication verification request specific to UnionPay transactions.
  /// </summary>
  [DataContract]
  public class UnionPayAuthenticationVerificationRequest : AuthenticationVerificationRequest {
    /// <summary>
    /// Customer mobile number for SMS verification.
    /// </summary>
    /// <value>Customer mobile number for SMS verification.</value>
    [DataMember(Name="smsVerificationCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "smsVerificationCode")]
    public string SmsVerificationCode { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UnionPayAuthenticationVerificationRequest {\n");
      sb.Append("  SmsVerificationCode: ").Append(SmsVerificationCode).Append("\n");
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
