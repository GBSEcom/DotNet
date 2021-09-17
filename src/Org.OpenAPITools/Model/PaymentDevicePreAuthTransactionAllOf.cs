﻿/*
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
    /// PaymentDevicePreAuthTransactionAllOf
    /// </summary>
    [DataContract(Name = "PaymentDevicePreAuthTransaction_allOf")]
    public partial class PaymentDevicePreAuthTransactionAllOf : IEquatable<PaymentDevicePreAuthTransactionAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentDevicePreAuthTransactionAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentDevicePreAuthTransactionAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentDevicePreAuthTransactionAllOf" /> class.
        /// </summary>
        /// <param name="paymentMethod">paymentMethod (required).</param>
        /// <param name="createToken">createToken.</param>
        /// <param name="settlementSplit">Settle with multiple sub-merchants, sale and preAuth only..</param>
        /// <param name="storedCredentials">storedCredentials.</param>
        /// <param name="splitShipment">splitShipment.</param>
        /// <param name="decrementalFlag">This flag can only be used in a preAuth transaction that updates the amount of a previous preAuth transaction to either increase the preAuth amount (DecrementalPreAuthFlag &#x3D; false) or decrease the preAuth amount (DecrementalPreAuthFlag &#x3D; true). (default to false).</param>
        public PaymentDevicePreAuthTransactionAllOf(PaymentDevicePaymentMethod paymentMethod = default(PaymentDevicePaymentMethod), CreatePaymentToken createToken = default(CreatePaymentToken), List<SubMerchantSplit> settlementSplit = default(List<SubMerchantSplit>), StoredCredential storedCredentials = default(StoredCredential), SplitShipment splitShipment = default(SplitShipment), bool decrementalFlag = false)
        {
            // to ensure "paymentMethod" is required (not null)
            this.PaymentMethod = paymentMethod ?? throw new ArgumentNullException("paymentMethod is a required property for PaymentDevicePreAuthTransactionAllOf and cannot be null");
            this.CreateToken = createToken;
            this.SettlementSplit = settlementSplit;
            this.StoredCredentials = storedCredentials;
            this.SplitShipment = splitShipment;
            this.DecrementalFlag = decrementalFlag;
        }

        /// <summary>
        /// Gets or Sets PaymentMethod
        /// </summary>
        [DataMember(Name = "paymentMethod", IsRequired = true, EmitDefaultValue = false)]
        public PaymentDevicePaymentMethod PaymentMethod { get; set; }

        /// <summary>
        /// Gets or Sets CreateToken
        /// </summary>
        [DataMember(Name = "createToken", EmitDefaultValue = false)]
        public CreatePaymentToken CreateToken { get; set; }

        /// <summary>
        /// Settle with multiple sub-merchants, sale and preAuth only.
        /// </summary>
        /// <value>Settle with multiple sub-merchants, sale and preAuth only.</value>
        [DataMember(Name = "settlementSplit", EmitDefaultValue = false)]
        public List<SubMerchantSplit> SettlementSplit { get; set; }

        /// <summary>
        /// Gets or Sets StoredCredentials
        /// </summary>
        [DataMember(Name = "storedCredentials", EmitDefaultValue = false)]
        public StoredCredential StoredCredentials { get; set; }

        /// <summary>
        /// Gets or Sets SplitShipment
        /// </summary>
        [DataMember(Name = "splitShipment", EmitDefaultValue = false)]
        public SplitShipment SplitShipment { get; set; }

        /// <summary>
        /// This flag can only be used in a preAuth transaction that updates the amount of a previous preAuth transaction to either increase the preAuth amount (DecrementalPreAuthFlag &#x3D; false) or decrease the preAuth amount (DecrementalPreAuthFlag &#x3D; true).
        /// </summary>
        /// <value>This flag can only be used in a preAuth transaction that updates the amount of a previous preAuth transaction to either increase the preAuth amount (DecrementalPreAuthFlag &#x3D; false) or decrease the preAuth amount (DecrementalPreAuthFlag &#x3D; true).</value>
        [DataMember(Name = "decrementalFlag", EmitDefaultValue = true)]
        public bool DecrementalFlag { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentDevicePreAuthTransactionAllOf {\n");
            sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
            sb.Append("  CreateToken: ").Append(CreateToken).Append("\n");
            sb.Append("  SettlementSplit: ").Append(SettlementSplit).Append("\n");
            sb.Append("  StoredCredentials: ").Append(StoredCredentials).Append("\n");
            sb.Append("  SplitShipment: ").Append(SplitShipment).Append("\n");
            sb.Append("  DecrementalFlag: ").Append(DecrementalFlag).Append("\n");
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
            return this.Equals(input as PaymentDevicePreAuthTransactionAllOf);
        }

        /// <summary>
        /// Returns true if PaymentDevicePreAuthTransactionAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentDevicePreAuthTransactionAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentDevicePreAuthTransactionAllOf input)
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
                    this.CreateToken == input.CreateToken ||
                    (this.CreateToken != null &&
                    this.CreateToken.Equals(input.CreateToken))
                ) && 
                (
                    this.SettlementSplit == input.SettlementSplit ||
                    this.SettlementSplit != null &&
                    input.SettlementSplit != null &&
                    this.SettlementSplit.SequenceEqual(input.SettlementSplit)
                ) && 
                (
                    this.StoredCredentials == input.StoredCredentials ||
                    (this.StoredCredentials != null &&
                    this.StoredCredentials.Equals(input.StoredCredentials))
                ) && 
                (
                    this.SplitShipment == input.SplitShipment ||
                    (this.SplitShipment != null &&
                    this.SplitShipment.Equals(input.SplitShipment))
                ) && 
                (
                    this.DecrementalFlag == input.DecrementalFlag ||
                    this.DecrementalFlag.Equals(input.DecrementalFlag)
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
                if (this.CreateToken != null)
                    hashCode = hashCode * 59 + this.CreateToken.GetHashCode();
                if (this.SettlementSplit != null)
                    hashCode = hashCode * 59 + this.SettlementSplit.GetHashCode();
                if (this.StoredCredentials != null)
                    hashCode = hashCode * 59 + this.StoredCredentials.GetHashCode();
                if (this.SplitShipment != null)
                    hashCode = hashCode * 59 + this.SplitShipment.GetHashCode();
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
            yield break;
        }
    }
}
