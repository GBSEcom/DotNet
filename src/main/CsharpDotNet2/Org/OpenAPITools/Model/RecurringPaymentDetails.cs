using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Details about existing gateway schedule.
  /// </summary>
  [DataContract]
  public class RecurringPaymentDetails {
    /// <summary>
    /// Store ID number.
    /// </summary>
    /// <value>Store ID number.</value>
    [DataMember(Name="storeId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "storeId")]
    public string StoreId { get; set; }

    /// <summary>
    /// Purchase order number.
    /// </summary>
    /// <value>Purchase order number.</value>
    [DataMember(Name="purchaseOrderNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "purchaseOrderNumber")]
    public string PurchaseOrderNumber { get; set; }

    /// <summary>
    /// Invoice number.
    /// </summary>
    /// <value>Invoice number.</value>
    [DataMember(Name="invoiceNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoiceNumber")]
    public string InvoiceNumber { get; set; }

    /// <summary>
    /// Date recurring payment was created.
    /// </summary>
    /// <value>Date recurring payment was created.</value>
    [DataMember(Name="creationDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "creationDate")]
    public string CreationDate { get; set; }

    /// <summary>
    /// Date of mandate signature.
    /// </summary>
    /// <value>Date of mandate signature.</value>
    [DataMember(Name="startDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "startDate")]
    public string StartDate { get; set; }

    /// <summary>
    /// Date of next transaction process attempt.
    /// </summary>
    /// <value>Date of next transaction process attempt.</value>
    [DataMember(Name="nextAttemptDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nextAttemptDate")]
    public string NextAttemptDate { get; set; }

    /// <summary>
    /// Gets or Sets Amount
    /// </summary>
    [DataMember(Name="amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amount")]
    public Amount Amount { get; set; }

    /// <summary>
    /// Gets or Sets PaymentMethod
    /// </summary>
    [DataMember(Name="paymentMethod", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paymentMethod")]
    public PaymentMethod PaymentMethod { get; set; }

    /// <summary>
    /// Gets or Sets Frequency
    /// </summary>
    [DataMember(Name="frequency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "frequency")]
    public Frequency Frequency { get; set; }

    /// <summary>
    /// Number of times the recurring payment will process.
    /// </summary>
    /// <value>Number of times the recurring payment will process.</value>
    [DataMember(Name="numberOfPayments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "numberOfPayments")]
    public int? NumberOfPayments { get; set; }

    /// <summary>
    /// Times the recurring payment has already run.
    /// </summary>
    /// <value>Times the recurring payment has already run.</value>
    [DataMember(Name="runCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "runCount")]
    public int? RunCount { get; set; }

    /// <summary>
    /// State of the recurring payment.
    /// </summary>
    /// <value>State of the recurring payment.</value>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public string State { get; set; }

    /// <summary>
    /// User supplied comments.
    /// </summary>
    /// <value>User supplied comments.</value>
    [DataMember(Name="comments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "comments")]
    public string Comments { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RecurringPaymentDetails {\n");
      sb.Append("  StoreId: ").Append(StoreId).Append("\n");
      sb.Append("  PurchaseOrderNumber: ").Append(PurchaseOrderNumber).Append("\n");
      sb.Append("  InvoiceNumber: ").Append(InvoiceNumber).Append("\n");
      sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
      sb.Append("  StartDate: ").Append(StartDate).Append("\n");
      sb.Append("  NextAttemptDate: ").Append(NextAttemptDate).Append("\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
      sb.Append("  Frequency: ").Append(Frequency).Append("\n");
      sb.Append("  NumberOfPayments: ").Append(NumberOfPayments).Append("\n");
      sb.Append("  RunCount: ").Append(RunCount).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  Comments: ").Append(Comments).Append("\n");
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
