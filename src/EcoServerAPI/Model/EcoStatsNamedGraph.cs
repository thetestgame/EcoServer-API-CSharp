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
    /// EcoStatsNamedGraph
    /// </summary>
    [DataContract]
    public partial class EcoStatsNamedGraph :  IEquatable<EcoStatsNamedGraph>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EcoStatsNamedGraph" /> class.
        /// </summary>
        /// <param name="category">category.</param>
        /// <param name="name">name.</param>
        /// <param name="graph">graph.</param>
        public EcoStatsNamedGraph(EcoSharedLocalizationLocString category = default(EcoSharedLocalizationLocString), EcoSharedLocalizationLocString name = default(EcoSharedLocalizationLocString), EcoStatsGraph graph = default(EcoStatsGraph))
        {
            this.Category = category;
            this.Name = name;
            this.Graph = graph;
        }
        
        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public EcoSharedLocalizationLocString Category { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public EcoSharedLocalizationLocString Name { get; set; }

        /// <summary>
        /// Gets or Sets Graph
        /// </summary>
        [DataMember(Name="graph", EmitDefaultValue=false)]
        public EcoStatsGraph Graph { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EcoStatsNamedGraph {\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Graph: ").Append(Graph).Append("\n");
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
            return this.Equals(input as EcoStatsNamedGraph);
        }

        /// <summary>
        /// Returns true if EcoStatsNamedGraph instances are equal
        /// </summary>
        /// <param name="input">Instance of EcoStatsNamedGraph to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EcoStatsNamedGraph input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Graph == input.Graph ||
                    (this.Graph != null &&
                    this.Graph.Equals(input.Graph))
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
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Graph != null)
                    hashCode = hashCode * 59 + this.Graph.GetHashCode();
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
