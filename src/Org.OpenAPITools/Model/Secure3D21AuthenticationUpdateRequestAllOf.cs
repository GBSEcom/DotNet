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
    /// Secure3D21AuthenticationUpdateRequestAllOf
    /// </summary>
    [DataContract]
    public partial class Secure3D21AuthenticationUpdateRequestAllOf : IEquatable<Secure3D21AuthenticationUpdateRequestAllOf>, IValidatableObject
    {
        /// <summary>
        /// Indicates how the merchant received the 3DS method.
        /// </summary>
        /// <value>Indicates how the merchant received the 3DS method.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MethodNotificationStatusEnum
        {
            /// <summary>
            /// Enum RECEIVED for value: RECEIVED
            /// </summary>
            [EnumMember(Value = "RECEIVED")]
            RECEIVED = 1,

            /// <summary>
            /// Enum EXPECTEDBUTNOTRECEIVED for value: EXPECTED_BUT_NOT_RECEIVED
            /// </summary>
            [EnumMember(Value = "EXPECTED_BUT_NOT_RECEIVED")]
            EXPECTEDBUTNOTRECEIVED = 2,

            /// <summary>
            /// Enum NOTEXPECTED for value: NOT_EXPECTED
            /// </summary>
            [EnumMember(Value = "NOT_EXPECTED")]
            NOTEXPECTED = 3

        }

        /// <summary>
        /// Indicates how the merchant received the 3DS method.
        /// </summary>
        /// <value>Indicates how the merchant received the 3DS method.</value>
        [DataMember(Name = "methodNotificationStatus", EmitDefaultValue = false)]
        public MethodNotificationStatusEnum? MethodNotificationStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Secure3D21AuthenticationUpdateRequestAllOf" /> class.
        /// </summary>
        /// <param name="methodNotificationStatus">Indicates how the merchant received the 3DS method..</param>
        /// <param name="acsResponse">acsResponse.</param>
        public Secure3D21AuthenticationUpdateRequestAllOf(MethodNotificationStatusEnum? methodNotificationStatus = null, ACSResponse acsResponse = default(ACSResponse))
        {
            this.MethodNotificationStatus = methodNotificationStatus;
            this.AcsResponse = acsResponse;
        }

        /// <summary>
        /// Gets or Sets AcsResponse
        /// </summary>
        [DataMember(Name = "acsResponse", EmitDefaultValue = false)]
        public ACSResponse AcsResponse { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Secure3D21AuthenticationUpdateRequestAllOf {\n");
            sb.Append("  MethodNotificationStatus: ").Append(MethodNotificationStatus).Append("\n");
            sb.Append("  AcsResponse: ").Append(AcsResponse).Append("\n");
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
            return this.Equals(input as Secure3D21AuthenticationUpdateRequestAllOf);
        }

        /// <summary>
        /// Returns true if Secure3D21AuthenticationUpdateRequestAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of Secure3D21AuthenticationUpdateRequestAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Secure3D21AuthenticationUpdateRequestAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MethodNotificationStatus == input.MethodNotificationStatus ||
                    this.MethodNotificationStatus.Equals(input.MethodNotificationStatus)
                ) && 
                (
                    this.AcsResponse == input.AcsResponse ||
                    (this.AcsResponse != null &&
                    this.AcsResponse.Equals(input.AcsResponse))
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
                hashCode = hashCode * 59 + this.MethodNotificationStatus.GetHashCode();
                if (this.AcsResponse != null)
                    hashCode = hashCode * 59 + this.AcsResponse.GetHashCode();
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
