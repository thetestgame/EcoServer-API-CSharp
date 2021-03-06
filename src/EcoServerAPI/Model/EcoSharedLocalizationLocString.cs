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
    /// EcoSharedLocalizationLocString
    /// </summary>
    [DataContract]
    public partial class EcoSharedLocalizationLocString :  IEquatable<EcoSharedLocalizationLocString>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EcoSharedLocalizationLocString" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public EcoSharedLocalizationLocString()
        {
        }
        
        /// <summary>
        /// Gets or Sets NotTranslated
        /// </summary>
        [DataMember(Name="notTranslated", EmitDefaultValue=false)]
        public string NotTranslated { get; private set; }

        /// <summary>
        /// Gets or Sets Inlinable
        /// </summary>
        [DataMember(Name="inlinable", EmitDefaultValue=false)]
        public bool? Inlinable { get; private set; }

        /// <summary>
        /// Gets or Sets Length
        /// </summary>
        [DataMember(Name="length", EmitDefaultValue=false)]
        public int? Length { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EcoSharedLocalizationLocString {\n");
            sb.Append("  NotTranslated: ").Append(NotTranslated).Append("\n");
            sb.Append("  Inlinable: ").Append(Inlinable).Append("\n");
            sb.Append("  Length: ").Append(Length).Append("\n");
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
            return this.Equals(input as EcoSharedLocalizationLocString);
        }

        /// <summary>
        /// Returns true if EcoSharedLocalizationLocString instances are equal
        /// </summary>
        /// <param name="input">Instance of EcoSharedLocalizationLocString to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EcoSharedLocalizationLocString input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NotTranslated == input.NotTranslated ||
                    (this.NotTranslated != null &&
                    this.NotTranslated.Equals(input.NotTranslated))
                ) && 
                (
                    this.Inlinable == input.Inlinable ||
                    (this.Inlinable != null &&
                    this.Inlinable.Equals(input.Inlinable))
                ) && 
                (
                    this.Length == input.Length ||
                    (this.Length != null &&
                    this.Length.Equals(input.Length))
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
                if (this.NotTranslated != null)
                    hashCode = hashCode * 59 + this.NotTranslated.GetHashCode();
                if (this.Inlinable != null)
                    hashCode = hashCode * 59 + this.Inlinable.GetHashCode();
                if (this.Length != null)
                    hashCode = hashCode * 59 + this.Length.GetHashCode();
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
