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
    /// ACH TeleCheck payment method for internet check acceptance application type.
    /// </summary>
    [DataContract(Name = "TeleCheckICAPaymentMethod")]
    [JsonConverter(typeof(JsonSubtypes), "AchType")]
    public partial class TeleCheckICAPaymentMethod : TeleCheckAchPaymentMethod, IEquatable<TeleCheckICAPaymentMethod>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets RecurringType
        /// </summary>
        [DataMember(Name = "recurringType", EmitDefaultValue = false)]
        public AchRecurringType? RecurringType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TeleCheckICAPaymentMethod" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TeleCheckICAPaymentMethod() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TeleCheckICAPaymentMethod" /> class.
        /// </summary>
        /// <param name="customerIpAddress">Customer IP address from the terminal where the order was placed (as captured by merchant). (required).</param>
        /// <param name="imeiCode">International mobile equipment identity code..</param>
        /// <param name="recurringType">recurringType.</param>
        /// <param name="achType">ACH application type values will be one of either TeleCheckICAPaymentMethod or TeleCheckCBPPaymentMethod. (required) (default to &quot;TeleCheckICAPaymentMethod&quot;).</param>
        /// <param name="routingNumber">Bank routing number. (required).</param>
        /// <param name="accountNumber">Bank account number. (required).</param>
        /// <param name="accountType">Identifies if the account type is checking or savings. (required).</param>
        /// <param name="checkNumber">Check number..</param>
        /// <param name="checkType">Identifies if the check type is personal or company. (required).</param>
        /// <param name="productCode">Identifies the product code in the transaction..</param>
        /// <param name="manualIdInfo">manualIdInfo.</param>
        /// <param name="supplementIdInfo">supplementIdInfo.</param>
        /// <param name="agentId">Used to track the agent transaction activity..</param>
        /// <param name="terminalId">Identifies the register or lane number where the original sale transaction occurred..</param>
        /// <param name="registrationId">Unique ID assigned by the merchant for the consumer (never recycled). It is an additional level of authentication. To use this feature, the merchant must work with TeleCheck Risk to discuss. Registration IDs must not be generated for an existing or returning consumer returns. The single registration ID must be unique per consumer..</param>
        /// <param name="registrationDate">Date the consumer originally registered in format MMDDYYYY..</param>
        /// <param name="releaseType">Release type is used as a risk variable to gauge risk level when the merchant is releasing the purchased merchandise..</param>
        /// <param name="vipCustomer">Flags a transaction as a VIP order (based on merchant criteria). This field should not be sent for non-VIP orders..</param>
        /// <param name="sessionId">Session identifier. (required).</param>
        /// <param name="terminalState">Identifies the US state or territory where the original sale transaction occurred..</param>
        /// <param name="terminalCity">Identifies the city where the original sale transaction occurred..</param>
        /// <param name="achBillTo">achBillTo.</param>
        public TeleCheckICAPaymentMethod(string customerIpAddress = default(string), string imeiCode = default(string), AchRecurringType? recurringType = default(AchRecurringType?), string achType = "TeleCheckICAPaymentMethod", string routingNumber = default(string), string accountNumber = default(string), AccountTypeEnum accountType = default(AccountTypeEnum), string checkNumber = default(string), CheckTypeEnum checkType = default(CheckTypeEnum), string productCode = default(string), IdInfo manualIdInfo = default(IdInfo), IdInfo supplementIdInfo = default(IdInfo), string agentId = default(string), string terminalId = default(string), string registrationId = default(string), DateTime registrationDate = default(DateTime), ReleaseTypeEnum? releaseType = default(ReleaseTypeEnum?), VipCustomerEnum? vipCustomer = default(VipCustomerEnum?), string sessionId = default(string), string terminalState = default(string), string terminalCity = default(string), TeleCheckAchPaymentMethodAchBillTo achBillTo = default(TeleCheckAchPaymentMethodAchBillTo)) : base(achType, routingNumber, accountNumber, accountType, checkNumber, checkType, productCode, manualIdInfo, supplementIdInfo, agentId, terminalId, registrationId, registrationDate, releaseType, vipCustomer, sessionId, terminalState, terminalCity, achBillTo)
        {
            // to ensure "customerIpAddress" is required (not null)
            this.CustomerIpAddress = customerIpAddress ?? throw new ArgumentNullException("customerIpAddress is a required property for TeleCheckICAPaymentMethod and cannot be null");
            this.ImeiCode = imeiCode;
            this.RecurringType = recurringType;
        }

        /// <summary>
        /// Customer IP address from the terminal where the order was placed (as captured by merchant).
        /// </summary>
        /// <value>Customer IP address from the terminal where the order was placed (as captured by merchant).</value>
        [DataMember(Name = "customerIpAddress", IsRequired = true, EmitDefaultValue = false)]
        public string CustomerIpAddress { get; set; }

        /// <summary>
        /// International mobile equipment identity code.
        /// </summary>
        /// <value>International mobile equipment identity code.</value>
        [DataMember(Name = "imeiCode", EmitDefaultValue = false)]
        public string ImeiCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TeleCheckICAPaymentMethod {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  CustomerIpAddress: ").Append(CustomerIpAddress).Append("\n");
            sb.Append("  ImeiCode: ").Append(ImeiCode).Append("\n");
            sb.Append("  RecurringType: ").Append(RecurringType).Append("\n");
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
            return this.Equals(input as TeleCheckICAPaymentMethod);
        }

        /// <summary>
        /// Returns true if TeleCheckICAPaymentMethod instances are equal
        /// </summary>
        /// <param name="input">Instance of TeleCheckICAPaymentMethod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TeleCheckICAPaymentMethod input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.CustomerIpAddress == input.CustomerIpAddress ||
                    (this.CustomerIpAddress != null &&
                    this.CustomerIpAddress.Equals(input.CustomerIpAddress))
                ) && base.Equals(input) && 
                (
                    this.ImeiCode == input.ImeiCode ||
                    (this.ImeiCode != null &&
                    this.ImeiCode.Equals(input.ImeiCode))
                ) && base.Equals(input) && 
                (
                    this.RecurringType == input.RecurringType ||
                    this.RecurringType.Equals(input.RecurringType)
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
                if (this.CustomerIpAddress != null)
                    hashCode = hashCode * 59 + this.CustomerIpAddress.GetHashCode();
                if (this.ImeiCode != null)
                    hashCode = hashCode * 59 + this.ImeiCode.GetHashCode();
                hashCode = hashCode * 59 + this.RecurringType.GetHashCode();
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
            // CustomerIpAddress (string) maxLength
            if(this.CustomerIpAddress != null && this.CustomerIpAddress.Length > 15)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CustomerIpAddress, length must be less than 15.", new [] { "CustomerIpAddress" });
            }

            // CustomerIpAddress (string) pattern
            Regex regexCustomerIpAddress = new Regex(@"^[0-9\\.]+$", RegexOptions.CultureInvariant);
            if (false == regexCustomerIpAddress.Match(this.CustomerIpAddress).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CustomerIpAddress, must match a pattern of " + regexCustomerIpAddress, new [] { "CustomerIpAddress" });
            }

            // ImeiCode (string) maxLength
            if(this.ImeiCode != null && this.ImeiCode.Length > 25)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ImeiCode, length must be less than 25.", new [] { "ImeiCode" });
            }

            // ImeiCode (string) pattern
            Regex regexImeiCode = new Regex(@"(?=.*[^\\s])^[^|]+$", RegexOptions.CultureInvariant);
            if (false == regexImeiCode.Match(this.ImeiCode).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ImeiCode, must match a pattern of " + regexImeiCode, new [] { "ImeiCode" });
            }

            yield break;
        }
    }
}
