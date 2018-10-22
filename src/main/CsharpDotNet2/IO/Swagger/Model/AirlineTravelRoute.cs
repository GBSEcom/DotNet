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
  public class AirlineTravelRoute {
    /// <summary>
    /// Date of departure
    /// </summary>
    /// <value>Date of departure</value>
    [DataMember(Name="departureDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "departureDate")]
    public DateTime? DepartureDate { get; set; }

    /// <summary>
    /// Gets or Sets Origin
    /// </summary>
    [DataMember(Name="origin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "origin")]
    public string Origin { get; set; }

    /// <summary>
    /// Gets or Sets Destination
    /// </summary>
    [DataMember(Name="destination", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "destination")]
    public string Destination { get; set; }

    /// <summary>
    /// Gets or Sets CarrierCode
    /// </summary>
    [DataMember(Name="carrierCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "carrierCode")]
    public string CarrierCode { get; set; }

    /// <summary>
    /// Gets or Sets ServiceClass
    /// </summary>
    [DataMember(Name="serviceClass", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "serviceClass")]
    public string ServiceClass { get; set; }

    /// <summary>
    /// Gets or Sets StopoverType
    /// </summary>
    [DataMember(Name="stopoverType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stopoverType")]
    public string StopoverType { get; set; }

    /// <summary>
    /// Gets or Sets FareBasisCode
    /// </summary>
    [DataMember(Name="fareBasisCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fareBasisCode")]
    public string FareBasisCode { get; set; }

    /// <summary>
    /// Gets or Sets DepartureTax
    /// </summary>
    [DataMember(Name="departureTax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "departureTax")]
    public decimal? DepartureTax { get; set; }

    /// <summary>
    /// Gets or Sets FlightNumber
    /// </summary>
    [DataMember(Name="flightNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "flightNumber")]
    public string FlightNumber { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AirlineTravelRoute {\n");
      sb.Append("  DepartureDate: ").Append(DepartureDate).Append("\n");
      sb.Append("  Origin: ").Append(Origin).Append("\n");
      sb.Append("  Destination: ").Append(Destination).Append("\n");
      sb.Append("  CarrierCode: ").Append(CarrierCode).Append("\n");
      sb.Append("  ServiceClass: ").Append(ServiceClass).Append("\n");
      sb.Append("  StopoverType: ").Append(StopoverType).Append("\n");
      sb.Append("  FareBasisCode: ").Append(FareBasisCode).Append("\n");
      sb.Append("  DepartureTax: ").Append(DepartureTax).Append("\n");
      sb.Append("  FlightNumber: ").Append(FlightNumber).Append("\n");
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
