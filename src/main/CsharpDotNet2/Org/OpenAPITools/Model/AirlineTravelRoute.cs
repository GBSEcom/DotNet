using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Object holding additional information about the route
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
    /// The IATA code for the departure airport.
    /// </summary>
    /// <value>The IATA code for the departure airport.</value>
    [DataMember(Name="origin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "origin")]
    public string Origin { get; set; }

    /// <summary>
    /// The IATA code for the destination airport.
    /// </summary>
    /// <value>The IATA code for the destination airport.</value>
    [DataMember(Name="destination", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "destination")]
    public string Destination { get; set; }

    /// <summary>
    /// The IATA code for the carrier.
    /// </summary>
    /// <value>The IATA code for the carrier.</value>
    [DataMember(Name="carrierCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "carrierCode")]
    public string CarrierCode { get; set; }

    /// <summary>
    /// The airline code for the service class of the ticket.
    /// </summary>
    /// <value>The airline code for the service class of the ticket.</value>
    [DataMember(Name="serviceClass", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "serviceClass")]
    public string ServiceClass { get; set; }

    /// <summary>
    /// Indicates whether the route is direct or not.
    /// </summary>
    /// <value>Indicates whether the route is direct or not.</value>
    [DataMember(Name="stopoverType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stopoverType")]
    public string StopoverType { get; set; }

    /// <summary>
    /// The airline fare basis code.
    /// </summary>
    /// <value>The airline fare basis code.</value>
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
    /// The airline flight number associated with the ticket.
    /// </summary>
    /// <value>The airline flight number associated with the ticket.</value>
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
