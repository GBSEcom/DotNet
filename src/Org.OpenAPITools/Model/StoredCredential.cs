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
    /// Object for sending stored credentials.
    /// </summary>
    [DataContract(Name = "StoredCredential")]
    public partial class StoredCredential : IEquatable<StoredCredential>, IValidatableObject
    {
        /// <summary>
        /// Indicates if the transaction is first or subsequent. Valid values are &#39;FIRST&#39; and &#39;SUBSEQUENT&#39;.
        /// </summary>
        /// <value>Indicates if the transaction is first or subsequent. Valid values are &#39;FIRST&#39; and &#39;SUBSEQUENT&#39;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SequenceEnum
        {
            /// <summary>
            /// Enum FIRST for value: FIRST
            /// </summary>
            [EnumMember(Value = "FIRST")]
            FIRST = 1,

            /// <summary>
            /// Enum SUBSEQUENT for value: SUBSEQUENT
            /// </summary>
            [EnumMember(Value = "SUBSEQUENT")]
            SUBSEQUENT = 2

        }


        /// <summary>
        /// Indicates if the transaction is first or subsequent. Valid values are &#39;FIRST&#39; and &#39;SUBSEQUENT&#39;.
        /// </summary>
        /// <value>Indicates if the transaction is first or subsequent. Valid values are &#39;FIRST&#39; and &#39;SUBSEQUENT&#39;.</value>
        [DataMember(Name = "sequence", IsRequired = true, EmitDefaultValue = false)]
        public SequenceEnum Sequence { get; set; }
        /// <summary>
        /// Indicates whether it is a merchant-initiated or explicitly consented to by card holder. Valid values are &#39;MERCHANT&#39; and &#39;CARDHOLDER&#39;.
        /// </summary>
        /// <value>Indicates whether it is a merchant-initiated or explicitly consented to by card holder. Valid values are &#39;MERCHANT&#39; and &#39;CARDHOLDER&#39;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum InitiatorEnum
        {
            /// <summary>
            /// Enum MERCHANT for value: MERCHANT
            /// </summary>
            [EnumMember(Value = "MERCHANT")]
            MERCHANT = 1,

            /// <summary>
            /// Enum CARDHOLDER for value: CARDHOLDER
            /// </summary>
            [EnumMember(Value = "CARDHOLDER")]
            CARDHOLDER = 2

        }


        /// <summary>
        /// Indicates whether it is a merchant-initiated or explicitly consented to by card holder. Valid values are &#39;MERCHANT&#39; and &#39;CARDHOLDER&#39;.
        /// </summary>
        /// <value>Indicates whether it is a merchant-initiated or explicitly consented to by card holder. Valid values are &#39;MERCHANT&#39; and &#39;CARDHOLDER&#39;.</value>
        [DataMember(Name = "initiator", EmitDefaultValue = false)]
        public InitiatorEnum? Initiator { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="StoredCredential" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StoredCredential() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StoredCredential" /> class.
        /// </summary>
        /// <param name="sequence">Indicates if the transaction is first or subsequent. Valid values are &#39;FIRST&#39; and &#39;SUBSEQUENT&#39;. (required).</param>
        /// <param name="scheduled">Indicates if the transaction is scheduled or part of an installment. (required).</param>
        /// <param name="referencedSchemeTransactionId">The transaction ID received from schemes for the initial transaction. May be required if sequence is &#39;SUBSEQUENT&#39;..</param>
        /// <param name="initiator">Indicates whether it is a merchant-initiated or explicitly consented to by card holder. Valid values are &#39;MERCHANT&#39; and &#39;CARDHOLDER&#39;..</param>
        public StoredCredential(SequenceEnum sequence = default(SequenceEnum), bool scheduled = default(bool), string referencedSchemeTransactionId = default(string), InitiatorEnum? initiator = default(InitiatorEnum?))
        {
            this.Sequence = sequence;
            this.Scheduled = scheduled;
            this.ReferencedSchemeTransactionId = referencedSchemeTransactionId;
            this.Initiator = initiator;
        }

        /// <summary>
        /// Indicates if the transaction is scheduled or part of an installment.
        /// </summary>
        /// <value>Indicates if the transaction is scheduled or part of an installment.</value>
        [DataMember(Name = "scheduled", IsRequired = true, EmitDefaultValue = true)]
        public bool? Scheduled { get; set; }

        /// <summary>
        /// The transaction ID received from schemes for the initial transaction. May be required if sequence is &#39;SUBSEQUENT&#39;.
        /// </summary>
        /// <value>The transaction ID received from schemes for the initial transaction. May be required if sequence is &#39;SUBSEQUENT&#39;.</value>
        [DataMember(Name = "referencedSchemeTransactionId", EmitDefaultValue = false)]
        public string ReferencedSchemeTransactionId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StoredCredential {\n");
            sb.Append("  Sequence: ").Append(Sequence).Append("\n");
            sb.Append("  Scheduled: ").Append(Scheduled).Append("\n");
            sb.Append("  ReferencedSchemeTransactionId: ").Append(ReferencedSchemeTransactionId).Append("\n");
            sb.Append("  Initiator: ").Append(Initiator).Append("\n");
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
            return this.Equals(input as StoredCredential);
        }

        /// <summary>
        /// Returns true if StoredCredential instances are equal
        /// </summary>
        /// <param name="input">Instance of StoredCredential to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StoredCredential input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Sequence == input.Sequence ||
                    this.Sequence.Equals(input.Sequence)
                ) && 
                (
                    this.Scheduled == input.Scheduled ||
                    this.Scheduled.Equals(input.Scheduled)
                ) && 
                (
                    this.ReferencedSchemeTransactionId == input.ReferencedSchemeTransactionId ||
                    (this.ReferencedSchemeTransactionId != null &&
                    this.ReferencedSchemeTransactionId.Equals(input.ReferencedSchemeTransactionId))
                ) && 
                (
                    this.Initiator == input.Initiator ||
                    this.Initiator.Equals(input.Initiator)
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
                hashCode = hashCode * 59 + this.Sequence.GetHashCode();
                hashCode = hashCode * 59 + this.Scheduled.GetHashCode();
                if (this.ReferencedSchemeTransactionId != null)
                    hashCode = hashCode * 59 + this.ReferencedSchemeTransactionId.GetHashCode();
                hashCode = hashCode * 59 + this.Initiator.GetHashCode();
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
            // ReferencedSchemeTransactionId (string) maxLength
            if(this.ReferencedSchemeTransactionId != null && this.ReferencedSchemeTransactionId.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReferencedSchemeTransactionId, length must be less than 50.", new [] { "ReferencedSchemeTransactionId" });
            }

            yield break;
        }
    }
}
