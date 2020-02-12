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
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Object that holds information about lockout times.
    /// </summary>
    [DataContract]
    public partial class LockoutTime :  IEquatable<LockoutTime>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LockoutTime" /> class.
        /// </summary>
        /// <param name="autoLockoutTime">Auto-lockout time..</param>
        /// <param name="duplicateLockoutTime">Duplicate lockout time..</param>
        public LockoutTime(int autoLockoutTime = default(int), int duplicateLockoutTime = default(int))
        {
            this.AutoLockoutTime = autoLockoutTime;
            this.DuplicateLockoutTime = duplicateLockoutTime;
        }
        
        /// <summary>
        /// Auto-lockout time.
        /// </summary>
        /// <value>Auto-lockout time.</value>
        [DataMember(Name="autoLockoutTime", EmitDefaultValue=false)]
        public int AutoLockoutTime { get; set; }

        /// <summary>
        /// Duplicate lockout time.
        /// </summary>
        /// <value>Duplicate lockout time.</value>
        [DataMember(Name="duplicateLockoutTime", EmitDefaultValue=false)]
        public int DuplicateLockoutTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LockoutTime {\n");
            sb.Append("  AutoLockoutTime: ").Append(AutoLockoutTime).Append("\n");
            sb.Append("  DuplicateLockoutTime: ").Append(DuplicateLockoutTime).Append("\n");
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
            return this.Equals(input as LockoutTime);
        }

        /// <summary>
        /// Returns true if LockoutTime instances are equal
        /// </summary>
        /// <param name="input">Instance of LockoutTime to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LockoutTime input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AutoLockoutTime == input.AutoLockoutTime ||
                    (this.AutoLockoutTime != null &&
                    this.AutoLockoutTime.Equals(input.AutoLockoutTime))
                ) && 
                (
                    this.DuplicateLockoutTime == input.DuplicateLockoutTime ||
                    (this.DuplicateLockoutTime != null &&
                    this.DuplicateLockoutTime.Equals(input.DuplicateLockoutTime))
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
                if (this.AutoLockoutTime != null)
                    hashCode = hashCode * 59 + this.AutoLockoutTime.GetHashCode();
                if (this.DuplicateLockoutTime != null)
                    hashCode = hashCode * 59 + this.DuplicateLockoutTime.GetHashCode();
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
