using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class PurchaseCardsLevel3LineItems {
    /// <summary>
    /// The commodity code used to classify the item purchased, positive numeric
    /// </summary>
    /// <value>The commodity code used to classify the item purchased, positive numeric</value>
    [DataMember(Name="commodityCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "commodityCode")]
    public string CommodityCode { get; set; }

    /// <summary>
    /// Merchant product identifier/The Universal Product Code (UPC) of the item purchased
    /// </summary>
    /// <value>Merchant product identifier/The Universal Product Code (UPC) of the item purchased</value>
    [DataMember(Name="productCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "productCode")]
    public string ProductCode { get; set; }

    /// <summary>
    /// The description
    /// </summary>
    /// <value>The description</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// The quantity
    /// </summary>
    /// <value>The quantity</value>
    [DataMember(Name="quantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quantity")]
    public int? Quantity { get; set; }

    /// <summary>
    /// The unit of measure
    /// </summary>
    /// <value>The unit of measure</value>
    [DataMember(Name="unitMeasure", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unitMeasure")]
    public string UnitMeasure { get; set; }

    /// <summary>
    /// Rate amount in 3 decimal 12 bytes total digit
    /// </summary>
    /// <value>Rate amount in 3 decimal 12 bytes total digit</value>
    [DataMember(Name="unitPrice", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unitPrice")]
    public decimal? UnitPrice { get; set; }

    /// <summary>
    /// Gets or Sets VatAmontAndRate
    /// </summary>
    [DataMember(Name="vatAmontAndRate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vatAmontAndRate")]
    public AdditionalAmountRate VatAmontAndRate { get; set; }

    /// <summary>
    /// Gets or Sets DiscountAmountAndRate
    /// </summary>
    [DataMember(Name="discountAmountAndRate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "discountAmountAndRate")]
    public AdditionalAmountRate DiscountAmountAndRate { get; set; }

    /// <summary>
    /// Rate amount in 3 decimal 12 bytes total digit
    /// </summary>
    /// <value>Rate amount in 3 decimal 12 bytes total digit</value>
    [DataMember(Name="lineItemTotal", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lineItemTotal")]
    public decimal? LineItemTotal { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PurchaseCardsLevel3LineItems {\n");
      sb.Append("  CommodityCode: ").Append(CommodityCode).Append("\n");
      sb.Append("  ProductCode: ").Append(ProductCode).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Quantity: ").Append(Quantity).Append("\n");
      sb.Append("  UnitMeasure: ").Append(UnitMeasure).Append("\n");
      sb.Append("  UnitPrice: ").Append(UnitPrice).Append("\n");
      sb.Append("  VatAmontAndRate: ").Append(VatAmontAndRate).Append("\n");
      sb.Append("  DiscountAmountAndRate: ").Append(DiscountAmountAndRate).Append("\n");
      sb.Append("  LineItemTotal: ").Append(LineItemTotal).Append("\n");
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
