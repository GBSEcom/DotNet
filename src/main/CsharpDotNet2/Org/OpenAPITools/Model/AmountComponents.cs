using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Transaction amounts with multiple components.
  /// </summary>
  [DataContract]
  public class AmountComponents {
    /// <summary>
    /// Subtotal amount.
    /// </summary>
    /// <value>Subtotal amount.</value>
    [DataMember(Name="subtotal", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subtotal")]
    public decimal? Subtotal { get; set; }

    /// <summary>
    /// Value-added tax amount.
    /// </summary>
    /// <value>Value-added tax amount.</value>
    [DataMember(Name="vatAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vatAmount")]
    public decimal? VatAmount { get; set; }

    /// <summary>
    /// Local tax amount.
    /// </summary>
    /// <value>Local tax amount.</value>
    [DataMember(Name="localTax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "localTax")]
    public decimal? LocalTax { get; set; }

    /// <summary>
    /// Shipping amount.
    /// </summary>
    /// <value>Shipping amount.</value>
    [DataMember(Name="shipping", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shipping")]
    public decimal? Shipping { get; set; }

    /// <summary>
    /// Cashback amount.
    /// </summary>
    /// <value>Cashback amount.</value>
    [DataMember(Name="cashback", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cashback")]
    public decimal? Cashback { get; set; }

    /// <summary>
    /// Tip amount.
    /// </summary>
    /// <value>Tip amount.</value>
    [DataMember(Name="tip", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tip")]
    public decimal? Tip { get; set; }


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
