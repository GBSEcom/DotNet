using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Card information.
  /// </summary>
  [DataContract]
  public class CardInfo {
    /// <summary>
    /// The card brand.
    /// </summary>
    /// <value>The card brand.</value>
    [DataMember(Name="brand", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "brand")]
    public string Brand { get; set; }

    /// <summary>
    /// The product ID of the brand.
    /// </summary>
    /// <value>The product ID of the brand.</value>
    [DataMember(Name="brandProductId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "brandProductId")]
    public string BrandProductId { get; set; }

    /// <summary>
    /// The functions of the card. Possible values are credit, debit, prepaid, voucher and undefined.
    /// </summary>
    /// <value>The functions of the card. Possible values are credit, debit, prepaid, voucher and undefined.</value>
    [DataMember(Name="cardFunction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cardFunction")]
    public string CardFunction { get; set; }

    /// <summary>
    /// Indicates whether it is a corporate or non corporate card
    /// </summary>
    /// <value>Indicates whether it is a corporate or non corporate card</value>
    [DataMember(Name="commercialCard", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "commercialCard")]
    public string CommercialCard { get; set; }

    /// <summary>
    /// The country of the issuer.
    /// </summary>
    /// <value>The country of the issuer.</value>
    [DataMember(Name="issuerCountry", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "issuerCountry")]
    public string IssuerCountry { get; set; }

    /// <summary>
    /// The name of the issuer.
    /// </summary>
    /// <value>The name of the issuer.</value>
    [DataMember(Name="issuerName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "issuerName")]
    public string IssuerName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CardInfo {\n");
      sb.Append("  Brand: ").Append(Brand).Append("\n");
      sb.Append("  BrandProductId: ").Append(BrandProductId).Append("\n");
      sb.Append("  CardFunction: ").Append(CardFunction).Append("\n");
      sb.Append("  CommercialCard: ").Append(CommercialCard).Append("\n");
      sb.Append("  IssuerCountry: ").Append(IssuerCountry).Append("\n");
      sb.Append("  IssuerName: ").Append(IssuerName).Append("\n");
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
