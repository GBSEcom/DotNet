/* 
 * Payment Gateway API Specification.
 *
 * The documentation here is designed to provide all of the technical guidance required to consume and integrate with our APIs for payment processing. To learn more about our APIs please visit https://docs.firstdata.com/org/gateway.
 *
 * The version of the OpenAPI document: 6.10.1.20200226.002
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
    /// Object that holds all fraud settings.
    /// </summary>
    [DataContract]
    public partial class FraudSettings :  IEquatable<FraudSettings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FraudSettings" /> class.
        /// </summary>
        /// <param name="blockedItems">blockedItems.</param>
        /// <param name="maximumPurchaseAmount">maximumPurchaseAmount.</param>
        /// <param name="lockoutTime">lockoutTime.</param>
        /// <param name="countryProfile">countryProfile.</param>
        public FraudSettings(BlockedItems blockedItems = default(BlockedItems), List<MaximumPurchaseAmount> maximumPurchaseAmount = default(List<MaximumPurchaseAmount>), LockoutTime lockoutTime = default(LockoutTime), CountryProfile countryProfile = default(CountryProfile))
        {
            this.BlockedItems = blockedItems;
            this.MaximumPurchaseAmount = maximumPurchaseAmount;
            this.LockoutTime = lockoutTime;
            this.CountryProfile = countryProfile;
        }
        
        /// <summary>
        /// Gets or Sets BlockedItems
        /// </summary>
        [DataMember(Name="blockedItems", EmitDefaultValue=false)]
        public BlockedItems BlockedItems { get; set; }

        /// <summary>
        /// Gets or Sets MaximumPurchaseAmount
        /// </summary>
        [DataMember(Name="maximumPurchaseAmount", EmitDefaultValue=false)]
        public List<MaximumPurchaseAmount> MaximumPurchaseAmount { get; set; }

        /// <summary>
        /// Gets or Sets LockoutTime
        /// </summary>
        [DataMember(Name="lockoutTime", EmitDefaultValue=false)]
        public LockoutTime LockoutTime { get; set; }

        /// <summary>
        /// Gets or Sets CountryProfile
        /// </summary>
        [DataMember(Name="countryProfile", EmitDefaultValue=false)]
        public CountryProfile CountryProfile { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FraudSettings {\n");
            sb.Append("  BlockedItems: ").Append(BlockedItems).Append("\n");
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
            return this.Equals(input as FraudSettings);
        }

        /// <summary>
        /// Returns true if FraudSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of FraudSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FraudSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BlockedItems == input.BlockedItems ||
                    (this.BlockedItems != null &&
                    this.BlockedItems.Equals(input.BlockedItems))
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
                if (this.BlockedItems != null)
                    hashCode = hashCode * 59 + this.BlockedItems.GetHashCode();
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