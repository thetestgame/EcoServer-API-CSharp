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
    /// EcoWebServerDataTransferObjectsElectionChoiceDTO
    /// </summary>
    [DataContract]
    public partial class EcoWebServerDataTransferObjectsElectionChoiceDTO :  IEquatable<EcoWebServerDataTransferObjectsElectionChoiceDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EcoWebServerDataTransferObjectsElectionChoiceDTO" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="speech">speech.</param>
        public EcoWebServerDataTransferObjectsElectionChoiceDTO(int? id = default(int?), string name = default(string), string speech = default(string))
        {
            this.Id = id;
            this.Name = name;
            this.Speech = speech;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Speech
        /// </summary>
        [DataMember(Name="speech", EmitDefaultValue=false)]
        public string Speech { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EcoWebServerDataTransferObjectsElectionChoiceDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Speech: ").Append(Speech).Append("\n");
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
            return this.Equals(input as EcoWebServerDataTransferObjectsElectionChoiceDTO);
        }

        /// <summary>
        /// Returns true if EcoWebServerDataTransferObjectsElectionChoiceDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of EcoWebServerDataTransferObjectsElectionChoiceDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EcoWebServerDataTransferObjectsElectionChoiceDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Speech == input.Speech ||
                    (this.Speech != null &&
                    this.Speech.Equals(input.Speech))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Speech != null)
                    hashCode = hashCode * 59 + this.Speech.GetHashCode();
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
