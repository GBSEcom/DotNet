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
    /// FraudSettingsResponseAllOf
    /// </summary>
    [DataContract]
    public partial class FraudSettingsResponseAllOf : IEquatable<FraudSettingsResponseAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FraudSettingsResponseAllOf" /> class.
        /// </summary>
        /// <param name="storeId">The outlet ID..</param>
        /// <param name="blockedCardNumbers">List of blocked card numbers..</param>
        /// <param name="blockedNames">List of blocked fraud names..</param>
        /// <param name="blockedDomainNames">List of blocked fraud domain names..</param>
        /// <param name="blockedIpOrClassCAddresses">List of blocked fraud IP address/Class C..</param>
        /// <param name="maximumPurchaseAmount">Maximum purchase amount limit..</param>
        /// <param name="lockoutTime">lockoutTime.</param>
        /// <param name="countryProfile">Country profile..</param>
        public FraudSettingsResponseAllOf(string storeId = default(string), List<BlockedCardNumber> blockedCardNumbers = default(List<BlockedCardNumber>), List<string> blockedNames = default(List<string>), List<string> blockedDomainNames = default(List<string>), List<string> blockedIpOrClassCAddresses = default(List<string>), List<MaximumPurchaseAmount> maximumPurchaseAmount = default(List<MaximumPurchaseAmount>), LockoutTime lockoutTime = default(LockoutTime), string countryProfile = default(string))
        {
            this.StoreId = storeId;
            this.BlockedCardNumbers = blockedCardNumbers;
            this.BlockedNames = blockedNames;
            this.BlockedDomainNames = blockedDomainNames;
            this.BlockedIpOrClassCAddresses = blockedIpOrClassCAddresses;
            this.MaximumPurchaseAmount = maximumPurchaseAmount;
            this.LockoutTime = lockoutTime;
            this.CountryProfile = countryProfile;
        }

        /// <summary>
        /// The outlet ID.
        /// </summary>
        /// <value>The outlet ID.</value>
        [DataMember(Name = "storeId", EmitDefaultValue = false)]
        public string StoreId { get; set; }

        /// <summary>
        /// List of blocked card numbers.
        /// </summary>
        /// <value>List of blocked card numbers.</value>
        [DataMember(Name = "blockedCardNumbers", EmitDefaultValue = false)]
        public List<BlockedCardNumber> BlockedCardNumbers { get; set; }

        /// <summary>
        /// List of blocked fraud names.
        /// </summary>
        /// <value>List of blocked fraud names.</value>
        [DataMember(Name = "blockedNames", EmitDefaultValue = false)]
        public List<string> BlockedNames { get; set; }

        /// <summary>
        /// List of blocked fraud domain names.
        /// </summary>
        /// <value>List of blocked fraud domain names.</value>
        [DataMember(Name = "blockedDomainNames", EmitDefaultValue = false)]
        public List<string> BlockedDomainNames { get; set; }

        /// <summary>
        /// List of blocked fraud IP address/Class C.
        /// </summary>
        /// <value>List of blocked fraud IP address/Class C.</value>
        [DataMember(Name = "blockedIpOrClassCAddresses", EmitDefaultValue = false)]
        public List<string> BlockedIpOrClassCAddresses { get; set; }

        /// <summary>
        /// Maximum purchase amount limit.
        /// </summary>
        /// <value>Maximum purchase amount limit.</value>
        [DataMember(Name = "maximumPurchaseAmount", EmitDefaultValue = false)]
        public List<MaximumPurchaseAmount> MaximumPurchaseAmount { get; set; }

        /// <summary>
        /// Gets or Sets LockoutTime
        /// </summary>
        [DataMember(Name = "lockoutTime", EmitDefaultValue = false)]
        public LockoutTime LockoutTime { get; set; }

        /// <summary>
        /// Country profile.
        /// </summary>
        /// <value>Country profile.</value>
        [DataMember(Name = "countryProfile", EmitDefaultValue = false)]
        public string CountryProfile { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FraudSettingsResponseAllOf {\n");
            sb.Append("  StoreId: ").Append(StoreId).Append("\n");
            sb.Append("  BlockedCardNumbers: ").Append(BlockedCardNumbers).Append("\n");
            sb.Append("  BlockedNames: ").Append(BlockedNames).Append("\n");
            sb.Append("  BlockedDomainNames: ").Append(BlockedDomainNames).Append("\n");
            sb.Append("  BlockedIpOrClassCAddresses: ").Append(BlockedIpOrClassCAddresses).Append("\n");
            sb.Append("  MaximumPurchaseAmount: ").Append(MaximumPurchaseAmount).Append("\n");
            sb.Append("  LockoutTime: ").Append(LockoutTime).Append("\n");
            sb.Append("  CountryProfile: ").Append(CountryProfile).Append("\n");
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
            return this.Equals(input as FraudSettingsResponseAllOf);
        }

        /// <summary>
        /// Returns true if FraudSettingsResponseAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of FraudSettingsResponseAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FraudSettingsResponseAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StoreId == input.StoreId ||
                    (this.StoreId != null &&
                    this.StoreId.Equals(input.StoreId))
                ) && 
                (
                    this.BlockedCardNumbers == input.BlockedCardNumbers ||
                    this.BlockedCardNumbers != null &&
                    input.BlockedCardNumbers != null &&
                    this.BlockedCardNumbers.SequenceEqual(input.BlockedCardNumbers)
                ) && 
                (
                    this.BlockedNames == input.BlockedNames ||
                    this.BlockedNames != null &&
                    input.BlockedNames != null &&
                    this.BlockedNames.SequenceEqual(input.BlockedNames)
                ) && 
                (
                    this.BlockedDomainNames == input.BlockedDomainNames ||
                    this.BlockedDomainNames != null &&
                    input.BlockedDomainNames != null &&
                    this.BlockedDomainNames.SequenceEqual(input.BlockedDomainNames)
                ) && 
                (
                    this.BlockedIpOrClassCAddresses == input.BlockedIpOrClassCAddresses ||
                    this.BlockedIpOrClassCAddresses != null &&
                    input.BlockedIpOrClassCAddresses != null &&
                    this.BlockedIpOrClassCAddresses.SequenceEqual(input.BlockedIpOrClassCAddresses)
                ) && 
                (
                    this.MaximumPurchaseAmount == input.MaximumPurchaseAmount ||
                    this.MaximumPurchaseAmount != null &&
                    input.MaximumPurchaseAmount != null &&
                    this.MaximumPurchaseAmount.SequenceEqual(input.MaximumPurchaseAmount)
                ) && 
                (
                    this.LockoutTime == input.LockoutTime ||
                    (this.LockoutTime != null &&
                    this.LockoutTime.Equals(input.LockoutTime))
                ) && 
                (
                    this.CountryProfile == input.CountryProfile ||
                    (this.CountryProfile != null &&
                    this.CountryProfile.Equals(input.CountryProfile))
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
                if (this.StoreId != null)
                    hashCode = hashCode * 59 + this.StoreId.GetHashCode();
                if (this.BlockedCardNumbers != null)
                    hashCode = hashCode * 59 + this.BlockedCardNumbers.GetHashCode();
                if (this.BlockedNames != null)
                    hashCode = hashCode * 59 + this.BlockedNames.GetHashCode();
                if (this.BlockedDomainNames != null)
                    hashCode = hashCode * 59 + this.BlockedDomainNames.GetHashCode();
                if (this.BlockedIpOrClassCAddresses != null)
                    hashCode = hashCode * 59 + this.BlockedIpOrClassCAddresses.GetHashCode();
                if (this.MaximumPurchaseAmount != null)
                    hashCode = hashCode * 59 + this.MaximumPurchaseAmount.GetHashCode();
                if (this.LockoutTime != null)
                    hashCode = hashCode * 59 + this.LockoutTime.GetHashCode();
                if (this.CountryProfile != null)
                    hashCode = hashCode * 59 + this.CountryProfile.GetHashCode();
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
