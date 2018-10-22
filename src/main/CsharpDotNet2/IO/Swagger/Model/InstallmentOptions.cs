using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Indicates that the total sum payable is divided for payment at successive fixed times.
  /// </summary>
  [DataContract]
  public class InstallmentOptions {
    /// <summary>
    /// Number of installments for a Sale transaction if the customer pays the total amount in multiple transactions
    /// </summary>
    /// <value>Number of installments for a Sale transaction if the customer pays the total amount in multiple transactions</value>
    [DataMember(Name="numberOfInstallments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "numberOfInstallments")]
    public int? NumberOfInstallments { get; set; }

    /// <summary>
    /// Indicates whether the installment interest amount has been applied. Possible values are \"yes\" or \"no\".
    /// </summary>
    /// <value>Indicates whether the installment interest amount has been applied. Possible values are \"yes\" or \"no\".</value>
    [DataMember(Name="installmentsInterest", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "installmentsInterest")]
    public bool? InstallmentsInterest { get; set; }

    /// <summary>
    /// The number of months the first installment payment will be delayed
    /// </summary>
    /// <value>The number of months the first installment payment will be delayed</value>
    [DataMember(Name="installmentDelayMonths", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "installmentDelayMonths")]
    public int? InstallmentDelayMonths { get; set; }


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
