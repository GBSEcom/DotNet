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
  public class PurchaseCardsLevel2 {
    /// <summary>
    /// Customer Code/Customer Reference ID
    /// </summary>
    /// <value>Customer Code/Customer Reference ID</value>
    [DataMember(Name="customerReferenceID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customerReferenceID")]
    public string CustomerReferenceID { get; set; }

    /// <summary>
    /// Purchase Identifier/Merchant related data
    /// </summary>
    /// <value>Purchase Identifier/Merchant related data</value>
    [DataMember(Name="supplierInvoiceNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "supplierInvoiceNumber")]
    public string SupplierInvoiceNumber { get; set; }

    /// <summary>
    /// Merchant VAT registration/Single Business Reference Number/Merchant Tax ID or Corporation VAT Number
    /// </summary>
    /// <value>Merchant VAT registration/Single Business Reference Number/Merchant Tax ID or Corporation VAT Number</value>
    [DataMember(Name="supplierVATRegistrationNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "supplierVATRegistrationNumber")]
    public string SupplierVATRegistrationNumber { get; set; }

    /// <summary>
    /// Gets or Sets TotalDiscountAmountAndRate
    /// </summary>
    [DataMember(Name="totalDiscountAmountAndRate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "totalDiscountAmountAndRate")]
    public AdditionalAmountRate TotalDiscountAmountAndRate { get; set; }

    /// <summary>
    /// Gets or Sets VatShippingAmountAndRate
    /// </summary>
    [DataMember(Name="vatShippingAmountAndRate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vatShippingAmountAndRate")]
    public AdditionalAmountRate VatShippingAmountAndRate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PurchaseCardsLevel2 {\n");
      sb.Append("  CustomerReferenceID: ").Append(CustomerReferenceID).Append("\n");
      sb.Append("  SupplierInvoiceNumber: ").Append(SupplierInvoiceNumber).Append("\n");
      sb.Append("  SupplierVATRegistrationNumber: ").Append(SupplierVATRegistrationNumber).Append("\n");
      sb.Append("  TotalDiscountAmountAndRate: ").Append(TotalDiscountAmountAndRate).Append("\n");
      sb.Append("  VatShippingAmountAndRate: ").Append(VatShippingAmountAndRate).Append("\n");
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
