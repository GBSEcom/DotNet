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
  public class PrimaryTransactionAdditionalDetails {
    /// <summary>
    /// For FORCED_TICKET only. Stores the six digit reference number you have received as the result of a successful external authorization (e.g. by phone). The Gateway needs this number for uniquely mapping a ForcedTicket transaction to a previously performed external authorization.] 
    /// </summary>
    /// <value>For FORCED_TICKET only. Stores the six digit reference number you have received as the result of a successful external authorization (e.g. by phone). The Gateway needs this number for uniquely mapping a ForcedTicket transaction to a previously performed external authorization.] </value>
    [DataMember(Name="referenceNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "referenceNumber")]
    public string ReferenceNumber { get; set; }

    /// <summary>
    /// Comments for the payment
    /// </summary>
    /// <value>Comments for the payment</value>
    [DataMember(Name="comments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "comments")]
    public string Comments { get; set; }

    /// <summary>
    /// The name of sub-merchant for the payment facilitator
    /// </summary>
    /// <value>The name of sub-merchant for the payment facilitator</value>
    [DataMember(Name="dynamicMerchantName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dynamicMerchantName")]
    public string DynamicMerchantName { get; set; }

    /// <summary>
    /// Invoice number
    /// </summary>
    /// <value>Invoice number</value>
    [DataMember(Name="invoiceNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoiceNumber")]
    public string InvoiceNumber { get; set; }

    /// <summary>
    /// Purchase order number
    /// </summary>
    /// <value>Purchase order number</value>
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
    /// Use this field to override merchant configured MCC value
    /// </summary>
    /// <value>Use this field to override merchant configured MCC value</value>
    [DataMember(Name="mcc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mcc")]
    public string Mcc { get; set; }

    /// <summary>
    /// Gets or Sets Dcc
    /// </summary>
    [DataMember(Name="dcc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dcc")]
    public Dcc Dcc { get; set; }


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
      sb.Append("  Mcc: ").Append(Mcc).Append("\n");
      sb.Append("  Dcc: ").Append(Dcc).Append("\n");
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
