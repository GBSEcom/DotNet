using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Provides shared fields for all AuthenticationVerificationRequest types. Provides shared fields for all PrimaryTransaction request types. Abstract class, do not use this class directly, use one of its children.
  /// </summary>
  [DataContract]
  public class AuthenticationVerificationRequest {
    /// <summary>
    /// An optional Outlet ID for clients that support multiple stores in the same developer app.
    /// </summary>
    /// <value>An optional Outlet ID for clients that support multiple stores in the same developer app.</value>
    [DataMember(Name="storeId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "storeId")]
    public string StoreId { get; set; }

    /// <summary>
    /// Object name of the authentication verification request.
    /// </summary>
    /// <value>Object name of the authentication verification request.</value>
    [DataMember(Name="requestType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "requestType")]
    public string RequestType { get; set; }

    /// <summary>
    /// Card security code if required by merchant.
    /// </summary>
    /// <value>Card security code if required by merchant.</value>
    [DataMember(Name="securityCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "securityCode")]
    public string SecurityCode { get; set; }

    /// <summary>
    /// Gets or Sets BillingAddress
    /// </summary>
    [DataMember(Name="billingAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "billingAddress")]
    public Address BillingAddress { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AuthenticationVerificationRequest {\n");
      sb.Append("  StoreId: ").Append(StoreId).Append("\n");
      sb.Append("  RequestType: ").Append(RequestType).Append("\n");
      sb.Append("  SecurityCode: ").Append(SecurityCode).Append("\n");
      sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
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
