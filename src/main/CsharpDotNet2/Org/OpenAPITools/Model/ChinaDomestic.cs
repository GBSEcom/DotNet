using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// The payment object for China-domestic transactions. Use this to populate all china domestic payment method details.
  /// </summary>
  [DataContract]
  public class ChinaDomestic {
    /// <summary>
    /// Use this to indicate the product code according to the product category list.
    /// </summary>
    /// <value>Use this to indicate the product code according to the product category list.</value>
    [DataMember(Name="productCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "productCode")]
    public string ProductCode { get; set; }

    /// <summary>
    /// The quantity.
    /// </summary>
    /// <value>The quantity.</value>
    [DataMember(Name="productQuantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "productQuantity")]
    public int? ProductQuantity { get; set; }

    /// <summary>
    /// Rate amount in 3 decimal 12 bytes total digit.
    /// </summary>
    /// <value>Rate amount in 3 decimal 12 bytes total digit.</value>
    [DataMember(Name="productPrice", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "productPrice")]
    public decimal? ProductPrice { get; set; }

    /// <summary>
    /// The product description.
    /// </summary>
    /// <value>The product description.</value>
    [DataMember(Name="productDescription", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "productDescription")]
    public string ProductDescription { get; set; }

    /// <summary>
    /// Use this to indicate the product code according to the product category list.
    /// </summary>
    /// <value>Use this to indicate the product code according to the product category list.</value>
    [DataMember(Name="redirectURL", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "redirectURL")]
    public string RedirectURL { get; set; }

    /// <summary>
    /// Use this to limit card functions to debit cards.
    /// </summary>
    /// <value>Use this to limit card functions to debit cards.</value>
    [DataMember(Name="limitCardFunctionToDebit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "limitCardFunctionToDebit")]
    public bool? LimitCardFunctionToDebit { get; set; }

    /// <summary>
    /// Use this to indicate the CUP customer ID if known.
    /// </summary>
    /// <value>Use this to indicate the CUP customer ID if known.</value>
    [DataMember(Name="customerId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customerId")]
    public string CustomerId { get; set; }

    /// <summary>
    /// Use this to indicate the CUP bank ID if known.
    /// </summary>
    /// <value>Use this to indicate the CUP bank ID if known.</value>
    [DataMember(Name="bankId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bankId")]
    public string BankId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ChinaDomestic {\n");
      sb.Append("  ProductCode: ").Append(ProductCode).Append("\n");
      sb.Append("  ProductQuantity: ").Append(ProductQuantity).Append("\n");
      sb.Append("  ProductPrice: ").Append(ProductPrice).Append("\n");
      sb.Append("  ProductDescription: ").Append(ProductDescription).Append("\n");
      sb.Append("  RedirectURL: ").Append(RedirectURL).Append("\n");
      sb.Append("  LimitCardFunctionToDebit: ").Append(LimitCardFunctionToDebit).Append("\n");
      sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
      sb.Append("  BankId: ").Append(BankId).Append("\n");
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
