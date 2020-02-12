/* 
 * Payment Gateway API Specification.
 *
 * The documentation here is designed to provide all of the technical guidance required to consume and integrate with our APIs for payment processing. To learn more about our APIs please visit https://docs.firstdata.com/org/gateway.
 *
 * The version of the OpenAPI document: 6.9.1.20191223.002
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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Disbursement information. Abstract class, do not use this class directly, use one of its children: FundingTransactionType, DisbursementTransactionType.
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "DisbursementType")]
    [JsonSubtypes.KnownSubType(typeof(FundingTransactionType), "FundingTransactionType")]
    [JsonSubtypes.KnownSubType(typeof(DisbursementTransactionType), "DisbursementTransactionType")]
    public partial class Disbursement :  IEquatable<Disbursement>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Disbursement" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Disbursement() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Disbursement" /> class.
        /// </summary>
        /// <param name="disbursementType">The type of disbursement. (required).</param>
        /// <param name="senderInfo">senderInfo (required).</param>
        /// <param name="receiverInfo">receiverInfo (required).</param>
        public Disbursement(string disbursementType = default(string), SenderInfo senderInfo = default(SenderInfo), ReceiverInfo receiverInfo = default(ReceiverInfo))
        {
            // to ensure "disbursementType" is required (not null)
            if (disbursementType == null)
            {
                throw new InvalidDataException("disbursementType is a required property for Disbursement and cannot be null");
            }
            else
            {
                this.DisbursementType = disbursementType;
            }

            // to ensure "senderInfo" is required (not null)
            if (senderInfo == null)
            {
                throw new InvalidDataException("senderInfo is a required property for Disbursement and cannot be null");
            }
            else
            {
                this.SenderInfo = senderInfo;
            }

            // to ensure "receiverInfo" is required (not null)
            if (receiverInfo == null)
            {
                throw new InvalidDataException("receiverInfo is a required property for Disbursement and cannot be null");
            }
            else
            {
                this.ReceiverInfo = receiverInfo;
            }

        }
        
        /// <summary>
        /// The type of disbursement.
        /// </summary>
        /// <value>The type of disbursement.</value>
        [DataMember(Name="disbursementType", EmitDefaultValue=false)]
        public string DisbursementType { get; set; }

        /// <summary>
        /// Gets or Sets SenderInfo
        /// </summary>
        [DataMember(Name="senderInfo", EmitDefaultValue=false)]
        public SenderInfo SenderInfo { get; set; }

        /// <summary>
        /// Gets or Sets ReceiverInfo
        /// </summary>
        [DataMember(Name="receiverInfo", EmitDefaultValue=false)]
        public ReceiverInfo ReceiverInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Disbursement {\n");
            sb.Append("  DisbursementType: ").Append(DisbursementType).Append("\n");
            sb.Append("  SenderInfo: ").Append(SenderInfo).Append("\n");
            sb.Append("  ReceiverInfo: ").Append(ReceiverInfo).Append("\n");
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
            return this.Equals(input as Disbursement);
        }

        /// <summary>
        /// Returns true if Disbursement instances are equal
        /// </summary>
        /// <param name="input">Instance of Disbursement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Disbursement input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DisbursementType == input.DisbursementType ||
                    (this.DisbursementType != null &&
                    this.DisbursementType.Equals(input.DisbursementType))
                ) && 
                (
                    this.SenderInfo == input.SenderInfo ||
                    (this.SenderInfo != null &&
                    this.SenderInfo.Equals(input.SenderInfo))
                ) && 
                (
                    this.ReceiverInfo == input.ReceiverInfo ||
                    (this.ReceiverInfo != null &&
                    this.ReceiverInfo.Equals(input.ReceiverInfo))
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
                if (this.DisbursementType != null)
                    hashCode = hashCode * 59 + this.DisbursementType.GetHashCode();
                if (this.SenderInfo != null)
                    hashCode = hashCode * 59 + this.SenderInfo.GetHashCode();
                if (this.ReceiverInfo != null)
                    hashCode = hashCode * 59 + this.ReceiverInfo.GetHashCode();
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
            yield break;
        }
    }

}
