/* 
 * Payment Gateway API Specification.
 *
 * The documentation here is designed to provide all of the technical guidance required to consume and integrate with our APIs for payment processing. To learn more about our APIs please visit https://docs.firstdata.com/org/gateway.
 *
 * The version of the OpenAPI document: 21.2.0.20210406.001
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
    /// Request to perform pre-auth incremental secondary transaction without providing credit card information.
    /// </summary>
    [DataContract]
    public partial class PreAuthSecondaryTransaction : SecondaryTransaction, IEquatable<PreAuthSecondaryTransaction>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PreAuthSecondaryTransaction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PreAuthSecondaryTransaction() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PreAuthSecondaryTransaction" /> class.
        /// </summary>
        /// <param name="transactionAmount">transactionAmount (required).</param>
        /// <param name="decrementalFlag">This flag can only be used in a preAuth transaction that updates the amount of a previous preAuth transaction to either increase the preAuth amount (DecrementalPreAuthFlag &#x3D; false) or decrease the preAuth amount (DecrementalPreAuthFlag &#x3D; true). (default to false).</param>
        /// <param name="requestType">Object name of the secondary transaction request. (required).</param>
        /// <param name="storeId">An optional outlet ID for clients that support multiple stores in the same developer app..</param>
        /// <param name="merchantTransactionId">The unique merchant transaction ID from the request, if supplied..</param>
        /// <param name="comments">Comment for the secondary transaction..</param>
        /// <param name="order">order.</param>
        public PreAuthSecondaryTransaction(Amount transactionAmount = default(Amount), bool decrementalFlag = false, string requestType = default(string), string storeId = default(string), string merchantTransactionId = default(string), string comments = default(string), Order order = default(Order)) : base(requestType, storeId, merchantTransactionId, comments, order)
        {
            // to ensure "transactionAmount" is required (not null)
            this.TransactionAmount = transactionAmount ?? throw new ArgumentNullException("transactionAmount is a required property for PreAuthSecondaryTransaction and cannot be null");
            // use default value if no "decrementalFlag" provided
            this.DecrementalFlag = decrementalFlag;
        }

        /// <summary>
        /// Gets or Sets TransactionAmount
        /// </summary>
        [DataMember(Name = "transactionAmount", EmitDefaultValue = false)]
        public Amount TransactionAmount { get; set; }

        /// <summary>
        /// This flag can only be used in a preAuth transaction that updates the amount of a previous preAuth transaction to either increase the preAuth amount (DecrementalPreAuthFlag &#x3D; false) or decrease the preAuth amount (DecrementalPreAuthFlag &#x3D; true).
        /// </summary>
        /// <value>This flag can only be used in a preAuth transaction that updates the amount of a previous preAuth transaction to either increase the preAuth amount (DecrementalPreAuthFlag &#x3D; false) or decrease the preAuth amount (DecrementalPreAuthFlag &#x3D; true).</value>
        [DataMember(Name = "decrementalFlag", EmitDefaultValue = false)]
        public bool DecrementalFlag { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PreAuthSecondaryTransaction {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  TransactionAmount: ").Append(TransactionAmount).Append("\n");
            sb.Append("  DecrementalFlag: ").Append(DecrementalFlag).Append("\n");
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
            return this.Equals(input as PreAuthSecondaryTransaction);
        }

        /// <summary>
        /// Returns true if PreAuthSecondaryTransaction instances are equal
        /// </summary>
        /// <param name="input">Instance of PreAuthSecondaryTransaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PreAuthSecondaryTransaction input)
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
                    this.DecrementalFlag == input.DecrementalFlag ||
                    (this.DecrementalFlag != null &&
                    this.DecrementalFlag.Equals(input.DecrementalFlag))
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
                if (this.DecrementalFlag != null)
                    hashCode = hashCode * 59 + this.DecrementalFlag.GetHashCode();
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