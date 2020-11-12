/* 
 * Payment Gateway API Specification.
 *
 * The documentation here is designed to provide all of the technical guidance required to consume and integrate with our APIs for payment processing. To learn more about our APIs please visit https://docs.firstdata.com/org/gateway.
 *
 * The version of the OpenAPI document: 6.14.0.20201015.001
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
    /// Request to perform return transaction.
    /// </summary>
    [DataContract]
    public partial class ReturnTransaction : SecondaryTransaction, IEquatable<ReturnTransaction>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnTransaction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ReturnTransaction() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnTransaction" /> class.
        /// </summary>
        /// <param name="transactionAmount">transactionAmount (required).</param>
        /// <param name="softDescriptor">softDescriptor.</param>
        /// <param name="storedCredentials">storedCredentials.</param>
        /// <param name="currencyConversion">currencyConversion.</param>
        /// <param name="requestType">Object name of the secondary transaction request. (required).</param>
        /// <param name="storeId">An optional outlet ID for clients that support multiple stores in the same developer app..</param>
        /// <param name="merchantTransactionId">The unique merchant transaction ID from the request, if supplied..</param>
        /// <param name="comments">Comment for the secondary transaction..</param>
        /// <param name="order">order.</param>
        public ReturnTransaction(Amount transactionAmount = default(Amount), SoftDescriptor softDescriptor = default(SoftDescriptor), StoredCredential storedCredentials = default(StoredCredential), CurrencyConversion currencyConversion = default(CurrencyConversion), string requestType = default(string), string storeId = default(string), string merchantTransactionId = default(string), string comments = default(string), Order order = default(Order)) : base(requestType, storeId, merchantTransactionId, comments, order)
        {
            // to ensure "transactionAmount" is required (not null)
            this.TransactionAmount = transactionAmount ?? throw new ArgumentNullException("transactionAmount is a required property for ReturnTransaction and cannot be null");
            this.SoftDescriptor = softDescriptor;
            this.StoredCredentials = storedCredentials;
            this.CurrencyConversion = currencyConversion;
        }

        /// <summary>
        /// Gets or Sets TransactionAmount
        /// </summary>
        [DataMember(Name = "transactionAmount", EmitDefaultValue = false)]
        public Amount TransactionAmount { get; set; }

        /// <summary>
        /// Gets or Sets SoftDescriptor
        /// </summary>
        [DataMember(Name = "softDescriptor", EmitDefaultValue = false)]
        public SoftDescriptor SoftDescriptor { get; set; }

        /// <summary>
        /// Gets or Sets StoredCredentials
        /// </summary>
        [DataMember(Name = "storedCredentials", EmitDefaultValue = false)]
        public StoredCredential StoredCredentials { get; set; }

        /// <summary>
        /// Gets or Sets CurrencyConversion
        /// </summary>
        [DataMember(Name = "currencyConversion", EmitDefaultValue = false)]
        public CurrencyConversion CurrencyConversion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReturnTransaction {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  TransactionAmount: ").Append(TransactionAmount).Append("\n");
            sb.Append("  SoftDescriptor: ").Append(SoftDescriptor).Append("\n");
            sb.Append("  StoredCredentials: ").Append(StoredCredentials).Append("\n");
            sb.Append("  CurrencyConversion: ").Append(CurrencyConversion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as ReturnTransaction);
        }

        /// <summary>
        /// Returns true if ReturnTransaction instances are equal
        /// </summary>
        /// <param name="input">Instance of ReturnTransaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReturnTransaction input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.TransactionAmount == input.TransactionAmount ||
                    (this.TransactionAmount != null &&
                    this.TransactionAmount.Equals(input.TransactionAmount))
                ) && base.Equals(input) && 
                (
                    this.SoftDescriptor == input.SoftDescriptor ||
                    (this.SoftDescriptor != null &&
                    this.SoftDescriptor.Equals(input.SoftDescriptor))
                ) && base.Equals(input) && 
                (
                    this.StoredCredentials == input.StoredCredentials ||
                    (this.StoredCredentials != null &&
                    this.StoredCredentials.Equals(input.StoredCredentials))
                ) && base.Equals(input) && 
                (
                    this.CurrencyConversion == input.CurrencyConversion ||
                    (this.CurrencyConversion != null &&
                    this.CurrencyConversion.Equals(input.CurrencyConversion))
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
                int hashCode = base.GetHashCode();
                if (this.TransactionAmount != null)
                    hashCode = hashCode * 59 + this.TransactionAmount.GetHashCode();
                if (this.SoftDescriptor != null)
                    hashCode = hashCode * 59 + this.SoftDescriptor.GetHashCode();
                if (this.StoredCredentials != null)
                    hashCode = hashCode * 59 + this.StoredCredentials.GetHashCode();
                if (this.CurrencyConversion != null)
                    hashCode = hashCode * 59 + this.CurrencyConversion.GetHashCode();
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
            foreach(var x in BaseValidate(validationContext)) yield return x;
            yield break;
        }
    }
}
