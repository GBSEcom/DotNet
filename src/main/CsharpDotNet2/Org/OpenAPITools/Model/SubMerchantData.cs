using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Once sub-merchant element is given, the transaction is considered to be a sub-merchant transaction.
  /// </summary>
  [DataContract]
  public class SubMerchantData {
    /// <summary>
    /// Merchant category code.
    /// </summary>
    /// <value>Merchant category code.</value>
    [DataMember(Name="mcc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mcc")]
    public string Mcc { get; set; }

    /// <summary>
    /// Store legal name.
    /// </summary>
    /// <value>Store legal name.</value>
    [DataMember(Name="legalName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "legalName")]
    public string LegalName { get; set; }

    /// <summary>
    /// Timezone.
    /// </summary>
    /// <value>Timezone.</value>
    [DataMember(Name="timezone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "timezone")]
    public string Timezone { get; set; }

    /// <summary>
    /// Gets or Sets Address
    /// </summary>
    [DataMember(Name="address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address")]
    public Address Address { get; set; }

    /// <summary>
    /// Gets or Sets Document
    /// </summary>
    [DataMember(Name="document", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "document")]
    public Document Document { get; set; }

    /// <summary>
    /// Sub-merchant ID.
    /// </summary>
    /// <value>Sub-merchant ID.</value>
    [DataMember(Name="merchantId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "merchantId")]
    public string MerchantId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SubMerchantData {\n");
      sb.Append("  Mcc: ").Append(Mcc).Append("\n");
      sb.Append("  LegalName: ").Append(LegalName).Append("\n");
      sb.Append("  Timezone: ").Append(Timezone).Append("\n");
      sb.Append("  Address: ").Append(Address).Append("\n");
      sb.Append("  Document: ").Append(Document).Append("\n");
      sb.Append("  MerchantId: ").Append(MerchantId).Append("\n");
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
