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
    /// EcoWebServerDataTransferObjectsElectionResultsDTO
    /// </summary>
    [DataContract]
    public partial class EcoWebServerDataTransferObjectsElectionResultsDTO :  IEquatable<EcoWebServerDataTransferObjectsElectionResultsDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EcoWebServerDataTransferObjectsElectionResultsDTO" /> class.
        /// </summary>
        /// <param name="choiceRanks">choiceRanks.</param>
        /// <param name="totalVotesForWinner">totalVotesForWinner.</param>
        /// <param name="winners">winners.</param>
        /// <param name="result">result.</param>
        /// <param name="finished">finished.</param>
        public EcoWebServerDataTransferObjectsElectionResultsDTO(List<EcoGameplayCivicsElectionsChoiceResults> choiceRanks = default(List<EcoGameplayCivicsElectionsChoiceResults>), int? totalVotesForWinner = default(int?), List<string> winners = default(List<string>), string result = default(string), bool? finished = default(bool?))
        {
            this.ChoiceRanks = choiceRanks;
            this.TotalVotesForWinner = totalVotesForWinner;
            this.Winners = winners;
            this.Result = result;
            this.Finished = finished;
        }
        
        /// <summary>
        /// Gets or Sets ChoiceRanks
        /// </summary>
        [DataMember(Name="choiceRanks", EmitDefaultValue=false)]
        public List<EcoGameplayCivicsElectionsChoiceResults> ChoiceRanks { get; set; }

        /// <summary>
        /// Gets or Sets TotalVotesForWinner
        /// </summary>
        [DataMember(Name="totalVotesForWinner", EmitDefaultValue=false)]
        public int? TotalVotesForWinner { get; set; }

        /// <summary>
        /// Gets or Sets Winners
        /// </summary>
        [DataMember(Name="winners", EmitDefaultValue=false)]
        public List<string> Winners { get; set; }

        /// <summary>
        /// Gets or Sets Result
        /// </summary>
        [DataMember(Name="result", EmitDefaultValue=false)]
        public string Result { get; set; }

        /// <summary>
        /// Gets or Sets Finished
        /// </summary>
        [DataMember(Name="finished", EmitDefaultValue=false)]
        public bool? Finished { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EcoWebServerDataTransferObjectsElectionResultsDTO {\n");
            sb.Append("  ChoiceRanks: ").Append(ChoiceRanks).Append("\n");
            sb.Append("  TotalVotesForWinner: ").Append(TotalVotesForWinner).Append("\n");
            sb.Append("  Winners: ").Append(Winners).Append("\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
            sb.Append("  Finished: ").Append(Finished).Append("\n");
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
            return this.Equals(input as EcoWebServerDataTransferObjectsElectionResultsDTO);
        }

        /// <summary>
        /// Returns true if EcoWebServerDataTransferObjectsElectionResultsDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of EcoWebServerDataTransferObjectsElectionResultsDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EcoWebServerDataTransferObjectsElectionResultsDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ChoiceRanks == input.ChoiceRanks ||
                    this.ChoiceRanks != null &&
                    this.ChoiceRanks.SequenceEqual(input.ChoiceRanks)
                ) && 
                (
                    this.TotalVotesForWinner == input.TotalVotesForWinner ||
                    (this.TotalVotesForWinner != null &&
                    this.TotalVotesForWinner.Equals(input.TotalVotesForWinner))
                ) && 
                (
                    this.Winners == input.Winners ||
                    this.Winners != null &&
                    this.Winners.SequenceEqual(input.Winners)
                ) && 
                (
                    this.Result == input.Result ||
                    (this.Result != null &&
                    this.Result.Equals(input.Result))
                ) && 
                (
                    this.Finished == input.Finished ||
                    (this.Finished != null &&
                    this.Finished.Equals(input.Finished))
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
                if (this.ChoiceRanks != null)
                    hashCode = hashCode * 59 + this.ChoiceRanks.GetHashCode();
                if (this.TotalVotesForWinner != null)
                    hashCode = hashCode * 59 + this.TotalVotesForWinner.GetHashCode();
                if (this.Winners != null)
                    hashCode = hashCode * 59 + this.Winners.GetHashCode();
                if (this.Result != null)
                    hashCode = hashCode * 59 + this.Result.GetHashCode();
                if (this.Finished != null)
                    hashCode = hashCode * 59 + this.Finished.GetHashCode();
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
