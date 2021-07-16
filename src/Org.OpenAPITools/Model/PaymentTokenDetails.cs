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
    /// Response details for payment token creation.
    /// </summary>
    [DataContract]
    public partial class PaymentTokenDetails : IEquatable<PaymentTokenDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentTokenDetails" /> class.
        /// </summary>
        /// <param name="value">Client-supplied payment token value. Only applicable for DataVault tokenization scheme..</param>
        /// <param name="reusable">If the token is reusable. (default to true).</param>
        /// <param name="declineDuplicates">Decline duplicate payment info if client token is supplied. (default to false).</param>
        /// <param name="last4">The last 4 numbers of a payment card..</param>
        /// <param name="brand">Card brand, only for tokenization with payment..</param>
        /// <param name="accountVerification">If the account the token was created from has been verified..</param>
        /// <param name="type">Inidcates the type of tokenization source..</param>
        public PaymentTokenDetails(string value = default(string), bool reusable = true, bool declineDuplicates = false, string last4 = default(string), string brand = default(string), bool accountVerification = default(bool), string type = default(string))
        {
            this.Value = value;
            // use default value if no "reusable" provided
            this.Reusable = reusable;
            // use default value if no "declineDuplicates" provided
            this.DeclineDuplicates = declineDuplicates;
            this.Last4 = last4;
            this.Brand = brand;
            this.AccountVerification = accountVerification;
            this.Type = type;
        }

        /// <summary>
        /// Client-supplied payment token value. Only applicable for DataVault tokenization scheme.
        /// </summary>
        /// <value>Client-supplied payment token value. Only applicable for DataVault tokenization scheme.</value>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public string Value { get; set; }

        /// <summary>
        /// If the token is reusable.
        /// </summary>
        /// <value>If the token is reusable.</value>
        [DataMember(Name = "reusable", EmitDefaultValue = false)]
        public bool? Reusable { get; set; }

        /// <summary>
        /// Decline duplicate payment info if client token is supplied.
        /// </summary>
        /// <value>Decline duplicate payment info if client token is supplied.</value>
        [DataMember(Name = "declineDuplicates", EmitDefaultValue = false)]
        public bool? DeclineDuplicates { get; set; }

        /// <summary>
        /// The last 4 numbers of a payment card.
        /// </summary>
        /// <value>The last 4 numbers of a payment card.</value>
        [DataMember(Name = "last4", EmitDefaultValue = false)]
        public string Last4 { get; set; }

        /// <summary>
        /// Card brand, only for tokenization with payment.
        /// </summary>
        /// <value>Card brand, only for tokenization with payment.</value>
        [DataMember(Name = "brand", EmitDefaultValue = false)]
        public string Brand { get; set; }

        /// <summary>
        /// If the account the token was created from has been verified.
        /// </summary>
        /// <value>If the account the token was created from has been verified.</value>
        [DataMember(Name = "accountVerification", EmitDefaultValue = false)]
        public bool? AccountVerification { get; set; }

        /// <summary>
        /// Inidcates the type of tokenization source.
        /// </summary>
        /// <value>Inidcates the type of tokenization source.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentTokenDetails {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Reusable: ").Append(Reusable).Append("\n");
            sb.Append("  DeclineDuplicates: ").Append(DeclineDuplicates).Append("\n");
            sb.Append("  Last4: ").Append(Last4).Append("\n");
            sb.Append("  Brand: ").Append(Brand).Append("\n");
            sb.Append("  AccountVerification: ").Append(AccountVerification).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as PaymentTokenDetails);
        }

        /// <summary>
        /// Returns true if PaymentTokenDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentTokenDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentTokenDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.Reusable == input.Reusable ||
                    (this.Reusable != null &&
                    this.Reusable.Equals(input.Reusable))
                ) && 
                (
                    this.DeclineDuplicates == input.DeclineDuplicates ||
                    (this.DeclineDuplicates != null &&
                    this.DeclineDuplicates.Equals(input.DeclineDuplicates))
                ) && 
                (
                    this.Last4 == input.Last4 ||
                    (this.Last4 != null &&
                    this.Last4.Equals(input.Last4))
                ) && 
                (
                    this.Brand == input.Brand ||
                    (this.Brand != null &&
                    this.Brand.Equals(input.Brand))
                ) && 
                (
                    this.AccountVerification == input.AccountVerification ||
                    (this.AccountVerification != null &&
                    this.AccountVerification.Equals(input.AccountVerification))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Reusable != null)
                    hashCode = hashCode * 59 + this.Reusable.GetHashCode();
                if (this.DeclineDuplicates != null)
                    hashCode = hashCode * 59 + this.DeclineDuplicates.GetHashCode();
                if (this.Last4 != null)
                    hashCode = hashCode * 59 + this.Last4.GetHashCode();
                if (this.Brand != null)
                    hashCode = hashCode * 59 + this.Brand.GetHashCode();
                if (this.AccountVerification != null)
                    hashCode = hashCode * 59 + this.AccountVerification.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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
