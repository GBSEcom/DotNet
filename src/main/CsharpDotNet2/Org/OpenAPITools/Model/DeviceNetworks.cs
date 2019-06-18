using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Network information.
  /// </summary>
  [DataContract]
  public class DeviceNetworks {
    /// <summary>
    /// Defines the type of network associated with the device.
    /// </summary>
    /// <value>Defines the type of network associated with the device.</value>
    [DataMember(Name="networkType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "networkType")]
    public string NetworkType { get; set; }

    /// <summary>
    /// The IPv4 or IPv6 address of the device if the network assigned one.
    /// </summary>
    /// <value>The IPv4 or IPv6 address of the device if the network assigned one.</value>
    [DataMember(Name="ip", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ip")]
    public string Ip { get; set; }

    /// <summary>
    /// The devices primary phone number. This value should be supplied directly without any transformation (e.g. removal of spaces, hyphens or parentheses). If this data is available in segregated fields, it should be concatenated using a blank space (\" \") as a separator.
    /// </summary>
    /// <value>The devices primary phone number. This value should be supplied directly without any transformation (e.g. removal of spaces, hyphens or parentheses). If this data is available in segregated fields, it should be concatenated using a blank space (\" \") as a separator.</value>
    [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "phoneNumber")]
    public string PhoneNumber { get; set; }

    /// <summary>
    /// The network carrier name.
    /// </summary>
    /// <value>The network carrier name.</value>
    [DataMember(Name="carrierName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "carrierName")]
    public string CarrierName { get; set; }

    /// <summary>
    /// The Mobile Country Code (MCC) as described in the ITUs E.212 specification.
    /// </summary>
    /// <value>The Mobile Country Code (MCC) as described in the ITUs E.212 specification.</value>
    [DataMember(Name="mobileCountryCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mobileCountryCode")]
    public string MobileCountryCode { get; set; }

    /// <summary>
    /// The Mobile Network Code (MNC) as described in the ITUs E.212 specification.
    /// </summary>
    /// <value>The Mobile Network Code (MNC) as described in the ITUs E.212 specification.</value>
    [DataMember(Name="mobileNetworkCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mobileNetworkCode")]
    public string MobileNetworkCode { get; set; }

    /// <summary>
    /// The Mobile Subscription Identification Number code (MSIN) as described in the ITUs E.212 specification.
    /// </summary>
    /// <value>The Mobile Subscription Identification Number code (MSIN) as described in the ITUs E.212 specification.</value>
    [DataMember(Name="subscriptionIdentificationNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subscriptionIdentificationNumber")]
    public string SubscriptionIdentificationNumber { get; set; }

    /// <summary>
    /// The Location Area Code (LAC) is a 16-bit identifier for a region that is covered by a set of network antennas.
    /// </summary>
    /// <value>The Location Area Code (LAC) is a 16-bit identifier for a region that is covered by a set of network antennas.</value>
    [DataMember(Name="locationAreaCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "locationAreaCode")]
    public string LocationAreaCode { get; set; }

    /// <summary>
    /// The Cell ID (CID) is identifier for a specific Base Transceiver Station (BTS) within a specific Location Area Code (LAC).
    /// </summary>
    /// <value>The Cell ID (CID) is identifier for a specific Base Transceiver Station (BTS) within a specific Location Area Code (LAC).</value>
    [DataMember(Name="cellId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cellId")]
    public string CellId { get; set; }

    /// <summary>
    /// An identifier of the network standard used.
    /// </summary>
    /// <value>An identifier of the network standard used.</value>
    [DataMember(Name="standard", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "standard")]
    public string Standard { get; set; }

    /// <summary>
    /// The MAC address of the device that is connected to the Wi-Fi network.
    /// </summary>
    /// <value>The MAC address of the device that is connected to the Wi-Fi network.</value>
    [DataMember(Name="mac", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mac")]
    public string Mac { get; set; }

    /// <summary>
    /// The Wi-Fi networks Service Set Identifier (SSID).
    /// </summary>
    /// <value>The Wi-Fi networks Service Set Identifier (SSID).</value>
    [DataMember(Name="ssid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ssid")]
    public string Ssid { get; set; }

    /// <summary>
    /// The Wi-Fi networks Basic Service Set Identifier (BSSID).
    /// </summary>
    /// <value>The Wi-Fi networks Basic Service Set Identifier (BSSID).</value>
    [DataMember(Name="bssid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bssid")]
    public string Bssid { get; set; }

    /// <summary>
    /// A JSON object that can carry any additional information about the network that might be helpful for fraud detection.
    /// </summary>
    /// <value>A JSON object that can carry any additional information about the network that might be helpful for fraud detection.</value>
    [DataMember(Name="userDefined", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userDefined")]
    public Object UserDefined { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DeviceNetworks {\n");
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
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
