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
    /// EcoWebServerDataTransferObjectsMapStats
    /// </summary>
    [DataContract]
    public partial class EcoWebServerDataTransferObjectsMapStats :  IEquatable<EcoWebServerDataTransferObjectsMapStats>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EcoWebServerDataTransferObjectsMapStats" /> class.
        /// </summary>
        /// <param name="size">size.</param>
        public EcoWebServerDataTransferObjectsMapStats(EcoSharedMathVector3i size = default(EcoSharedMathVector3i))
        {
            this.Size = size;
        }
        
        /// <summary>
        /// Gets or Sets Size
        /// </summary>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public EcoSharedMathVector3i Size { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EcoWebServerDataTransferObjectsMapStats {\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
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
            return this.Equals(input as EcoWebServerDataTransferObjectsMapStats);
        }

        /// <summary>
        /// Returns true if EcoWebServerDataTransferObjectsMapStats instances are equal
        /// </summary>
        /// <param name="input">Instance of EcoWebServerDataTransferObjectsMapStats to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EcoWebServerDataTransferObjectsMapStats input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
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
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
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
