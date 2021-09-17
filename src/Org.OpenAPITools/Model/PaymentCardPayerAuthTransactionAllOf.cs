/*
 * Payment Gateway API Specification.
 *
 * The documentation here is designed to provide all of the technical guidance required to consume and integrate with our APIs for payment processing. To learn more about our APIs please visit https://docs.firstdata.com/org/gateway.
 *
 * The version of the OpenAPI document: 21.4.0.20210824.002
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// PaymentCardPayerAuthTransactionAllOf
    /// </summary>
    [DataContract(Name = "PaymentCardPayerAuthTransaction_allOf")]
    public partial class PaymentCardPayerAuthTransactionAllOf : IEquatable<PaymentCardPayerAuthTransactionAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentCardPayerAuthTransactionAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentCardPayerAuthTransactionAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentCardPayerAuthTransactionAllOf" /> class.
        /// </summary>
        /// <param name="paymentMethod">paymentMethod (required).</param>
        /// <param name="currencyConversion">currencyConversion.</param>
        /// <param name="authenticationRequest">authenticationRequest.</param>
        /// <param name="authenticationResult">authenticationResult.</param>
        public PaymentCardPayerAuthTransactionAllOf(PaymentCardPaymentMethod paymentMethod = default(PaymentCardPaymentMethod), CurrencyConversion currencyConversion = default(CurrencyConversion), AuthenticationRequest authenticationRequest = default(AuthenticationRequest), AuthenticationResult authenticationResult = default(AuthenticationResult))
        {
            // to ensure "paymentMethod" is required (not null)
            this.PaymentMethod = paymentMethod ?? throw new ArgumentNullException("paymentMethod is a required property for PaymentCardPayerAuthTransactionAllOf and cannot be null");
            this.CurrencyConversion = currencyConversion;
            this.AuthenticationRequest = authenticationRequest;
            this.AuthenticationResult = authenticationResult;
        }

        /// <summary>
        /// Gets or Sets PaymentMethod
        /// </summary>
        [DataMember(Name = "paymentMethod", IsRequired = true, EmitDefaultValue = false)]
        public PaymentCardPaymentMethod PaymentMethod { get; set; }

        /// <summary>
        /// Gets or Sets CurrencyConversion
        /// </summary>
        [DataMember(Name = "currencyConversion", EmitDefaultValue = false)]
        public CurrencyConversion CurrencyConversion { get; set; }

        /// <summary>
        /// Gets or Sets AuthenticationRequest
        /// </summary>
        [DataMember(Name = "authenticationRequest", EmitDefaultValue = false)]
        public AuthenticationRequest AuthenticationRequest { get; set; }

        /// <summary>
        /// Gets or Sets AuthenticationResult
        /// </summary>
        [DataMember(Name = "authenticationResult", EmitDefaultValue = false)]
        public AuthenticationResult AuthenticationResult { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentCardPayerAuthTransactionAllOf {\n");
            sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
            sb.Append("  CurrencyConversion: ").Append(CurrencyConversion).Append("\n");
            sb.Append("  AuthenticationRequest: ").Append(AuthenticationRequest).Append("\n");
            sb.Append("  AuthenticationResult: ").Append(AuthenticationResult).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PaymentCardPayerAuthTransactionAllOf);
        }

        /// <summary>
        /// Returns true if PaymentCardPayerAuthTransactionAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentCardPayerAuthTransactionAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentCardPayerAuthTransactionAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PaymentMethod == input.PaymentMethod ||
                    (this.PaymentMethod != null &&
                    this.PaymentMethod.Equals(input.PaymentMethod))
                ) && 
                (
                    this.CurrencyConversion == input.CurrencyConversion ||
                    (this.CurrencyConversion != null &&
                    this.CurrencyConversion.Equals(input.CurrencyConversion))
                ) && 
                (
                    this.AuthenticationRequest == input.AuthenticationRequest ||
                    (this.AuthenticationRequest != null &&
                    this.AuthenticationRequest.Equals(input.AuthenticationRequest))
                ) && 
                (
                    this.AuthenticationResult == input.AuthenticationResult ||
                    (this.AuthenticationResult != null &&
                    this.AuthenticationResult.Equals(input.AuthenticationResult))
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
                if (this.PaymentMethod != null)
                    hashCode = hashCode * 59 + this.PaymentMethod.GetHashCode();
                if (this.CurrencyConversion != null)
                    hashCode = hashCode * 59 + this.CurrencyConversion.GetHashCode();
                if (this.AuthenticationRequest != null)
                    hashCode = hashCode * 59 + this.AuthenticationRequest.GetHashCode();
                if (this.AuthenticationResult != null)
                    hashCode = hashCode * 59 + this.AuthenticationResult.GetHashCode();
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
