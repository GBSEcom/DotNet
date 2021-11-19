/*
 * Payment Gateway API Specification.
 *
 * The documentation here is designed to provide all of the technical guidance required to consume and integrate with our APIs for payment processing. To learn more about our APIs please visit https://docs.firstdata.com/org/gateway.
 *
 * The version of the OpenAPI document: 21.5.0.20211029.001
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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Request to perform void transaction.
    /// </summary>
    [DataContract(Name = "VoidTransaction")]
    [JsonConverter(typeof(JsonSubtypes), "RequestType")]
    public partial class VoidTransaction : SecondaryTransaction, IEquatable<VoidTransaction>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoidTransaction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VoidTransaction() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VoidTransaction" /> class.
        /// </summary>
        /// <param name="transactionAmount">transactionAmount.</param>
        /// <param name="requestType">Object name of the secondary transaction request. (required) (default to &quot;VoidTransaction&quot;).</param>
        /// <param name="storeId">An optional outlet ID for clients that support multiple stores in the same developer app..</param>
        /// <param name="merchantTransactionId">The unique merchant transaction ID from the request, if supplied..</param>
        /// <param name="comments">Comment for the secondary transaction..</param>
        /// <param name="order">order.</param>
        public VoidTransaction(Amount transactionAmount = default(Amount), string requestType = "VoidTransaction", string storeId = default(string), string merchantTransactionId = default(string), string comments = default(string), Order order = default(Order)) : base(requestType, storeId, merchantTransactionId, comments, order)
        {
            this.TransactionAmount = transactionAmount;
        }

        /// <summary>
        /// Gets or Sets TransactionAmount
        /// </summary>
        [DataMember(Name = "transactionAmount", EmitDefaultValue = false)]
        public Amount TransactionAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VoidTransaction {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  TransactionAmount: ").Append(TransactionAmount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as VoidTransaction);
        }

        /// <summary>
        /// Returns true if VoidTransaction instances are equal
        /// </summary>
        /// <param name="input">Instance of VoidTransaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VoidTransaction input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.TransactionAmount == input.TransactionAmount ||
                    (this.TransactionAmount != null &&
                    this.TransactionAmount.Equals(input.TransactionAmount))
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            foreach(var x in BaseValidate(validationContext)) yield return x;
            yield break;
        }
    }
}
