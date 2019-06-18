using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Use this model to provide order related details.
  /// </summary>
  [DataContract]
  public class Order {
    /// <summary>
    /// Client Order ID if supplied by client.
    /// </summary>
    /// <value>Client Order ID if supplied by client.</value>
    [DataMember(Name="orderId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "orderId")]
    public string OrderId { get; set; }

    /// <summary>
    /// Gets or Sets Billing
    /// </summary>
    [DataMember(Name="billing", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "billing")]
    public Billing Billing { get; set; }

    /// <summary>
    /// Gets or Sets Shipping
    /// </summary>
    [DataMember(Name="shipping", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shipping")]
    public Shipping Shipping { get; set; }

    /// <summary>
    /// Gets or Sets IndustrySpecificExtensions
    /// </summary>
    [DataMember(Name="industrySpecificExtensions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "industrySpecificExtensions")]
    public IndustrySpecificExtensions IndustrySpecificExtensions { get; set; }

    /// <summary>
    /// Gets or Sets PurchaseCard
    /// </summary>
    [DataMember(Name="purchaseCard", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "purchaseCard")]
    public PurchaseCards PurchaseCard { get; set; }

    /// <summary>
    /// Gets or Sets InstallmentOptions
    /// </summary>
    [DataMember(Name="installmentOptions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "installmentOptions")]
    public InstallmentOptions InstallmentOptions { get; set; }

    /// <summary>
    /// Gets or Sets SoftDescriptor
    /// </summary>
    [DataMember(Name="softDescriptor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "softDescriptor")]
    public SoftDescriptor SoftDescriptor { get; set; }

    /// <summary>
    /// Gets or Sets AdditionalDetails
    /// </summary>
    [DataMember(Name="additionalDetails", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "additionalDetails")]
    public AdditionalDetails AdditionalDetails { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Order {\n");
      sb.Append("  OrderId: ").Append(OrderId).Append("\n");
      sb.Append("  Billing: ").Append(Billing).Append("\n");
      sb.Append("  Shipping: ").Append(Shipping).Append("\n");
      sb.Append("  IndustrySpecificExtensions: ").Append(IndustrySpecificExtensions).Append("\n");
      sb.Append("  PurchaseCard: ").Append(PurchaseCard).Append("\n");
      sb.Append("  InstallmentOptions: ").Append(InstallmentOptions).Append("\n");
      sb.Append("  SoftDescriptor: ").Append(SoftDescriptor).Append("\n");
      sb.Append("  AdditionalDetails: ").Append(AdditionalDetails).Append("\n");
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
