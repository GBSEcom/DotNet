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
  public class PrimaryTransactionAdditionalDetails {
    /// <summary>
    /// For FORCED_TICKET only. Stores the six digit reference number you have received as the result of a successful external authorization (e.g. by phone). The Gateway needs this number for uniquely mapping a ForcedTicket transaction to a previously performed external authorization.] 
    /// </summary>
    /// <value>For FORCED_TICKET only. Stores the six digit reference number you have received as the result of a successful external authorization (e.g. by phone). The Gateway needs this number for uniquely mapping a ForcedTicket transaction to a previously performed external authorization.] </value>
    [DataMember(Name="referenceNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "referenceNumber")]
    public string ReferenceNumber { get; set; }

    /// <summary>
    /// Gets or Sets Comments
    /// </summary>
    [DataMember(Name="comments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "comments")]
    public string Comments { get; set; }

    /// <summary>
    /// Gets or Sets DynamicMerchantName
    /// </summary>
    [DataMember(Name="dynamicMerchantName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dynamicMerchantName")]
    public string DynamicMerchantName { get; set; }

    /// <summary>
    /// Gets or Sets InvoiceNumber
    /// </summary>
    [DataMember(Name="invoiceNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoiceNumber")]
    public string InvoiceNumber { get; set; }

    /// <summary>
    /// Gets or Sets PurchaseOrderNumber
    /// </summary>
    [DataMember(Name="purchaseOrderNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "purchaseOrderNumber")]
    public string PurchaseOrderNumber { get; set; }

    /// <summary>
    /// Valid values are 'FIRST', 'REPEAT' and 'STANDING_INSTRUCTION'.
    /// </summary>
    /// <value>Valid values are 'FIRST', 'REPEAT' and 'STANDING_INSTRUCTION'.</value>
    [DataMember(Name="recurringType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recurringType")]
    public string RecurringType { get; set; }

    /// <summary>
    /// Gets or Sets InstallmentOptions
    /// </summary>
    [DataMember(Name="installmentOptions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "installmentOptions")]
    public InstallmentOptions InstallmentOptions { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PrimaryTransactionAdditionalDetails {\n");
      sb.Append("  ReferenceNumber: ").Append(ReferenceNumber).Append("\n");
      sb.Append("  Comments: ").Append(Comments).Append("\n");
      sb.Append("  DynamicMerchantName: ").Append(DynamicMerchantName).Append("\n");
      sb.Append("  InvoiceNumber: ").Append(InvoiceNumber).Append("\n");
      sb.Append("  PurchaseOrderNumber: ").Append(PurchaseOrderNumber).Append("\n");
      sb.Append("  RecurringType: ").Append(RecurringType).Append("\n");
      sb.Append("  InstallmentOptions: ").Append(InstallmentOptions).Append("\n");
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
