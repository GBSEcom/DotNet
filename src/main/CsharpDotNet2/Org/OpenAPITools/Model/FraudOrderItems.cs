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
  public class FraudOrderItems {
    /// <summary>
    /// A unique ID associated with the product. Must be unique within the merchant's system.
    /// </summary>
    /// <value>A unique ID associated with the product. Must be unique within the merchant's system.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// A name or short description of the product.
    /// </summary>
    /// <value>A name or short description of the product.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The unit in which the product is sold (e.g. litre, kilogram, etc). Leave empty if the product is sold as a complete unit.
    /// </summary>
    /// <value>The unit in which the product is sold (e.g. litre, kilogram, etc). Leave empty if the product is sold as a complete unit.</value>
    [DataMember(Name="quantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quantity")]
    public string Quantity { get; set; }

    /// <summary>
    /// The number of units sold. Set to 1 if there is only one unit of the item. Leave empty if the quantity is unknown at the time of the request.
    /// </summary>
    /// <value>The number of units sold. Set to 1 if there is only one unit of the item. Leave empty if the quantity is unknown at the time of the request.</value>
    [DataMember(Name="unit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unit")]
    public decimal? Unit { get; set; }

    /// <summary>
    /// The price per unit.
    /// </summary>
    /// <value>The price per unit.</value>
    [DataMember(Name="unitPrice", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unitPrice")]
    public string UnitPrice { get; set; }

    /// <summary>
    /// The categories that this product belongs to.
    /// </summary>
    /// <value>The categories that this product belongs to.</value>
    [DataMember(Name="categories", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "categories")]
    public string Categories { get; set; }

    /// <summary>
    /// The URL to the merchant's management system, for reporting and analysis.
    /// </summary>
    /// <value>The URL to the merchant's management system, for reporting and analysis.</value>
    [DataMember(Name="detailsUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "detailsUrl")]
    public string DetailsUrl { get; set; }

    /// <summary>
    /// Gets or Sets UserDefined
    /// </summary>
    [DataMember(Name="userDefined", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userDefined")]
    public Object UserDefined { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FraudOrderItems {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Quantity: ").Append(Quantity).Append("\n");
      sb.Append("  Unit: ").Append(Unit).Append("\n");
      sb.Append("  UnitPrice: ").Append(UnitPrice).Append("\n");
      sb.Append("  Categories: ").Append(Categories).Append("\n");
      sb.Append("  DetailsUrl: ").Append(DetailsUrl).Append("\n");
      sb.Append("  UserDefined: ").Append(UserDefined).Append("\n");
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
