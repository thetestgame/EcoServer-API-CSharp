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
using SwaggerDateConverter = EcoServerAPI.Client.SwaggerDateConverter;

namespace EcoServerAPI.Model
{
    /// <summary>
    /// EcoStatsStatInfo
    /// </summary>
    [DataContract]
    public partial class EcoStatsStatInfo :  IEquatable<EcoStatsStatInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EcoStatsStatInfo" /> class.
        /// </summary>
        /// <param name="hasValueKey">hasValueKey.</param>
        public EcoStatsStatInfo(bool? hasValueKey = default(bool?))
        {
            this.HasValueKey = hasValueKey;
        }
        
        /// <summary>
        /// Gets or Sets HasValueKey
        /// </summary>
        [DataMember(Name="hasValueKey", EmitDefaultValue=false)]
        public bool? HasValueKey { get; set; }

        /// <summary>
        /// Gets or Sets IsCustom
        /// </summary>
        [DataMember(Name="isCustom", EmitDefaultValue=false)]
        public bool? IsCustom { get; private set; }

        /// <summary>
        /// Gets or Sets IsAction
        /// </summary>
        [DataMember(Name="isAction", EmitDefaultValue=false)]
        public bool? IsAction { get; private set; }

        /// <summary>
        /// Gets or Sets IsCountable
        /// </summary>
        [DataMember(Name="isCountable", EmitDefaultValue=false)]
        public bool? IsCountable { get; private set; }

        /// <summary>
        /// Gets or Sets IsAggregatable
        /// </summary>
        [DataMember(Name="isAggregatable", EmitDefaultValue=false)]
        public bool? IsAggregatable { get; private set; }

        /// <summary>
        /// Gets or Sets TimeKey
        /// </summary>
        [DataMember(Name="timeKey", EmitDefaultValue=false)]
        public string TimeKey { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EcoStatsStatInfo {\n");
            sb.Append("  HasValueKey: ").Append(HasValueKey).Append("\n");
            sb.Append("  IsCustom: ").Append(IsCustom).Append("\n");
            sb.Append("  IsAction: ").Append(IsAction).Append("\n");
            sb.Append("  IsCountable: ").Append(IsCountable).Append("\n");
            sb.Append("  IsAggregatable: ").Append(IsAggregatable).Append("\n");
            sb.Append("  TimeKey: ").Append(TimeKey).Append("\n");
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
            return this.Equals(input as EcoStatsStatInfo);
        }

        /// <summary>
        /// Returns true if EcoStatsStatInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of EcoStatsStatInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EcoStatsStatInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HasValueKey == input.HasValueKey ||
                    (this.HasValueKey != null &&
                    this.HasValueKey.Equals(input.HasValueKey))
                ) && 
                (
                    this.IsCustom == input.IsCustom ||
                    (this.IsCustom != null &&
                    this.IsCustom.Equals(input.IsCustom))
                ) && 
                (
                    this.IsAction == input.IsAction ||
                    (this.IsAction != null &&
                    this.IsAction.Equals(input.IsAction))
                ) && 
                (
                    this.IsCountable == input.IsCountable ||
                    (this.IsCountable != null &&
                    this.IsCountable.Equals(input.IsCountable))
                ) && 
                (
                    this.IsAggregatable == input.IsAggregatable ||
                    (this.IsAggregatable != null &&
                    this.IsAggregatable.Equals(input.IsAggregatable))
                ) && 
                (
                    this.TimeKey == input.TimeKey ||
                    (this.TimeKey != null &&
                    this.TimeKey.Equals(input.TimeKey))
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
                if (this.HasValueKey != null)
                    hashCode = hashCode * 59 + this.HasValueKey.GetHashCode();
                if (this.IsCustom != null)
                    hashCode = hashCode * 59 + this.IsCustom.GetHashCode();
                if (this.IsAction != null)
                    hashCode = hashCode * 59 + this.IsAction.GetHashCode();
                if (this.IsCountable != null)
                    hashCode = hashCode * 59 + this.IsCountable.GetHashCode();
                if (this.IsAggregatable != null)
                    hashCode = hashCode * 59 + this.IsAggregatable.GetHashCode();
                if (this.TimeKey != null)
                    hashCode = hashCode * 59 + this.TimeKey.GetHashCode();
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
