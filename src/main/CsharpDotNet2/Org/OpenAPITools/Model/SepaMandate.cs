using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Model for the SEPA Mandate information
  /// </summary>
  [DataContract]
  public class SepaMandate {
    /// <summary>
    /// Existing mandate reference, managed by merchant. Must match [A-Za-z0-9:?/+(),. -]{1,35} and not start with two slashes (\"//\"). Also known as the Mandate ID
    /// </summary>
    /// <value>Existing mandate reference, managed by merchant. Must match [A-Za-z0-9:?/+(),. -]{1,35} and not start with two slashes (\"//\"). Also known as the Mandate ID</value>
    [DataMember(Name="reference", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reference")]
    public string Reference { get; set; }

    /// <summary>
    /// Valid URL pointing to the SEPA mandate (PDF / HTML format recommended)
    /// </summary>
    /// <value>Valid URL pointing to the SEPA mandate (PDF / HTML format recommended)</value>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    /// <summary>
    /// Date of mandate signature.
    /// </summary>
    /// <value>Date of mandate signature.</value>
    [DataMember(Name="signatureDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "signatureDate")]
    public DateTime? SignatureDate { get; set; }

    /// <summary>
    /// Sequence type of the direct debit. This defaults to 'SINGLE' if not provided.
    /// </summary>
    /// <value>Sequence type of the direct debit. This defaults to 'SINGLE' if not provided.</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SepaMandate {\n");
      sb.Append("  Reference: ").Append(Reference).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  SignatureDate: ").Append(SignatureDate).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
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
