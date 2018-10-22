using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class AmountComponents {
    /// <summary>
    /// Gets or Sets Subtotal
    /// </summary>
    [DataMember(Name="subtotal", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subtotal")]
    public decimal? Subtotal { get; set; }

    /// <summary>
    /// Gets or Sets VatAmount
    /// </summary>
    [DataMember(Name="vatAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vatAmount")]
    public decimal? VatAmount { get; set; }

    /// <summary>
    /// Gets or Sets LocalTax
    /// </summary>
    [DataMember(Name="localTax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "localTax")]
    public decimal? LocalTax { get; set; }

    /// <summary>
    /// Gets or Sets Shipping
    /// </summary>
    [DataMember(Name="shipping", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shipping")]
    public decimal? Shipping { get; set; }

    /// <summary>
    /// Gets or Sets Cashback
    /// </summary>
    [DataMember(Name="cashback", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cashback")]
    public decimal? Cashback { get; set; }

    /// <summary>
    /// Gets or Sets Tip
    /// </summary>
    [DataMember(Name="tip", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tip")]
    public decimal? Tip { get; set; }

    /// <summary>
    /// Gets or Sets ConvenienceFee
    /// </summary>
    [DataMember(Name="convenienceFee", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "convenienceFee")]
    public decimal? ConvenienceFee { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AmountComponents {\n");
      sb.Append("  Subtotal: ").Append(Subtotal).Append("\n");
      sb.Append("  VatAmount: ").Append(VatAmount).Append("\n");
      sb.Append("  LocalTax: ").Append(LocalTax).Append("\n");
      sb.Append("  Shipping: ").Append(Shipping).Append("\n");
      sb.Append("  Cashback: ").Append(Cashback).Append("\n");
      sb.Append("  Tip: ").Append(Tip).Append("\n");
      sb.Append("  ConvenienceFee: ").Append(ConvenienceFee).Append("\n");
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
