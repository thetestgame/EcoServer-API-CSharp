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
    /// EcoWebServerDataTransferObjectsElectedTitleDTO
    /// </summary>
    [DataContract]
    public partial class EcoWebServerDataTransferObjectsElectedTitleDTO :  IEquatable<EcoWebServerDataTransferObjectsElectedTitleDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EcoWebServerDataTransferObjectsElectedTitleDTO" /> class.
        /// </summary>
        /// <param name="occupantNames">occupantNames.</param>
        public EcoWebServerDataTransferObjectsElectedTitleDTO(List<string> occupantNames = default(List<string>))
        {
            this.OccupantNames = occupantNames;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; private set; }

        /// <summary>
        /// Gets or Sets UserDescription
        /// </summary>
        [DataMember(Name="userDescription", EmitDefaultValue=false)]
        public string UserDescription { get; private set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; private set; }

        /// <summary>
        /// Gets or Sets Creator
        /// </summary>
        [DataMember(Name="creator", EmitDefaultValue=false)]
        public string Creator { get; private set; }

        /// <summary>
        /// Gets or Sets OccupantNames
        /// </summary>
        [DataMember(Name="occupantNames", EmitDefaultValue=false)]
        public List<string> OccupantNames { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EcoWebServerDataTransferObjectsElectedTitleDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  UserDescription: ").Append(UserDescription).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Creator: ").Append(Creator).Append("\n");
            sb.Append("  OccupantNames: ").Append(OccupantNames).Append("\n");
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
            return this.Equals(input as EcoWebServerDataTransferObjectsElectedTitleDTO);
        }

        /// <summary>
        /// Returns true if EcoWebServerDataTransferObjectsElectedTitleDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of EcoWebServerDataTransferObjectsElectedTitleDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EcoWebServerDataTransferObjectsElectedTitleDTO input)
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
                    this.UserDescription == input.UserDescription ||
                    (this.UserDescription != null &&
                    this.UserDescription.Equals(input.UserDescription))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.Creator == input.Creator ||
                    (this.Creator != null &&
                    this.Creator.Equals(input.Creator))
                ) && 
                (
                    this.OccupantNames == input.OccupantNames ||
                    this.OccupantNames != null &&
                    this.OccupantNames.SequenceEqual(input.OccupantNames)
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
                if (this.UserDescription != null)
                    hashCode = hashCode * 59 + this.UserDescription.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Creator != null)
                    hashCode = hashCode * 59 + this.Creator.GetHashCode();
                if (this.OccupantNames != null)
                    hashCode = hashCode * 59 + this.OccupantNames.GetHashCode();
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
