using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Indicates that the total sum payable is divided for payment at successive fixed times.
  /// </summary>
  [DataContract]
  public class InstallmentOptions {
    /// <summary>
    /// Number of installments for a sale transaction if the customer pays the total amount in multiple transactions.
    /// </summary>
    /// <value>Number of installments for a sale transaction if the customer pays the total amount in multiple transactions.</value>
    [DataMember(Name="numberOfInstallments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "numberOfInstallments")]
    public int? NumberOfInstallments { get; set; }

    /// <summary>
    /// Indicates whether the installment interest amount has been applied.
    /// </summary>
    /// <value>Indicates whether the installment interest amount has been applied.</value>
    [DataMember(Name="installmentsInterest", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "installmentsInterest")]
    public bool? InstallmentsInterest { get; set; }

    /// <summary>
    /// The number of months the first installment payment will be delayed.
    /// </summary>
    /// <value>The number of months the first installment payment will be delayed.</value>
    [DataMember(Name="installmentDelayMonths", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "installmentDelayMonths")]
    public int? InstallmentDelayMonths { get; set; }

    /// <summary>
    /// The type of recurring payment.
    /// </summary>
    /// <value>The type of recurring payment.</value>
    [DataMember(Name="recurringType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recurringType")]
    public string RecurringType { get; set; }

    /// <summary>
    /// Indicates if the merchant supports merchant advice code (MAC) in order to receive table 55 code for a declined recurring transaction.
    /// </summary>
    /// <value>Indicates if the merchant supports merchant advice code (MAC) in order to receive table 55 code for a declined recurring transaction.</value>
    [DataMember(Name="merchantAdviceCodeSupported", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "merchantAdviceCodeSupported")]
    public bool? MerchantAdviceCodeSupported { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class InstallmentOptions {\n");
      sb.Append("  NumberOfInstallments: ").Append(NumberOfInstallments).Append("\n");
      sb.Append("  InstallmentsInterest: ").Append(InstallmentsInterest).Append("\n");
      sb.Append("  InstallmentDelayMonths: ").Append(InstallmentDelayMonths).Append("\n");
      sb.Append("  RecurringType: ").Append(RecurringType).Append("\n");
      sb.Append("  MerchantAdviceCodeSupported: ").Append(MerchantAdviceCodeSupported).Append("\n");
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
