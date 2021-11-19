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
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Identifying information about a merchant which appears on buyer&#39;s credit/debit card statements.
    /// </summary>
    [DataContract(Name = "SoftDescriptor")]
    public partial class SoftDescriptor : IEquatable<SoftDescriptor>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SoftDescriptor" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SoftDescriptor() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SoftDescriptor" /> class.
        /// </summary>
        /// <param name="dynamicMerchantName">Store \&quot;doing-business-as\&quot; name. (required).</param>
        /// <param name="customerServiceNumber">Customer service phone number information that is passed to the issuer (it may appear on the cardholder’s statement) or if merchant wants to pass information that differs from the information stored on our master File..</param>
        /// <param name="mcc">The 4-digit merchant category code (MCC). The merchant might be associated with multiple MCCs. In that case the MCC provided here will be the one that better describes the current transaction..</param>
        /// <param name="dynamicAddress">dynamicAddress.</param>
        public SoftDescriptor(string dynamicMerchantName = default(string), string customerServiceNumber = default(string), string mcc = default(string), Address dynamicAddress = default(Address))
        {
            // to ensure "dynamicMerchantName" is required (not null)
            this.DynamicMerchantName = dynamicMerchantName ?? throw new ArgumentNullException("dynamicMerchantName is a required property for SoftDescriptor and cannot be null");
            this.CustomerServiceNumber = customerServiceNumber;
            this.Mcc = mcc;
            this.DynamicAddress = dynamicAddress;
        }

        /// <summary>
        /// Store \&quot;doing-business-as\&quot; name.
        /// </summary>
        /// <value>Store \&quot;doing-business-as\&quot; name.</value>
        [DataMember(Name = "dynamicMerchantName", IsRequired = true, EmitDefaultValue = false)]
        public string DynamicMerchantName { get; set; }

        /// <summary>
        /// Customer service phone number information that is passed to the issuer (it may appear on the cardholder’s statement) or if merchant wants to pass information that differs from the information stored on our master File.
        /// </summary>
        /// <value>Customer service phone number information that is passed to the issuer (it may appear on the cardholder’s statement) or if merchant wants to pass information that differs from the information stored on our master File.</value>
        [DataMember(Name = "customerServiceNumber", EmitDefaultValue = false)]
        public string CustomerServiceNumber { get; set; }

        /// <summary>
        /// The 4-digit merchant category code (MCC). The merchant might be associated with multiple MCCs. In that case the MCC provided here will be the one that better describes the current transaction.
        /// </summary>
        /// <value>The 4-digit merchant category code (MCC). The merchant might be associated with multiple MCCs. In that case the MCC provided here will be the one that better describes the current transaction.</value>
        [DataMember(Name = "mcc", EmitDefaultValue = false)]
        public string Mcc { get; set; }

        /// <summary>
        /// Gets or Sets DynamicAddress
        /// </summary>
        [DataMember(Name = "dynamicAddress", EmitDefaultValue = false)]
        public Address DynamicAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SoftDescriptor {\n");
            sb.Append("  DynamicMerchantName: ").Append(DynamicMerchantName).Append("\n");
            sb.Append("  CustomerServiceNumber: ").Append(CustomerServiceNumber).Append("\n");
            sb.Append("  Mcc: ").Append(Mcc).Append("\n");
            sb.Append("  DynamicAddress: ").Append(DynamicAddress).Append("\n");
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
            return this.Equals(input as SoftDescriptor);
        }

        /// <summary>
        /// Returns true if SoftDescriptor instances are equal
        /// </summary>
        /// <param name="input">Instance of SoftDescriptor to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SoftDescriptor input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DynamicMerchantName == input.DynamicMerchantName ||
                    (this.DynamicMerchantName != null &&
                    this.DynamicMerchantName.Equals(input.DynamicMerchantName))
                ) && 
                (
                    this.CustomerServiceNumber == input.CustomerServiceNumber ||
                    (this.CustomerServiceNumber != null &&
                    this.CustomerServiceNumber.Equals(input.CustomerServiceNumber))
                ) && 
                (
                    this.Mcc == input.Mcc ||
                    (this.Mcc != null &&
                    this.Mcc.Equals(input.Mcc))
                ) && 
                (
                    this.DynamicAddress == input.DynamicAddress ||
                    (this.DynamicAddress != null &&
                    this.DynamicAddress.Equals(input.DynamicAddress))
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
                if (this.DynamicMerchantName != null)
                    hashCode = hashCode * 59 + this.DynamicMerchantName.GetHashCode();
                if (this.CustomerServiceNumber != null)
                    hashCode = hashCode * 59 + this.CustomerServiceNumber.GetHashCode();
                if (this.Mcc != null)
                    hashCode = hashCode * 59 + this.Mcc.GetHashCode();
                if (this.DynamicAddress != null)
                    hashCode = hashCode * 59 + this.DynamicAddress.GetHashCode();
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
            // DynamicMerchantName (string) pattern
            Regex regexDynamicMerchantName = new Regex(@"^(?!\\s*$).+", RegexOptions.CultureInvariant);
            if (false == regexDynamicMerchantName.Match(this.DynamicMerchantName).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DynamicMerchantName, must match a pattern of " + regexDynamicMerchantName, new [] { "DynamicMerchantName" });
            }

            // CustomerServiceNumber (string) maxLength
            if(this.CustomerServiceNumber != null && this.CustomerServiceNumber.Length > 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CustomerServiceNumber, length must be less than 10.", new [] { "CustomerServiceNumber" });
            }

            // CustomerServiceNumber (string) pattern
            Regex regexCustomerServiceNumber = new Regex(@"^[0-9]+$", RegexOptions.CultureInvariant);
            if (false == regexCustomerServiceNumber.Match(this.CustomerServiceNumber).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CustomerServiceNumber, must match a pattern of " + regexCustomerServiceNumber, new [] { "CustomerServiceNumber" });
            }

            // Mcc (string) maxLength
            if(this.Mcc != null && this.Mcc.Length > 4)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Mcc, length must be less than 4.", new [] { "Mcc" });
            }

            yield break;
        }
    }
}
