/* 
 * Payment Gateway API Specification.
 *
 * The documentation here is designed to provide all of the technical guidance required to consume and integrate with our APIs for payment processing. To learn more about our APIs please visit https://docs.firstdata.com/org/gateway.
 *
 * The version of the OpenAPI document: 21.3.0.20210608.001
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
    /// LodgingExtraCharges
    /// </summary>
    [DataContract]
    public partial class LodgingExtraCharges : IEquatable<LodgingExtraCharges>, IValidatableObject
    {
        /// <summary>
        /// Defines ChargeItem
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ChargeItemEnum
        {
            /// <summary>
            /// Enum GIFTSHOP for value: GIFT_SHOP
            /// </summary>
            [EnumMember(Value = "GIFT_SHOP")]
            GIFTSHOP = 1,

            /// <summary>
            /// Enum LAUNDRY for value: LAUNDRY
            /// </summary>
            [EnumMember(Value = "LAUNDRY")]
            LAUNDRY = 2,

            /// <summary>
            /// Enum MINIBAR for value: MINI_BAR
            /// </summary>
            [EnumMember(Value = "MINI_BAR")]
            MINIBAR = 3,

            /// <summary>
            /// Enum RESTAURANT for value: RESTAURANT
            /// </summary>
            [EnumMember(Value = "RESTAURANT")]
            RESTAURANT = 4,

            /// <summary>
            /// Enum TELEPHONE for value: TELEPHONE
            /// </summary>
            [EnumMember(Value = "TELEPHONE")]
            TELEPHONE = 5,

            /// <summary>
            /// Enum OTHER for value: OTHER
            /// </summary>
            [EnumMember(Value = "OTHER")]
            OTHER = 6

        }

        /// <summary>
        /// Gets or Sets ChargeItem
        /// </summary>
        [DataMember(Name = "chargeItem", EmitDefaultValue = false)]
        public ChargeItemEnum? ChargeItem { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LodgingExtraCharges" /> class.
        /// </summary>
        /// <param name="chargeItem">chargeItem.</param>
        public LodgingExtraCharges(ChargeItemEnum? chargeItem = null)
        {
            this.ChargeItem = chargeItem;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LodgingExtraCharges {\n");
            sb.Append("  ChargeItem: ").Append(ChargeItem).Append("\n");
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
            return this.Equals(input as LodgingExtraCharges);
        }

        /// <summary>
        /// Returns true if LodgingExtraCharges instances are equal
        /// </summary>
        /// <param name="input">Instance of LodgingExtraCharges to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LodgingExtraCharges input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ChargeItem == input.ChargeItem ||
                    (this.ChargeItem != null &&
                    this.ChargeItem.Equals(input.ChargeItem))
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
                if (this.ChargeItem != null)
                    hashCode = hashCode * 59 + this.ChargeItem.GetHashCode();
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
