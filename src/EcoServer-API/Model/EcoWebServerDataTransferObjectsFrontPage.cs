/* 
 * Eco Game API
 *
 * First API draft for Eco. Heavy work in progress and subject to changes.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using SwaggerDateConverter = EcoServer-API.Client.SwaggerDateConverter;

namespace EcoServer-API.Model
{
    /// <summary>
    /// EcoWebServerDataTransferObjectsFrontPage
    /// </summary>
    [DataContract]
    public partial class EcoWebServerDataTransferObjectsFrontPage :  IEquatable<EcoWebServerDataTransferObjectsFrontPage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EcoWebServerDataTransferObjectsFrontPage" /> class.
        /// </summary>
        /// <param name="info">info.</param>
        public EcoWebServerDataTransferObjectsFrontPage(EcoSharedNetworkingServerInfo info = default(EcoSharedNetworkingServerInfo))
        {
            this.Info = info;
        }
        
        /// <summary>
        /// Gets or Sets Info
        /// </summary>
        [DataMember(Name="info", EmitDefaultValue=false)]
        public EcoSharedNetworkingServerInfo Info { get; set; }

        /// <summary>
        /// Gets or Sets Graphs
        /// </summary>
        [DataMember(Name="graphs", EmitDefaultValue=false)]
        public List<EcoStatsNamedGraph> Graphs { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EcoWebServerDataTransferObjectsFrontPage {\n");
            sb.Append("  Info: ").Append(Info).Append("\n");
            sb.Append("  Graphs: ").Append(Graphs).Append("\n");
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
            return this.Equals(input as EcoWebServerDataTransferObjectsFrontPage);
        }

        /// <summary>
        /// Returns true if EcoWebServerDataTransferObjectsFrontPage instances are equal
        /// </summary>
        /// <param name="input">Instance of EcoWebServerDataTransferObjectsFrontPage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EcoWebServerDataTransferObjectsFrontPage input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Info == input.Info ||
                    (this.Info != null &&
                    this.Info.Equals(input.Info))
                ) && 
                (
                    this.Graphs == input.Graphs ||
                    this.Graphs != null &&
                    this.Graphs.SequenceEqual(input.Graphs)
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
                if (this.Info != null)
                    hashCode = hashCode * 59 + this.Info.GetHashCode();
                if (this.Graphs != null)
                    hashCode = hashCode * 59 + this.Graphs.GetHashCode();
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
