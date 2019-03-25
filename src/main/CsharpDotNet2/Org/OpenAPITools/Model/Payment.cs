using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Payment information for the transaction.
  /// </summary>
  [DataContract]
  public class Payment {
    /// <summary>
    /// Defines the type of the payment.
    /// </summary>
    /// <value>Defines the type of the payment.</value>
    [DataMember(Name="paymentType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paymentType")]
    public string PaymentType { get; set; }

    /// <summary>
    /// Gets or Sets Method
    /// </summary>
    [DataMember(Name = "payMethod", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "method")]
    public PaymentPayMethod PayMethod { get; set; }

    /// <summary>
    /// Indicates if the cards Personal Identification Number was supplied.
    /// </summary>
    /// <value>Indicates if the cards Personal Identification Number was supplied.</value>
    [DataMember(Name="pinPresent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pinPresent")]
    public bool? PinPresent { get; set; }

    /// <summary>
    /// The method in which the card information entered the system.
    /// </summary>
    /// <value>The method in which the card information entered the system.</value>
    [DataMember(Name="entryMethod", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "entryMethod")]
    public string EntryMethod { get; set; }

    /// <summary>
    /// Gets or Sets IssuerResponse
    /// </summary>
    [DataMember(Name="issuerResponse", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "issuerResponse")]
    public PaymentIssuerResponse IssuerResponse { get; set; }

    /// <summary>
    /// The actual approved amount. This field should be filled in when the message has already passed through the issuer (e.g. post-authorization). For transaction/authorization this amount refers to the amount that was locked on the card-holders account.
    /// </summary>
    /// <value>The actual approved amount. This field should be filled in when the message has already passed through the issuer (e.g. post-authorization). For transaction/authorization this amount refers to the amount that was locked on the card-holders account.</value>
    [DataMember(Name="issuerApprovedAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "issuerApprovedAmount")]
    public string IssuerApprovedAmount { get; set; }

    /// <summary>
    /// The payment methods account balance if available. This field should be filled in when the message has already passed through the issuer (e.g. post-authorization).
    /// </summary>
    /// <value>The payment methods account balance if available. This field should be filled in when the message has already passed through the issuer (e.g. post-authorization).</value>
    [DataMember(Name="issuerCardBalance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "issuerCardBalance")]
    public string IssuerCardBalance { get; set; }

    /// <summary>
    /// Gets or Sets VerificationAvs
    /// </summary>
    [DataMember(Name="verificationAvs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "verificationAvs")]
    public PaymentVerificationAvs VerificationAvs { get; set; }

    /// <summary>
    /// Gets or Sets Verification3ds
    /// </summary>
    [DataMember(Name="verification3ds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "verification3ds")]
    public PaymentVerification3ds Verification3ds { get; set; }

    /// <summary>
    /// Gets or Sets VerificationCvv
    /// </summary>
    [DataMember(Name="verificationCvv", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "verificationCvv")]
    public PaymentVerificationCvv VerificationCvv { get; set; }

    /// <summary>
    /// A JSON object that carries any additional information that might be helpful for fraud detection.
    /// </summary>
    /// <value>A JSON object that carries any additional information that might be helpful for fraud detection.</value>
    [DataMember(Name="userDefined", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userDefined")]
    public Object UserDefined { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Payment {\n");
      sb.Append("  PaymentType: ").Append(PaymentType).Append("\n");
      sb.Append("  Method: ").Append(PayMethod).Append("\n");
      sb.Append("  PinPresent: ").Append(PinPresent).Append("\n");
      sb.Append("  EntryMethod: ").Append(EntryMethod).Append("\n");
      sb.Append("  IssuerResponse: ").Append(IssuerResponse).Append("\n");
      sb.Append("  IssuerApprovedAmount: ").Append(IssuerApprovedAmount).Append("\n");
      sb.Append("  IssuerCardBalance: ").Append(IssuerCardBalance).Append("\n");
      sb.Append("  VerificationAvs: ").Append(VerificationAvs).Append("\n");
      sb.Append("  Verification3ds: ").Append(Verification3ds).Append("\n");
      sb.Append("  VerificationCvv: ").Append(VerificationCvv).Append("\n");
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
