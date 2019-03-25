using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Object holding response verification information.
  /// </summary>
  [DataContract]
  public class AuthenticationResponseVerification {
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Use this to enter the customer mobile number for SMS verification.
    /// </summary>
    /// <value>Use this to enter the customer mobile number for SMS verification.</value>
    [DataMember(Name="smsVerificationCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "smsVerificationCode")]
    public string SmsVerificationCode { get; set; }

    /// <summary>
    /// Gets or Sets MerchantData
    /// </summary>
    [DataMember(Name="merchantData", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "merchantData")]
    public string MerchantData { get; set; }

    /// <summary>
    /// Payer authentication result from Payment Authentication Response (PaRes)
    /// </summary>
    /// <value>Payer authentication result from Payment Authentication Response (PaRes)</value>
    [DataMember(Name="paRes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paRes")]
    public string PaRes { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AuthenticationResponseVerification {\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  SmsVerificationCode: ").Append(SmsVerificationCode).Append("\n");
      sb.Append("  MerchantData: ").Append(MerchantData).Append("\n");
      sb.Append("  PaRes: ").Append(PaRes).Append("\n");
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
