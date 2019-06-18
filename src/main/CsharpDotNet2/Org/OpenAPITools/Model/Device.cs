using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// The device where this transaction originated.
  /// </summary>
  [DataContract]
  public class Device {
    /// <summary>
    /// Defines the type of this object.
    /// </summary>
    /// <value>Defines the type of this object.</value>
    [DataMember(Name="deviceType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deviceType")]
    public string DeviceType { get; set; }

    /// <summary>
    /// The unique ID of the device. Must be unique for the entire system (not just within a specific merchant or industry).
    /// </summary>
    /// <value>The unique ID of the device. Must be unique for the entire system (not just within a specific merchant or industry).</value>
    [DataMember(Name="deviceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deviceId")]
    public string DeviceId { get; set; }

    /// <summary>
    /// Information about the networks associated with the device.
    /// </summary>
    /// <value>Information about the networks associated with the device.</value>
    [DataMember(Name="networks", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "networks")]
    public List<DeviceNetworks> Networks { get; set; }

    /// <summary>
    /// The GPS decimal latitude, ranging from (-90.0 to 90.0) where positive numbers indicate locations North of the equator.
    /// </summary>
    /// <value>The GPS decimal latitude, ranging from (-90.0 to 90.0) where positive numbers indicate locations North of the equator.</value>
    [DataMember(Name="latitude", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "latitude")]
    public decimal? Latitude { get; set; }

    /// <summary>
    /// The GPS decimal longitude, ranging from (-180.0 to 180.0) where positive numbers indicate locations East of the IERS Reference Meridian.
    /// </summary>
    /// <value>The GPS decimal longitude, ranging from (-180.0 to 180.0) where positive numbers indicate locations East of the IERS Reference Meridian.</value>
    [DataMember(Name="longitude", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "longitude")]
    public decimal? Longitude { get; set; }

    /// <summary>
    /// The device's International Mobile Equipment Identity (IMEI) as described in IETF RFC7254.
    /// </summary>
    /// <value>The device's International Mobile Equipment Identity (IMEI) as described in IETF RFC7254.</value>
    [DataMember(Name="imei", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "imei")]
    public string Imei { get; set; }

    /// <summary>
    /// The device's model name.
    /// </summary>
    /// <value>The device's model name.</value>
    [DataMember(Name="model", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "model")]
    public string Model { get; set; }

    /// <summary>
    /// The device's manufacturer.
    /// </summary>
    /// <value>The device's manufacturer.</value>
    [DataMember(Name="manufacturer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "manufacturer")]
    public string Manufacturer { get; set; }

    /// <summary>
    /// The timezone offset from UTC to the devices timezone configuration, specified in the format +hh:mm.
    /// </summary>
    /// <value>The timezone offset from UTC to the devices timezone configuration, specified in the format +hh:mm.</value>
    [DataMember(Name="timezoneOffset", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "timezoneOffset")]
    public string TimezoneOffset { get; set; }

    /// <summary>
    /// A flag indicating that the device has been altered to allow privileged access to users. This flag should only be set to false if a test was performed and the result was negative. Leave unset otherwise.
    /// </summary>
    /// <value>A flag indicating that the device has been altered to allow privileged access to users. This flag should only be set to false if a test was performed and the result was negative. Leave unset otherwise.</value>
    [DataMember(Name="rooted", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rooted")]
    public bool? Rooted { get; set; }

    /// <summary>
    /// A flag indicating that malware was detected on the mobile phone. This flag should only be set to false if a test was performed and the result was negative. Leave unset otherwise.
    /// </summary>
    /// <value>A flag indicating that malware was detected on the mobile phone. This flag should only be set to false if a test was performed and the result was negative. Leave unset otherwise.</value>
    [DataMember(Name="malwareDetected", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "malwareDetected")]
    public bool? MalwareDetected { get; set; }

    /// <summary>
    /// A JSON object that can carry any additional information about the device that might be helpful for fraud detection.
    /// </summary>
    /// <value>A JSON object that can carry any additional information about the device that might be helpful for fraud detection.</value>
    [DataMember(Name="userDefined", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userDefined")]
    public Object UserDefined { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Device {\n");
      sb.Append("  DeviceType: ").Append(DeviceType).Append("\n");
      sb.Append("  DeviceId: ").Append(DeviceId).Append("\n");
      sb.Append("  Networks: ").Append(Networks).Append("\n");
      sb.Append("  Latitude: ").Append(Latitude).Append("\n");
      sb.Append("  Longitude: ").Append(Longitude).Append("\n");
      sb.Append("  Imei: ").Append(Imei).Append("\n");
      sb.Append("  Model: ").Append(Model).Append("\n");
      sb.Append("  Manufacturer: ").Append(Manufacturer).Append("\n");
      sb.Append("  TimezoneOffset: ").Append(TimezoneOffset).Append("\n");
      sb.Append("  Rooted: ").Append(Rooted).Append("\n");
      sb.Append("  MalwareDetected: ").Append(MalwareDetected).Append("\n");
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
