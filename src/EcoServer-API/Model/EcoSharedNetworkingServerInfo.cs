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
    /// EcoSharedNetworkingServerInfo
    /// </summary>
    [DataContract]
    public partial class EcoSharedNetworkingServerInfo :  IEquatable<EcoSharedNetworkingServerInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EcoSharedNetworkingServerInfo" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="address">address.</param>
        /// <param name="external">external.</param>
        /// <param name="gamePort">gamePort.</param>
        /// <param name="webPort">webPort.</param>
        /// <param name="isLAN">isLAN.</param>
        /// <param name="description">description.</param>
        /// <param name="detailedDescription">detailedDescription.</param>
        /// <param name="category">category.</param>
        /// <param name="onlinePlayers">onlinePlayers.</param>
        /// <param name="totalPlayers">totalPlayers.</param>
        /// <param name="onlinePlayersNames">onlinePlayersNames.</param>
        /// <param name="adminOnline">adminOnline.</param>
        /// <param name="timeSinceStart">timeSinceStart.</param>
        /// <param name="timeLeft">timeLeft.</param>
        /// <param name="animals">animals.</param>
        /// <param name="plants">plants.</param>
        /// <param name="laws">laws.</param>
        /// <param name="worldSize">worldSize.</param>
        /// <param name="version">version.</param>
        /// <param name="economyDesc">economyDesc.</param>
        /// <param name="skillSpecialization">skillSpecialization.</param>
        /// <param name="skillSpecializationSetting">skillSpecializationSetting.</param>
        /// <param name="worldObjective">worldObjective.</param>
        /// <param name="language">language.</param>
        /// <param name="hasPassword">hasPassword.</param>
        /// <param name="hasMeteor">hasMeteor.</param>
        /// <param name="distributionStationItems">distributionStationItems.</param>
        /// <param name="playtimes">playtimes.</param>
        /// <param name="discordAddress">discordAddress.</param>
        /// <param name="isPaused">isPaused.</param>
        /// <param name="activeAndOnlinePlayers">activeAndOnlinePlayers.</param>
        /// <param name="peakActivePlayers">peakActivePlayers.</param>
        /// <param name="maxActivePlayers">maxActivePlayers.</param>
        /// <param name="exhaustionAfterHours">exhaustionAfterHours.</param>
        /// <param name="isLimitingHours">isLimitingHours.</param>
        /// <param name="serverAchievements">serverAchievements.</param>
        /// <param name="relayAddress">relayAddress.</param>
        /// <param name="access">access.</param>
        public EcoSharedNetworkingServerInfo(Guid? id = default(Guid?), string name = default(string), string address = default(string), bool? external = default(bool?), int? gamePort = default(int?), int? webPort = default(int?), bool? isLAN = default(bool?), string description = default(string), string detailedDescription = default(string), EcoSharedStatesServerCategory category = default(EcoSharedStatesServerCategory), int? onlinePlayers = default(int?), int? totalPlayers = default(int?), List<string> onlinePlayersNames = default(List<string>), bool? adminOnline = default(bool?), double? timeSinceStart = default(double?), double? timeLeft = default(double?), int? animals = default(int?), int? plants = default(int?), int? laws = default(int?), string worldSize = default(string), string version = default(string), string economyDesc = default(string), string skillSpecialization = default(string), EcoSharedNetworkingSkillSpecializationSetting skillSpecializationSetting = default(EcoSharedNetworkingSkillSpecializationSetting), string worldObjective = default(string), string language = default(string), bool? hasPassword = default(bool?), bool? hasMeteor = default(bool?), string distributionStationItems = default(string), string playtimes = default(string), string discordAddress = default(string), bool? isPaused = default(bool?), int? activeAndOnlinePlayers = default(int?), int? peakActivePlayers = default(int?), int? maxActivePlayers = default(int?), float? exhaustionAfterHours = default(float?), bool? isLimitingHours = default(bool?), List<string> serverAchievements = default(List<string>), string relayAddress = default(string), string access = default(string))
        {
            this.Id = id;
            this.Name = name;
            this.Address = address;
            this.External = external;
            this.GamePort = gamePort;
            this.WebPort = webPort;
            this.IsLAN = isLAN;
            this.Description = description;
            this.DetailedDescription = detailedDescription;
            this.Category = category;
            this.OnlinePlayers = onlinePlayers;
            this.TotalPlayers = totalPlayers;
            this.OnlinePlayersNames = onlinePlayersNames;
            this.AdminOnline = adminOnline;
            this.TimeSinceStart = timeSinceStart;
            this.TimeLeft = timeLeft;
            this.Animals = animals;
            this.Plants = plants;
            this.Laws = laws;
            this.WorldSize = worldSize;
            this.Version = version;
            this.EconomyDesc = economyDesc;
            this.SkillSpecialization = skillSpecialization;
            this.SkillSpecializationSetting = skillSpecializationSetting;
            this.WorldObjective = worldObjective;
            this.Language = language;
            this.HasPassword = hasPassword;
            this.HasMeteor = hasMeteor;
            this.DistributionStationItems = distributionStationItems;
            this.Playtimes = playtimes;
            this.DiscordAddress = discordAddress;
            this.IsPaused = isPaused;
            this.ActiveAndOnlinePlayers = activeAndOnlinePlayers;
            this.PeakActivePlayers = peakActivePlayers;
            this.MaxActivePlayers = maxActivePlayers;
            this.ExhaustionAfterHours = exhaustionAfterHours;
            this.IsLimitingHours = isLimitingHours;
            this.ServerAchievements = serverAchievements;
            this.RelayAddress = relayAddress;
            this.Access = access;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid? Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }

        /// <summary>
        /// Gets or Sets External
        /// </summary>
        [DataMember(Name="external", EmitDefaultValue=false)]
        public bool? External { get; set; }

        /// <summary>
        /// Gets or Sets GamePort
        /// </summary>
        [DataMember(Name="gamePort", EmitDefaultValue=false)]
        public int? GamePort { get; set; }

        /// <summary>
        /// Gets or Sets WebPort
        /// </summary>
        [DataMember(Name="webPort", EmitDefaultValue=false)]
        public int? WebPort { get; set; }

        /// <summary>
        /// Gets or Sets IsLAN
        /// </summary>
        [DataMember(Name="isLAN", EmitDefaultValue=false)]
        public bool? IsLAN { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets DetailedDescription
        /// </summary>
        [DataMember(Name="detailedDescription", EmitDefaultValue=false)]
        public string DetailedDescription { get; set; }

        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public EcoSharedStatesServerCategory Category { get; set; }

        /// <summary>
        /// Gets or Sets OnlinePlayers
        /// </summary>
        [DataMember(Name="onlinePlayers", EmitDefaultValue=false)]
        public int? OnlinePlayers { get; set; }

        /// <summary>
        /// Gets or Sets TotalPlayers
        /// </summary>
        [DataMember(Name="totalPlayers", EmitDefaultValue=false)]
        public int? TotalPlayers { get; set; }

        /// <summary>
        /// Gets or Sets OnlinePlayersNames
        /// </summary>
        [DataMember(Name="onlinePlayersNames", EmitDefaultValue=false)]
        public List<string> OnlinePlayersNames { get; set; }

        /// <summary>
        /// Gets or Sets AdminOnline
        /// </summary>
        [DataMember(Name="adminOnline", EmitDefaultValue=false)]
        public bool? AdminOnline { get; set; }

        /// <summary>
        /// Gets or Sets TimeSinceStart
        /// </summary>
        [DataMember(Name="timeSinceStart", EmitDefaultValue=false)]
        public double? TimeSinceStart { get; set; }

        /// <summary>
        /// Gets or Sets TimeLeft
        /// </summary>
        [DataMember(Name="timeLeft", EmitDefaultValue=false)]
        public double? TimeLeft { get; set; }

        /// <summary>
        /// Gets or Sets Animals
        /// </summary>
        [DataMember(Name="animals", EmitDefaultValue=false)]
        public int? Animals { get; set; }

        /// <summary>
        /// Gets or Sets Plants
        /// </summary>
        [DataMember(Name="plants", EmitDefaultValue=false)]
        public int? Plants { get; set; }

        /// <summary>
        /// Gets or Sets Laws
        /// </summary>
        [DataMember(Name="laws", EmitDefaultValue=false)]
        public int? Laws { get; set; }

        /// <summary>
        /// Gets or Sets WorldSize
        /// </summary>
        [DataMember(Name="worldSize", EmitDefaultValue=false)]
        public string WorldSize { get; set; }

        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }

        /// <summary>
        /// Gets or Sets EconomyDesc
        /// </summary>
        [DataMember(Name="economyDesc", EmitDefaultValue=false)]
        public string EconomyDesc { get; set; }

        /// <summary>
        /// Gets or Sets SkillSpecialization
        /// </summary>
        [DataMember(Name="skillSpecialization", EmitDefaultValue=false)]
        public string SkillSpecialization { get; set; }

        /// <summary>
        /// Gets or Sets SkillSpecializationSetting
        /// </summary>
        [DataMember(Name="skillSpecializationSetting", EmitDefaultValue=false)]
        public EcoSharedNetworkingSkillSpecializationSetting SkillSpecializationSetting { get; set; }

        /// <summary>
        /// Gets or Sets WorldObjective
        /// </summary>
        [DataMember(Name="worldObjective", EmitDefaultValue=false)]
        public string WorldObjective { get; set; }

        /// <summary>
        /// Gets or Sets Language
        /// </summary>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; set; }

        /// <summary>
        /// Gets or Sets HasPassword
        /// </summary>
        [DataMember(Name="hasPassword", EmitDefaultValue=false)]
        public bool? HasPassword { get; set; }

        /// <summary>
        /// Gets or Sets HasMeteor
        /// </summary>
        [DataMember(Name="hasMeteor", EmitDefaultValue=false)]
        public bool? HasMeteor { get; set; }

        /// <summary>
        /// Gets or Sets DistributionStationItems
        /// </summary>
        [DataMember(Name="distributionStationItems", EmitDefaultValue=false)]
        public string DistributionStationItems { get; set; }

        /// <summary>
        /// Gets or Sets Playtimes
        /// </summary>
        [DataMember(Name="playtimes", EmitDefaultValue=false)]
        public string Playtimes { get; set; }

        /// <summary>
        /// Gets or Sets DiscordAddress
        /// </summary>
        [DataMember(Name="discordAddress", EmitDefaultValue=false)]
        public string DiscordAddress { get; set; }

        /// <summary>
        /// Gets or Sets IsPaused
        /// </summary>
        [DataMember(Name="isPaused", EmitDefaultValue=false)]
        public bool? IsPaused { get; set; }

        /// <summary>
        /// Gets or Sets ActiveAndOnlinePlayers
        /// </summary>
        [DataMember(Name="activeAndOnlinePlayers", EmitDefaultValue=false)]
        public int? ActiveAndOnlinePlayers { get; set; }

        /// <summary>
        /// Gets or Sets PeakActivePlayers
        /// </summary>
        [DataMember(Name="peakActivePlayers", EmitDefaultValue=false)]
        public int? PeakActivePlayers { get; set; }

        /// <summary>
        /// Gets or Sets MaxActivePlayers
        /// </summary>
        [DataMember(Name="maxActivePlayers", EmitDefaultValue=false)]
        public int? MaxActivePlayers { get; set; }

        /// <summary>
        /// Gets or Sets ExhaustionAfterHours
        /// </summary>
        [DataMember(Name="exhaustionAfterHours", EmitDefaultValue=false)]
        public float? ExhaustionAfterHours { get; set; }

        /// <summary>
        /// Gets or Sets IsLimitingHours
        /// </summary>
        [DataMember(Name="isLimitingHours", EmitDefaultValue=false)]
        public bool? IsLimitingHours { get; set; }

        /// <summary>
        /// Gets or Sets ServerAchievements
        /// </summary>
        [DataMember(Name="serverAchievements", EmitDefaultValue=false)]
        public List<string> ServerAchievements { get; set; }

        /// <summary>
        /// Gets or Sets RelayAddress
        /// </summary>
        [DataMember(Name="relayAddress", EmitDefaultValue=false)]
        public string RelayAddress { get; set; }

        /// <summary>
        /// Gets or Sets Access
        /// </summary>
        [DataMember(Name="access", EmitDefaultValue=false)]
        public string Access { get; set; }

        /// <summary>
        /// Gets or Sets JoinUrl
        /// </summary>
        [DataMember(Name="joinUrl", EmitDefaultValue=false)]
        public string JoinUrl { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EcoSharedNetworkingServerInfo {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  External: ").Append(External).Append("\n");
            sb.Append("  GamePort: ").Append(GamePort).Append("\n");
            sb.Append("  WebPort: ").Append(WebPort).Append("\n");
            sb.Append("  IsLAN: ").Append(IsLAN).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DetailedDescription: ").Append(DetailedDescription).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  OnlinePlayers: ").Append(OnlinePlayers).Append("\n");
            sb.Append("  TotalPlayers: ").Append(TotalPlayers).Append("\n");
            sb.Append("  OnlinePlayersNames: ").Append(OnlinePlayersNames).Append("\n");
            sb.Append("  AdminOnline: ").Append(AdminOnline).Append("\n");
            sb.Append("  TimeSinceStart: ").Append(TimeSinceStart).Append("\n");
            sb.Append("  TimeLeft: ").Append(TimeLeft).Append("\n");
            sb.Append("  Animals: ").Append(Animals).Append("\n");
            sb.Append("  Plants: ").Append(Plants).Append("\n");
            sb.Append("  Laws: ").Append(Laws).Append("\n");
            sb.Append("  WorldSize: ").Append(WorldSize).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  EconomyDesc: ").Append(EconomyDesc).Append("\n");
            sb.Append("  SkillSpecialization: ").Append(SkillSpecialization).Append("\n");
            sb.Append("  SkillSpecializationSetting: ").Append(SkillSpecializationSetting).Append("\n");
            sb.Append("  WorldObjective: ").Append(WorldObjective).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  HasPassword: ").Append(HasPassword).Append("\n");
            sb.Append("  HasMeteor: ").Append(HasMeteor).Append("\n");
            sb.Append("  DistributionStationItems: ").Append(DistributionStationItems).Append("\n");
            sb.Append("  Playtimes: ").Append(Playtimes).Append("\n");
            sb.Append("  DiscordAddress: ").Append(DiscordAddress).Append("\n");
            sb.Append("  IsPaused: ").Append(IsPaused).Append("\n");
            sb.Append("  ActiveAndOnlinePlayers: ").Append(ActiveAndOnlinePlayers).Append("\n");
            sb.Append("  PeakActivePlayers: ").Append(PeakActivePlayers).Append("\n");
            sb.Append("  MaxActivePlayers: ").Append(MaxActivePlayers).Append("\n");
            sb.Append("  ExhaustionAfterHours: ").Append(ExhaustionAfterHours).Append("\n");
            sb.Append("  IsLimitingHours: ").Append(IsLimitingHours).Append("\n");
            sb.Append("  ServerAchievements: ").Append(ServerAchievements).Append("\n");
            sb.Append("  RelayAddress: ").Append(RelayAddress).Append("\n");
            sb.Append("  Access: ").Append(Access).Append("\n");
            sb.Append("  JoinUrl: ").Append(JoinUrl).Append("\n");
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
            return this.Equals(input as EcoSharedNetworkingServerInfo);
        }

        /// <summary>
        /// Returns true if EcoSharedNetworkingServerInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of EcoSharedNetworkingServerInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EcoSharedNetworkingServerInfo input)
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
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.External == input.External ||
                    (this.External != null &&
                    this.External.Equals(input.External))
                ) && 
                (
                    this.GamePort == input.GamePort ||
                    (this.GamePort != null &&
                    this.GamePort.Equals(input.GamePort))
                ) && 
                (
                    this.WebPort == input.WebPort ||
                    (this.WebPort != null &&
                    this.WebPort.Equals(input.WebPort))
                ) && 
                (
                    this.IsLAN == input.IsLAN ||
                    (this.IsLAN != null &&
                    this.IsLAN.Equals(input.IsLAN))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.DetailedDescription == input.DetailedDescription ||
                    (this.DetailedDescription != null &&
                    this.DetailedDescription.Equals(input.DetailedDescription))
                ) && 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.OnlinePlayers == input.OnlinePlayers ||
                    (this.OnlinePlayers != null &&
                    this.OnlinePlayers.Equals(input.OnlinePlayers))
                ) && 
                (
                    this.TotalPlayers == input.TotalPlayers ||
                    (this.TotalPlayers != null &&
                    this.TotalPlayers.Equals(input.TotalPlayers))
                ) && 
                (
                    this.OnlinePlayersNames == input.OnlinePlayersNames ||
                    this.OnlinePlayersNames != null &&
                    this.OnlinePlayersNames.SequenceEqual(input.OnlinePlayersNames)
                ) && 
                (
                    this.AdminOnline == input.AdminOnline ||
                    (this.AdminOnline != null &&
                    this.AdminOnline.Equals(input.AdminOnline))
                ) && 
                (
                    this.TimeSinceStart == input.TimeSinceStart ||
                    (this.TimeSinceStart != null &&
                    this.TimeSinceStart.Equals(input.TimeSinceStart))
                ) && 
                (
                    this.TimeLeft == input.TimeLeft ||
                    (this.TimeLeft != null &&
                    this.TimeLeft.Equals(input.TimeLeft))
                ) && 
                (
                    this.Animals == input.Animals ||
                    (this.Animals != null &&
                    this.Animals.Equals(input.Animals))
                ) && 
                (
                    this.Plants == input.Plants ||
                    (this.Plants != null &&
                    this.Plants.Equals(input.Plants))
                ) && 
                (
                    this.Laws == input.Laws ||
                    (this.Laws != null &&
                    this.Laws.Equals(input.Laws))
                ) && 
                (
                    this.WorldSize == input.WorldSize ||
                    (this.WorldSize != null &&
                    this.WorldSize.Equals(input.WorldSize))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.EconomyDesc == input.EconomyDesc ||
                    (this.EconomyDesc != null &&
                    this.EconomyDesc.Equals(input.EconomyDesc))
                ) && 
                (
                    this.SkillSpecialization == input.SkillSpecialization ||
                    (this.SkillSpecialization != null &&
                    this.SkillSpecialization.Equals(input.SkillSpecialization))
                ) && 
                (
                    this.SkillSpecializationSetting == input.SkillSpecializationSetting ||
                    (this.SkillSpecializationSetting != null &&
                    this.SkillSpecializationSetting.Equals(input.SkillSpecializationSetting))
                ) && 
                (
                    this.WorldObjective == input.WorldObjective ||
                    (this.WorldObjective != null &&
                    this.WorldObjective.Equals(input.WorldObjective))
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && 
                (
                    this.HasPassword == input.HasPassword ||
                    (this.HasPassword != null &&
                    this.HasPassword.Equals(input.HasPassword))
                ) && 
                (
                    this.HasMeteor == input.HasMeteor ||
                    (this.HasMeteor != null &&
                    this.HasMeteor.Equals(input.HasMeteor))
                ) && 
                (
                    this.DistributionStationItems == input.DistributionStationItems ||
                    (this.DistributionStationItems != null &&
                    this.DistributionStationItems.Equals(input.DistributionStationItems))
                ) && 
                (
                    this.Playtimes == input.Playtimes ||
                    (this.Playtimes != null &&
                    this.Playtimes.Equals(input.Playtimes))
                ) && 
                (
                    this.DiscordAddress == input.DiscordAddress ||
                    (this.DiscordAddress != null &&
                    this.DiscordAddress.Equals(input.DiscordAddress))
                ) && 
                (
                    this.IsPaused == input.IsPaused ||
                    (this.IsPaused != null &&
                    this.IsPaused.Equals(input.IsPaused))
                ) && 
                (
                    this.ActiveAndOnlinePlayers == input.ActiveAndOnlinePlayers ||
                    (this.ActiveAndOnlinePlayers != null &&
                    this.ActiveAndOnlinePlayers.Equals(input.ActiveAndOnlinePlayers))
                ) && 
                (
                    this.PeakActivePlayers == input.PeakActivePlayers ||
                    (this.PeakActivePlayers != null &&
                    this.PeakActivePlayers.Equals(input.PeakActivePlayers))
                ) && 
                (
                    this.MaxActivePlayers == input.MaxActivePlayers ||
                    (this.MaxActivePlayers != null &&
                    this.MaxActivePlayers.Equals(input.MaxActivePlayers))
                ) && 
                (
                    this.ExhaustionAfterHours == input.ExhaustionAfterHours ||
                    (this.ExhaustionAfterHours != null &&
                    this.ExhaustionAfterHours.Equals(input.ExhaustionAfterHours))
                ) && 
                (
                    this.IsLimitingHours == input.IsLimitingHours ||
                    (this.IsLimitingHours != null &&
                    this.IsLimitingHours.Equals(input.IsLimitingHours))
                ) && 
                (
                    this.ServerAchievements == input.ServerAchievements ||
                    this.ServerAchievements != null &&
                    this.ServerAchievements.SequenceEqual(input.ServerAchievements)
                ) && 
                (
                    this.RelayAddress == input.RelayAddress ||
                    (this.RelayAddress != null &&
                    this.RelayAddress.Equals(input.RelayAddress))
                ) && 
                (
                    this.Access == input.Access ||
                    (this.Access != null &&
                    this.Access.Equals(input.Access))
                ) && 
                (
                    this.JoinUrl == input.JoinUrl ||
                    (this.JoinUrl != null &&
                    this.JoinUrl.Equals(input.JoinUrl))
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
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.External != null)
                    hashCode = hashCode * 59 + this.External.GetHashCode();
                if (this.GamePort != null)
                    hashCode = hashCode * 59 + this.GamePort.GetHashCode();
                if (this.WebPort != null)
                    hashCode = hashCode * 59 + this.WebPort.GetHashCode();
                if (this.IsLAN != null)
                    hashCode = hashCode * 59 + this.IsLAN.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DetailedDescription != null)
                    hashCode = hashCode * 59 + this.DetailedDescription.GetHashCode();
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.OnlinePlayers != null)
                    hashCode = hashCode * 59 + this.OnlinePlayers.GetHashCode();
                if (this.TotalPlayers != null)
                    hashCode = hashCode * 59 + this.TotalPlayers.GetHashCode();
                if (this.OnlinePlayersNames != null)
                    hashCode = hashCode * 59 + this.OnlinePlayersNames.GetHashCode();
                if (this.AdminOnline != null)
                    hashCode = hashCode * 59 + this.AdminOnline.GetHashCode();
                if (this.TimeSinceStart != null)
                    hashCode = hashCode * 59 + this.TimeSinceStart.GetHashCode();
                if (this.TimeLeft != null)
                    hashCode = hashCode * 59 + this.TimeLeft.GetHashCode();
                if (this.Animals != null)
                    hashCode = hashCode * 59 + this.Animals.GetHashCode();
                if (this.Plants != null)
                    hashCode = hashCode * 59 + this.Plants.GetHashCode();
                if (this.Laws != null)
                    hashCode = hashCode * 59 + this.Laws.GetHashCode();
                if (this.WorldSize != null)
                    hashCode = hashCode * 59 + this.WorldSize.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.EconomyDesc != null)
                    hashCode = hashCode * 59 + this.EconomyDesc.GetHashCode();
                if (this.SkillSpecialization != null)
                    hashCode = hashCode * 59 + this.SkillSpecialization.GetHashCode();
                if (this.SkillSpecializationSetting != null)
                    hashCode = hashCode * 59 + this.SkillSpecializationSetting.GetHashCode();
                if (this.WorldObjective != null)
                    hashCode = hashCode * 59 + this.WorldObjective.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.HasPassword != null)
                    hashCode = hashCode * 59 + this.HasPassword.GetHashCode();
                if (this.HasMeteor != null)
                    hashCode = hashCode * 59 + this.HasMeteor.GetHashCode();
                if (this.DistributionStationItems != null)
                    hashCode = hashCode * 59 + this.DistributionStationItems.GetHashCode();
                if (this.Playtimes != null)
                    hashCode = hashCode * 59 + this.Playtimes.GetHashCode();
                if (this.DiscordAddress != null)
                    hashCode = hashCode * 59 + this.DiscordAddress.GetHashCode();
                if (this.IsPaused != null)
                    hashCode = hashCode * 59 + this.IsPaused.GetHashCode();
                if (this.ActiveAndOnlinePlayers != null)
                    hashCode = hashCode * 59 + this.ActiveAndOnlinePlayers.GetHashCode();
                if (this.PeakActivePlayers != null)
                    hashCode = hashCode * 59 + this.PeakActivePlayers.GetHashCode();
                if (this.MaxActivePlayers != null)
                    hashCode = hashCode * 59 + this.MaxActivePlayers.GetHashCode();
                if (this.ExhaustionAfterHours != null)
                    hashCode = hashCode * 59 + this.ExhaustionAfterHours.GetHashCode();
                if (this.IsLimitingHours != null)
                    hashCode = hashCode * 59 + this.IsLimitingHours.GetHashCode();
                if (this.ServerAchievements != null)
                    hashCode = hashCode * 59 + this.ServerAchievements.GetHashCode();
                if (this.RelayAddress != null)
                    hashCode = hashCode * 59 + this.RelayAddress.GetHashCode();
                if (this.Access != null)
                    hashCode = hashCode * 59 + this.Access.GetHashCode();
                if (this.JoinUrl != null)
                    hashCode = hashCode * 59 + this.JoinUrl.GetHashCode();
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