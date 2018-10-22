using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class Lodging {
    /// <summary>
    /// Date of arrival
    /// </summary>
    /// <value>Date of arrival</value>
    [DataMember(Name="arrivalDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "arrivalDate")]
    public DateTime? ArrivalDate { get; set; }

    /// <summary>
    /// Date of departure
    /// </summary>
    /// <value>Date of departure</value>
    [DataMember(Name="departureDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "departureDate")]
    public DateTime? DepartureDate { get; set; }

    /// <summary>
    /// Portfolio number
    /// </summary>
    /// <value>Portfolio number</value>
    [DataMember(Name="folioNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "folioNumber")]
    public string FolioNumber { get; set; }

    /// <summary>
    /// Gets or Sets ExtraCharges
    /// </summary>
    [DataMember(Name="extraCharges", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "extraCharges")]
    public List<LodgingExtraCharges> ExtraCharges { get; set; }

    /// <summary>
    /// Gets or Sets NoShowIndicator
    /// </summary>
    [DataMember(Name="noShowIndicator", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "noShowIndicator")]
    public bool? NoShowIndicator { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Lodging {\n");
      sb.Append("  ArrivalDate: ").Append(ArrivalDate).Append("\n");
      sb.Append("  DepartureDate: ").Append(DepartureDate).Append("\n");
      sb.Append("  FolioNumber: ").Append(FolioNumber).Append("\n");
      sb.Append("  ExtraCharges: ").Append(ExtraCharges).Append("\n");
      sb.Append("  NoShowIndicator: ").Append(NoShowIndicator).Append("\n");
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
