using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Currency conversion. Abstract class, do not use this class directly, use one of its children: Dcc, DynamicPricing.
  /// </summary>
  [DataContract]
  public class CurrencyConversion {
    /// <summary>
    /// Type of currency conversion.
    /// </summary>
    /// <value>Type of currency conversion.</value>
    [DataMember(Name="conversionType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "conversionType")]
    public string ConversionType { get; set; }

    /// <summary>
    /// Inquiry rate id.
    /// </summary>
    /// <value>Inquiry rate id.</value>
    [DataMember(Name="inquiryRateId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "inquiryRateId")]
    public string InquiryRateId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CurrencyConversion {\n");
      sb.Append("  ConversionType: ").Append(ConversionType).Append("\n");
      sb.Append("  InquiryRateId: ").Append(InquiryRateId).Append("\n");
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
