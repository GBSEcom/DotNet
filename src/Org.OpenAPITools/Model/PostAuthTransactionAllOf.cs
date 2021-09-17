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
    /// PostAuthTransactionAllOf
    /// </summary>
    [DataContract(Name = "PostAuthTransaction_allOf")]
    public partial class PostAuthTransactionAllOf : IEquatable<PostAuthTransactionAllOf>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets TransactionOrigin
        /// </summary>
        [DataMember(Name = "transactionOrigin", EmitDefaultValue = false)]
        public TransactionOrigin? TransactionOrigin { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PostAuthTransactionAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PostAuthTransactionAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PostAuthTransactionAllOf" /> class.
        /// </summary>
        /// <param name="transactionAmount">transactionAmount (required).</param>
        /// <param name="transactionOrigin">transactionOrigin.</param>
        /// <param name="splitShipment">splitShipment.</param>
        /// <param name="softDescriptor">softDescriptor.</param>
        public PostAuthTransactionAllOf(Amount transactionAmount = default(Amount), TransactionOrigin? transactionOrigin = default(TransactionOrigin?), SplitShipment splitShipment = default(SplitShipment), SoftDescriptor softDescriptor = default(SoftDescriptor))
        {
            // to ensure "transactionAmount" is required (not null)
            this.TransactionAmount = transactionAmount ?? throw new ArgumentNullException("transactionAmount is a required property for PostAuthTransactionAllOf and cannot be null");
            this.TransactionOrigin = transactionOrigin;
            this.SplitShipment = splitShipment;
            this.SoftDescriptor = softDescriptor;
        }

        /// <summary>
        /// Gets or Sets TransactionAmount
        /// </summary>
        [DataMember(Name = "transactionAmount", IsRequired = true, EmitDefaultValue = false)]
        public Amount TransactionAmount { get; set; }

        /// <summary>
        /// Gets or Sets SplitShipment
        /// </summary>
        [DataMember(Name = "splitShipment", EmitDefaultValue = false)]
        public SplitShipment SplitShipment { get; set; }

        /// <summary>
        /// Gets or Sets SoftDescriptor
        /// </summary>
        [DataMember(Name = "softDescriptor", EmitDefaultValue = false)]
        public SoftDescriptor SoftDescriptor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PostAuthTransactionAllOf {\n");
            sb.Append("  TransactionAmount: ").Append(TransactionAmount).Append("\n");
            sb.Append("  TransactionOrigin: ").Append(TransactionOrigin).Append("\n");
            sb.Append("  SplitShipment: ").Append(SplitShipment).Append("\n");
            sb.Append("  SoftDescriptor: ").Append(SoftDescriptor).Append("\n");
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
            return this.Equals(input as PostAuthTransactionAllOf);
        }

        /// <summary>
        /// Returns true if PostAuthTransactionAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of PostAuthTransactionAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostAuthTransactionAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TransactionAmount == input.TransactionAmount ||
                    (this.TransactionAmount != null &&
                    this.TransactionAmount.Equals(input.TransactionAmount))
                ) && 
                (
                    this.TransactionOrigin == input.TransactionOrigin ||
                    this.TransactionOrigin.Equals(input.TransactionOrigin)
                ) && 
                (
                    this.SplitShipment == input.SplitShipment ||
                    (this.SplitShipment != null &&
                    this.SplitShipment.Equals(input.SplitShipment))
                ) && 
                (
                    this.SoftDescriptor == input.SoftDescriptor ||
                    (this.SoftDescriptor != null &&
                    this.SoftDescriptor.Equals(input.SoftDescriptor))
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
                if (this.TransactionAmount != null)
                    hashCode = hashCode * 59 + this.TransactionAmount.GetHashCode();
                hashCode = hashCode * 59 + this.TransactionOrigin.GetHashCode();
                if (this.SplitShipment != null)
                    hashCode = hashCode * 59 + this.SplitShipment.GetHashCode();
                if (this.SoftDescriptor != null)
                    hashCode = hashCode * 59 + this.SoftDescriptor.GetHashCode();
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
