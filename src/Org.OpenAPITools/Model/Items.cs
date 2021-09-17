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
    /// Network information.
    /// </summary>
    [DataContract(Name = "Items")]
    public partial class Items : IEquatable<Items>, IValidatableObject
    {
        /// <summary>
        /// Defines the type of network associated with the device.
        /// </summary>
        /// <value>Defines the type of network associated with the device.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum NetworkTypeEnum
        {
            /// <summary>
            /// Enum Mobile for value: network/mobile
            /// </summary>
            [EnumMember(Value = "network/mobile")]
            Mobile = 1,

            /// <summary>
            /// Enum Wifi for value: network/wifi
            /// </summary>
            [EnumMember(Value = "network/wifi")]
            Wifi = 2

        }


        /// <summary>
        /// Defines the type of network associated with the device.
        /// </summary>
        /// <value>Defines the type of network associated with the device.</value>
        [DataMember(Name = "networkType", IsRequired = true, EmitDefaultValue = false)]
        public NetworkTypeEnum NetworkType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Items" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Items() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Items" /> class.
        /// </summary>
        /// <param name="networkType">Defines the type of network associated with the device. (required).</param>
        /// <param name="ip">The IPv4 or IPv6 address of the device if the network assigned one..</param>
        /// <param name="phoneNumber">The devices primary phone number. This value should be supplied directly without any transformation (e.g. removal of spaces, hyphens or parentheses). If this data is available in segregated fields, it should be concatenated using a blank space (\&quot; \&quot;) as a separator..</param>
        /// <param name="carrierName">The network carrier name..</param>
        /// <param name="mobileCountryCode">The Mobile Country Code (MCC) as described in the ITUs E.212 specification..</param>
        /// <param name="mobileNetworkCode">The Mobile Network Code (MNC) as described in the ITUs E.212 specification..</param>
        /// <param name="subscriptionIdentificationNumber">The Mobile Subscription Identification Number code (MSIN) as described in the ITUs E.212 specification..</param>
        /// <param name="locationAreaCode">The Location Area Code (LAC) is a 16-bit identifier for a region that is covered by a set of network antennas..</param>
        /// <param name="cellId">The Cell ID (CID) is identifier for a specific Base Transceiver Station (BTS) within a specific Location Area Code (LAC)..</param>
        /// <param name="standard">An identifier of the network standard used..</param>
        /// <param name="mac">The MAC address of the device that is connected to the Wi-Fi network..</param>
        /// <param name="ssid">The Wi-Fi networks Service Set Identifier (SSID)..</param>
        /// <param name="bssid">The Wi-Fi networks Basic Service Set Identifier (BSSID)..</param>
        /// <param name="userDefined">A JSON object that can carry any additional information about the network that might be helpful for fraud detection..</param>
        public Items(NetworkTypeEnum networkType = default(NetworkTypeEnum), string ip = default(string), string phoneNumber = default(string), string carrierName = default(string), string mobileCountryCode = default(string), string mobileNetworkCode = default(string), string subscriptionIdentificationNumber = default(string), string locationAreaCode = default(string), string cellId = default(string), string standard = default(string), string mac = default(string), string ssid = default(string), string bssid = default(string), Object userDefined = default(Object))
        {
            this.NetworkType = networkType;
            this.Ip = ip;
            this.PhoneNumber = phoneNumber;
            this.CarrierName = carrierName;
            this.MobileCountryCode = mobileCountryCode;
            this.MobileNetworkCode = mobileNetworkCode;
            this.SubscriptionIdentificationNumber = subscriptionIdentificationNumber;
            this.LocationAreaCode = locationAreaCode;
            this.CellId = cellId;
            this.Standard = standard;
            this.Mac = mac;
            this.Ssid = ssid;
            this.Bssid = bssid;
            this.UserDefined = userDefined;
        }

        /// <summary>
        /// The IPv4 or IPv6 address of the device if the network assigned one.
        /// </summary>
        /// <value>The IPv4 or IPv6 address of the device if the network assigned one.</value>
        [DataMember(Name = "ip", EmitDefaultValue = false)]
        public string Ip { get; set; }

        /// <summary>
        /// The devices primary phone number. This value should be supplied directly without any transformation (e.g. removal of spaces, hyphens or parentheses). If this data is available in segregated fields, it should be concatenated using a blank space (\&quot; \&quot;) as a separator.
        /// </summary>
        /// <value>The devices primary phone number. This value should be supplied directly without any transformation (e.g. removal of spaces, hyphens or parentheses). If this data is available in segregated fields, it should be concatenated using a blank space (\&quot; \&quot;) as a separator.</value>
        [DataMember(Name = "phoneNumber", EmitDefaultValue = false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// The network carrier name.
        /// </summary>
        /// <value>The network carrier name.</value>
        [DataMember(Name = "carrierName", EmitDefaultValue = false)]
        public string CarrierName { get; set; }

        /// <summary>
        /// The Mobile Country Code (MCC) as described in the ITUs E.212 specification.
        /// </summary>
        /// <value>The Mobile Country Code (MCC) as described in the ITUs E.212 specification.</value>
        [DataMember(Name = "mobileCountryCode", EmitDefaultValue = false)]
        public string MobileCountryCode { get; set; }

        /// <summary>
        /// The Mobile Network Code (MNC) as described in the ITUs E.212 specification.
        /// </summary>
        /// <value>The Mobile Network Code (MNC) as described in the ITUs E.212 specification.</value>
        [DataMember(Name = "mobileNetworkCode", EmitDefaultValue = false)]
        public string MobileNetworkCode { get; set; }

        /// <summary>
        /// The Mobile Subscription Identification Number code (MSIN) as described in the ITUs E.212 specification.
        /// </summary>
        /// <value>The Mobile Subscription Identification Number code (MSIN) as described in the ITUs E.212 specification.</value>
        [DataMember(Name = "subscriptionIdentificationNumber", EmitDefaultValue = false)]
        public string SubscriptionIdentificationNumber { get; set; }

        /// <summary>
        /// The Location Area Code (LAC) is a 16-bit identifier for a region that is covered by a set of network antennas.
        /// </summary>
        /// <value>The Location Area Code (LAC) is a 16-bit identifier for a region that is covered by a set of network antennas.</value>
        [DataMember(Name = "locationAreaCode", EmitDefaultValue = false)]
        public string LocationAreaCode { get; set; }

        /// <summary>
        /// The Cell ID (CID) is identifier for a specific Base Transceiver Station (BTS) within a specific Location Area Code (LAC).
        /// </summary>
        /// <value>The Cell ID (CID) is identifier for a specific Base Transceiver Station (BTS) within a specific Location Area Code (LAC).</value>
        [DataMember(Name = "cellId", EmitDefaultValue = false)]
        public string CellId { get; set; }

        /// <summary>
        /// An identifier of the network standard used.
        /// </summary>
        /// <value>An identifier of the network standard used.</value>
        [DataMember(Name = "standard", EmitDefaultValue = false)]
        public string Standard { get; set; }

        /// <summary>
        /// The MAC address of the device that is connected to the Wi-Fi network.
        /// </summary>
        /// <value>The MAC address of the device that is connected to the Wi-Fi network.</value>
        [DataMember(Name = "mac", EmitDefaultValue = false)]
        public string Mac { get; set; }

        /// <summary>
        /// The Wi-Fi networks Service Set Identifier (SSID).
        /// </summary>
        /// <value>The Wi-Fi networks Service Set Identifier (SSID).</value>
        [DataMember(Name = "ssid", EmitDefaultValue = false)]
        public string Ssid { get; set; }

        /// <summary>
        /// The Wi-Fi networks Basic Service Set Identifier (BSSID).
        /// </summary>
        /// <value>The Wi-Fi networks Basic Service Set Identifier (BSSID).</value>
        [DataMember(Name = "bssid", EmitDefaultValue = false)]
        public string Bssid { get; set; }

        /// <summary>
        /// A JSON object that can carry any additional information about the network that might be helpful for fraud detection.
        /// </summary>
        /// <value>A JSON object that can carry any additional information about the network that might be helpful for fraud detection.</value>
        [DataMember(Name = "userDefined", EmitDefaultValue = false)]
        public Object UserDefined { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Items {\n");
            sb.Append("  NetworkType: ").Append(NetworkType).Append("\n");
            sb.Append("  Ip: ").Append(Ip).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  CarrierName: ").Append(CarrierName).Append("\n");
            sb.Append("  MobileCountryCode: ").Append(MobileCountryCode).Append("\n");
            sb.Append("  MobileNetworkCode: ").Append(MobileNetworkCode).Append("\n");
            sb.Append("  SubscriptionIdentificationNumber: ").Append(SubscriptionIdentificationNumber).Append("\n");
            sb.Append("  LocationAreaCode: ").Append(LocationAreaCode).Append("\n");
            sb.Append("  CellId: ").Append(CellId).Append("\n");
            sb.Append("  Standard: ").Append(Standard).Append("\n");
            sb.Append("  Mac: ").Append(Mac).Append("\n");
            sb.Append("  Ssid: ").Append(Ssid).Append("\n");
            sb.Append("  Bssid: ").Append(Bssid).Append("\n");
            sb.Append("  UserDefined: ").Append(UserDefined).Append("\n");
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
            return this.Equals(input as Items);
        }

        /// <summary>
        /// Returns true if Items instances are equal
        /// </summary>
        /// <param name="input">Instance of Items to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Items input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NetworkType == input.NetworkType ||
                    this.NetworkType.Equals(input.NetworkType)
                ) && 
                (
                    this.Ip == input.Ip ||
                    (this.Ip != null &&
                    this.Ip.Equals(input.Ip))
                ) && 
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
                ) && 
                (
                    this.CarrierName == input.CarrierName ||
                    (this.CarrierName != null &&
                    this.CarrierName.Equals(input.CarrierName))
                ) && 
                (
                    this.MobileCountryCode == input.MobileCountryCode ||
                    (this.MobileCountryCode != null &&
                    this.MobileCountryCode.Equals(input.MobileCountryCode))
                ) && 
                (
                    this.MobileNetworkCode == input.MobileNetworkCode ||
                    (this.MobileNetworkCode != null &&
                    this.MobileNetworkCode.Equals(input.MobileNetworkCode))
                ) && 
                (
                    this.SubscriptionIdentificationNumber == input.SubscriptionIdentificationNumber ||
                    (this.SubscriptionIdentificationNumber != null &&
                    this.SubscriptionIdentificationNumber.Equals(input.SubscriptionIdentificationNumber))
                ) && 
                (
                    this.LocationAreaCode == input.LocationAreaCode ||
                    (this.LocationAreaCode != null &&
                    this.LocationAreaCode.Equals(input.LocationAreaCode))
                ) && 
                (
                    this.CellId == input.CellId ||
                    (this.CellId != null &&
                    this.CellId.Equals(input.CellId))
                ) && 
                (
                    this.Standard == input.Standard ||
                    (this.Standard != null &&
                    this.Standard.Equals(input.Standard))
                ) && 
                (
                    this.Mac == input.Mac ||
                    (this.Mac != null &&
                    this.Mac.Equals(input.Mac))
                ) && 
                (
                    this.Ssid == input.Ssid ||
                    (this.Ssid != null &&
                    this.Ssid.Equals(input.Ssid))
                ) && 
                (
                    this.Bssid == input.Bssid ||
                    (this.Bssid != null &&
                    this.Bssid.Equals(input.Bssid))
                ) && 
                (
                    this.UserDefined == input.UserDefined ||
                    (this.UserDefined != null &&
                    this.UserDefined.Equals(input.UserDefined))
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
                hashCode = hashCode * 59 + this.NetworkType.GetHashCode();
                if (this.Ip != null)
                    hashCode = hashCode * 59 + this.Ip.GetHashCode();
                if (this.PhoneNumber != null)
                    hashCode = hashCode * 59 + this.PhoneNumber.GetHashCode();
                if (this.CarrierName != null)
                    hashCode = hashCode * 59 + this.CarrierName.GetHashCode();
                if (this.MobileCountryCode != null)
                    hashCode = hashCode * 59 + this.MobileCountryCode.GetHashCode();
                if (this.MobileNetworkCode != null)
                    hashCode = hashCode * 59 + this.MobileNetworkCode.GetHashCode();
                if (this.SubscriptionIdentificationNumber != null)
                    hashCode = hashCode * 59 + this.SubscriptionIdentificationNumber.GetHashCode();
                if (this.LocationAreaCode != null)
                    hashCode = hashCode * 59 + this.LocationAreaCode.GetHashCode();
                if (this.CellId != null)
                    hashCode = hashCode * 59 + this.CellId.GetHashCode();
                if (this.Standard != null)
                    hashCode = hashCode * 59 + this.Standard.GetHashCode();
                if (this.Mac != null)
                    hashCode = hashCode * 59 + this.Mac.GetHashCode();
                if (this.Ssid != null)
                    hashCode = hashCode * 59 + this.Ssid.GetHashCode();
                if (this.Bssid != null)
                    hashCode = hashCode * 59 + this.Bssid.GetHashCode();
                if (this.UserDefined != null)
                    hashCode = hashCode * 59 + this.UserDefined.GetHashCode();
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
