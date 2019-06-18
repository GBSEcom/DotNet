using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Details related to updated account information.
  /// </summary>
  [DataContract]
  public class AccountUpdaterResponse {
    /// <summary>
    /// Account updater replacement PAN or TransArmor token.
    /// </summary>
    /// <value>Account updater replacement PAN or TransArmor token.</value>
    [DataMember(Name="updatedCard", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updatedCard")]
    public string UpdatedCard { get; set; }

    /// <summary>
    /// Updated value of token.
    /// </summary>
    /// <value>Updated value of token.</value>
    [DataMember(Name="updatedToken", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updatedToken")]
    public string UpdatedToken { get; set; }

    /// <summary>
    /// New account number expiration date in MMYY format.
    /// </summary>
    /// <value>New account number expiration date in MMYY format.</value>
    [DataMember(Name="updatedExpirationDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updatedExpirationDate")]
    public string UpdatedExpirationDate { get; set; }

    /// <summary>
    /// Status of the updated account. An account may have closed (C), the expiry date may have changed (E), the account may have changed (A), or the cardholder should be contacted (Q).
    /// </summary>
    /// <value>Status of the updated account. An account may have closed (C), the expiry date may have changed (E), the account may have changed (A), or the cardholder should be contacted (Q).</value>
    [DataMember(Name="updatedAccountStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updatedAccountStatus")]
    public string UpdatedAccountStatus { get; set; }

    /// <summary>
    /// Code for the error encountered when updating account.
    /// </summary>
    /// <value>Code for the error encountered when updating account.</value>
    [DataMember(Name="updatedAccountErrorCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updatedAccountErrorCode")]
    public string UpdatedAccountErrorCode { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AccountUpdaterResponse {\n");
      sb.Append("  UpdatedCard: ").Append(UpdatedCard).Append("\n");
      sb.Append("  UpdatedToken: ").Append(UpdatedToken).Append("\n");
      sb.Append("  UpdatedExpirationDate: ").Append(UpdatedExpirationDate).Append("\n");
      sb.Append("  UpdatedAccountStatus: ").Append(UpdatedAccountStatus).Append("\n");
      sb.Append("  UpdatedAccountErrorCode: ").Append(UpdatedAccountErrorCode).Append("\n");
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
