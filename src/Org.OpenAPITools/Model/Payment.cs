/* 
 * Payment Gateway API Specification.
 *
 * The documentation here is designed to provide all of the technical guidance required to consume and integrate with our APIs for payment processing. To learn more about our APIs please visit https://docs.firstdata.com/org/gateway.
 *
 * The version of the OpenAPI document: 21.3.0.20210608.001
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Payment information for the transaction.
    /// </summary>
    [DataContract]
    public partial class Payment : IEquatable<Payment>, IValidatableObject
    {
        /// <summary>
        /// Defines the type of the payment.
        /// </summary>
        /// <value>Defines the type of the payment.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PaymentTypeEnum
        {
            /// <summary>
            /// Enum Card for value: payment/card
            /// </summary>
            [EnumMember(Value = "payment/card")]
            Card = 1,

            /// <summary>
            /// Enum Wallet for value: payment/wallet
            /// </summary>
            [EnumMember(Value = "payment/wallet")]
            Wallet = 2

        }

        /// <summary>
        /// Defines the type of the payment.
        /// </summary>
        /// <value>Defines the type of the payment.</value>
        [DataMember(Name = "paymentType", EmitDefaultValue = false)]
        public PaymentTypeEnum PaymentType { get; set; }
        /// <summary>
        /// The method in which the card information entered the system.
        /// </summary>
        /// <value>The method in which the card information entered the system.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EntryMethodEnum
        {
            /// <summary>
            /// Enum Manual for value: manual
            /// </summary>
            [EnumMember(Value = "manual")]
            Manual = 1,

            /// <summary>
            /// Enum Stripe for value: stripe
            /// </summary>
            [EnumMember(Value = "stripe")]
            Stripe = 2,

            /// <summary>
            /// Enum Ocr for value: ocr
            /// </summary>
            [EnumMember(Value = "ocr")]
            Ocr = 3,

            /// <summary>
            /// Enum Emv for value: emv
            /// </summary>
            [EnumMember(Value = "emv")]
            Emv = 4,

            /// <summary>
            /// Enum Nfc for value: nfc
            /// </summary>
            [EnumMember(Value = "nfc")]
            Nfc = 5,

            /// <summary>
            /// Enum Remote for value: remote
            /// </summary>
            [EnumMember(Value = "remote")]
            Remote = 6,

            /// <summary>
            /// Enum Pinpresent for value: pin_present
            /// </summary>
            [EnumMember(Value = "pin_present")]
            Pinpresent = 7

        }

        /// <summary>
        /// The method in which the card information entered the system.
        /// </summary>
        /// <value>The method in which the card information entered the system.</value>
        [DataMember(Name = "entryMethod", EmitDefaultValue = false)]
        public EntryMethodEnum EntryMethod { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Payment" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Payment() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Payment" /> class.
        /// </summary>
        /// <param name="paymentType">Defines the type of the payment. (required).</param>
        /// <param name="method">method (required).</param>
        /// <param name="pinPresent">Indicates if the cards Personal Identification Number was supplied. (required).</param>
        /// <param name="entryMethod">The method in which the card information entered the system. (required).</param>
        /// <param name="issuerResponse">issuerResponse.</param>
        /// <param name="issuerApprovedAmount">The actual approved amount. This field should be filled in when the message has already passed through the issuer (e.g. post-authorization). For transaction/authorization this amount refers to the amount that was locked on the card-holders account..</param>
        /// <param name="issuerCardBalance">The payment methods account balance if available. This field should be filled in when the message has already passed through the issuer (e.g. post-authorization)..</param>
        /// <param name="verificationAvs">verificationAvs.</param>
        /// <param name="verification3ds">verification3ds.</param>
        /// <param name="verificationCvv">verificationCvv.</param>
        /// <param name="userDefined">A JSON object that carries any additional information that might be helpful for fraud detection..</param>
        public Payment(PaymentTypeEnum paymentType = default(PaymentTypeEnum), Method method = default(Method), bool pinPresent = default(bool), EntryMethodEnum entryMethod = default(EntryMethodEnum), IssuerResponse issuerResponse = default(IssuerResponse), string issuerApprovedAmount = default(string), string issuerCardBalance = default(string), VerificationAvs verificationAvs = default(VerificationAvs), Verification3ds verification3ds = default(Verification3ds), VerificationCvv verificationCvv = default(VerificationCvv), Object userDefined = default(Object))
        {
            // to ensure "paymentType" is required (not null)
            this.PaymentType = paymentType;
            // to ensure "method" is required (not null)
            this.Method = method ?? throw new ArgumentNullException("method is a required property for Payment and cannot be null");
            // to ensure "pinPresent" is required (not null)
            this.PinPresent = pinPresent;
            // to ensure "entryMethod" is required (not null)
            this.EntryMethod = entryMethod;
            this.IssuerResponse = issuerResponse;
            this.IssuerApprovedAmount = issuerApprovedAmount;
            this.IssuerCardBalance = issuerCardBalance;
            this.VerificationAvs = verificationAvs;
            this.Verification3ds = verification3ds;
            this.VerificationCvv = verificationCvv;
            this.UserDefined = userDefined;
        }

        /// <summary>
        /// Gets or Sets Method
        /// </summary>
        [DataMember(Name = "method", EmitDefaultValue = false)]
        public Method Method { get; set; }

        /// <summary>
        /// Indicates if the cards Personal Identification Number was supplied.
        /// </summary>
        /// <value>Indicates if the cards Personal Identification Number was supplied.</value>
        [DataMember(Name = "pinPresent", EmitDefaultValue = false)]
        public bool? PinPresent { get; set; }

        /// <summary>
        /// Gets or Sets IssuerResponse
        /// </summary>
        [DataMember(Name = "issuerResponse", EmitDefaultValue = false)]
        public IssuerResponse IssuerResponse { get; set; }

        /// <summary>
        /// The actual approved amount. This field should be filled in when the message has already passed through the issuer (e.g. post-authorization). For transaction/authorization this amount refers to the amount that was locked on the card-holders account.
        /// </summary>
        /// <value>The actual approved amount. This field should be filled in when the message has already passed through the issuer (e.g. post-authorization). For transaction/authorization this amount refers to the amount that was locked on the card-holders account.</value>
        [DataMember(Name = "issuerApprovedAmount", EmitDefaultValue = false)]
        public string IssuerApprovedAmount { get; set; }

        /// <summary>
        /// The payment methods account balance if available. This field should be filled in when the message has already passed through the issuer (e.g. post-authorization).
        /// </summary>
        /// <value>The payment methods account balance if available. This field should be filled in when the message has already passed through the issuer (e.g. post-authorization).</value>
        [DataMember(Name = "issuerCardBalance", EmitDefaultValue = false)]
        public string IssuerCardBalance { get; set; }

        /// <summary>
        /// Gets or Sets VerificationAvs
        /// </summary>
        [DataMember(Name = "verificationAvs", EmitDefaultValue = false)]
        public VerificationAvs VerificationAvs { get; set; }

        /// <summary>
        /// Gets or Sets Verification3ds
        /// </summary>
        [DataMember(Name = "verification3ds", EmitDefaultValue = false)]
        public Verification3ds Verification3ds { get; set; }

        /// <summary>
        /// Gets or Sets VerificationCvv
        /// </summary>
        [DataMember(Name = "verificationCvv", EmitDefaultValue = false)]
        public VerificationCvv VerificationCvv { get; set; }

        /// <summary>
        /// A JSON object that carries any additional information that might be helpful for fraud detection.
        /// </summary>
        /// <value>A JSON object that carries any additional information that might be helpful for fraud detection.</value>
        [DataMember(Name = "userDefined", EmitDefaultValue = false)]
        public Object UserDefined { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Payment {\n");
            sb.Append("  PaymentType: ").Append(PaymentType).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
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
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Payment);
        }

        /// <summary>
        /// Returns true if Payment instances are equal
        /// </summary>
        /// <param name="input">Instance of Payment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Payment input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PaymentType == input.PaymentType ||
                    (this.PaymentType != null &&
                    this.PaymentType.Equals(input.PaymentType))
                ) && 
                (
                    this.Method == input.Method ||
                    (this.Method != null &&
                    this.Method.Equals(input.Method))
                ) && 
                (
                    this.PinPresent == input.PinPresent ||
                    (this.PinPresent != null &&
                    this.PinPresent.Equals(input.PinPresent))
                ) && 
                (
                    this.EntryMethod == input.EntryMethod ||
                    (this.EntryMethod != null &&
                    this.EntryMethod.Equals(input.EntryMethod))
                ) && 
                (
                    this.IssuerResponse == input.IssuerResponse ||
                    (this.IssuerResponse != null &&
                    this.IssuerResponse.Equals(input.IssuerResponse))
                ) && 
                (
                    this.IssuerApprovedAmount == input.IssuerApprovedAmount ||
                    (this.IssuerApprovedAmount != null &&
                    this.IssuerApprovedAmount.Equals(input.IssuerApprovedAmount))
                ) && 
                (
                    this.IssuerCardBalance == input.IssuerCardBalance ||
                    (this.IssuerCardBalance != null &&
                    this.IssuerCardBalance.Equals(input.IssuerCardBalance))
                ) && 
                (
                    this.VerificationAvs == input.VerificationAvs ||
                    (this.VerificationAvs != null &&
                    this.VerificationAvs.Equals(input.VerificationAvs))
                ) && 
                (
                    this.Verification3ds == input.Verification3ds ||
                    (this.Verification3ds != null &&
                    this.Verification3ds.Equals(input.Verification3ds))
                ) && 
                (
                    this.VerificationCvv == input.VerificationCvv ||
                    (this.VerificationCvv != null &&
                    this.VerificationCvv.Equals(input.VerificationCvv))
                ) && 
                (
                    this.UserDefined == input.UserDefined ||
                    (this.UserDefined != null &&
                    this.UserDefined.Equals(input.UserDefined))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.PaymentType != null)
                    hashCode = hashCode * 59 + this.PaymentType.GetHashCode();
                if (this.Method != null)
                    hashCode = hashCode * 59 + this.Method.GetHashCode();
                if (this.PinPresent != null)
                    hashCode = hashCode * 59 + this.PinPresent.GetHashCode();
                if (this.EntryMethod != null)
                    hashCode = hashCode * 59 + this.EntryMethod.GetHashCode();
                if (this.IssuerResponse != null)
                    hashCode = hashCode * 59 + this.IssuerResponse.GetHashCode();
                if (this.IssuerApprovedAmount != null)
                    hashCode = hashCode * 59 + this.IssuerApprovedAmount.GetHashCode();
                if (this.IssuerCardBalance != null)
                    hashCode = hashCode * 59 + this.IssuerCardBalance.GetHashCode();
                if (this.VerificationAvs != null)
                    hashCode = hashCode * 59 + this.VerificationAvs.GetHashCode();
                if (this.Verification3ds != null)
                    hashCode = hashCode * 59 + this.Verification3ds.GetHashCode();
                if (this.VerificationCvv != null)
                    hashCode = hashCode * 59 + this.VerificationCvv.GetHashCode();
                if (this.UserDefined != null)
                    hashCode = hashCode * 59 + this.UserDefined.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
