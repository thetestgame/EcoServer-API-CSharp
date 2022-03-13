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
    /// EcoWebServerDataTransferObjectsWorldLayersWorldLayerDTO
    /// </summary>
    [DataContract]
    public partial class EcoWebServerDataTransferObjectsWorldLayersWorldLayerDTO :  IEquatable<EcoWebServerDataTransferObjectsWorldLayersWorldLayerDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EcoWebServerDataTransferObjectsWorldLayersWorldLayerDTO" /> class.
        /// </summary>
        /// <param name="layerName">layerName.</param>
        /// <param name="layerDisplayName">layerDisplayName.</param>
        /// <param name="summary">summary.</param>
        /// <param name="tooltip">tooltip.</param>
        /// <param name="category">category.</param>
        /// <param name="displayRow">displayRow.</param>
        public EcoWebServerDataTransferObjectsWorldLayersWorldLayerDTO(string layerName = default(string), string layerDisplayName = default(string), string summary = default(string), string tooltip = default(string), string category = default(string), int? displayRow = default(int?))
        {
            this.LayerName = layerName;
            this.LayerDisplayName = layerDisplayName;
            this.Summary = summary;
            this.Tooltip = tooltip;
            this.Category = category;
            this.DisplayRow = displayRow;
        }
        
        /// <summary>
        /// Gets or Sets LayerName
        /// </summary>
        [DataMember(Name="layerName", EmitDefaultValue=false)]
        public string LayerName { get; set; }

        /// <summary>
        /// Gets or Sets LayerDisplayName
        /// </summary>
        [DataMember(Name="layerDisplayName", EmitDefaultValue=false)]
        public string LayerDisplayName { get; set; }

        /// <summary>
        /// Gets or Sets Summary
        /// </summary>
        [DataMember(Name="summary", EmitDefaultValue=false)]
        public string Summary { get; set; }

        /// <summary>
        /// Gets or Sets Tooltip
        /// </summary>
        [DataMember(Name="tooltip", EmitDefaultValue=false)]
        public string Tooltip { get; set; }

        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public string Category { get; set; }

        /// <summary>
        /// Gets or Sets DisplayRow
        /// </summary>
        [DataMember(Name="displayRow", EmitDefaultValue=false)]
        public int? DisplayRow { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EcoWebServerDataTransferObjectsWorldLayersWorldLayerDTO {\n");
            sb.Append("  LayerName: ").Append(LayerName).Append("\n");
            sb.Append("  LayerDisplayName: ").Append(LayerDisplayName).Append("\n");
            sb.Append("  Summary: ").Append(Summary).Append("\n");
            sb.Append("  Tooltip: ").Append(Tooltip).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  DisplayRow: ").Append(DisplayRow).Append("\n");
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
            return this.Equals(input as EcoWebServerDataTransferObjectsWorldLayersWorldLayerDTO);
        }

        /// <summary>
        /// Returns true if EcoWebServerDataTransferObjectsWorldLayersWorldLayerDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of EcoWebServerDataTransferObjectsWorldLayersWorldLayerDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EcoWebServerDataTransferObjectsWorldLayersWorldLayerDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LayerName == input.LayerName ||
                    (this.LayerName != null &&
                    this.LayerName.Equals(input.LayerName))
                ) && 
                (
                    this.LayerDisplayName == input.LayerDisplayName ||
                    (this.LayerDisplayName != null &&
                    this.LayerDisplayName.Equals(input.LayerDisplayName))
                ) && 
                (
                    this.Summary == input.Summary ||
                    (this.Summary != null &&
                    this.Summary.Equals(input.Summary))
                ) && 
                (
                    this.Tooltip == input.Tooltip ||
                    (this.Tooltip != null &&
                    this.Tooltip.Equals(input.Tooltip))
                ) && 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.DisplayRow == input.DisplayRow ||
                    (this.DisplayRow != null &&
                    this.DisplayRow.Equals(input.DisplayRow))
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
                if (this.LayerName != null)
                    hashCode = hashCode * 59 + this.LayerName.GetHashCode();
                if (this.LayerDisplayName != null)
                    hashCode = hashCode * 59 + this.LayerDisplayName.GetHashCode();
                if (this.Summary != null)
                    hashCode = hashCode * 59 + this.Summary.GetHashCode();
                if (this.Tooltip != null)
                    hashCode = hashCode * 59 + this.Tooltip.GetHashCode();
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.DisplayRow != null)
                    hashCode = hashCode * 59 + this.DisplayRow.GetHashCode();
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
