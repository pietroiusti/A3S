/**
 * *************************************************
 * Copyright (c) 2020, Grindrod Bank Limited
 * License MIT: https://opensource.org/licenses/MIT
 * **************************************************
 */
/*
 * A3S
 *
 * API Definition for A3S. This service allows authentication, authorisation and accounting.
 *
 * The version of the OpenAPI document: 2.0.0-alpha-1.0.0
 * 
 * Generated by: https://openapi-generator.tech
 */

using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using za.co.grindrodbank.a3s.Converters;

namespace za.co.grindrodbank.a3s.A3SApiResources
{ 
    /// <summary>
    /// Models a default team definition within a default configuration. 
    /// </summary>
    [DataContract]
    public partial class SecurityContractDefaultConfigurationTeam : IEquatable<SecurityContractDefaultConfigurationTeam>
    { 
        /// <summary>
        /// The unique Id of the team.
        /// </summary>
        /// <value>The unique Id of the team.</value>
        [DataMember(Name="uuid", EmitDefaultValue=false)]
        public Guid Uuid { get; set; }

        /// <summary>
        /// The name of the team.
        /// </summary>
        /// <value>The name of the team.</value>
        [Required]
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// A description of the team.
        /// </summary>
        /// <value>A description of the team.</value>
        [Required]
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// An array of all the user names that are to be added to the team. The user must already exist or be defined in other sections of the security contract.
        /// </summary>
        /// <value>An array of all the user names that are to be added to the team. The user must already exist or be defined in other sections of the security contract.</value>
        [DataMember(Name="users", EmitDefaultValue=false)]
        public List<string> Users { get; set; }

        /// <summary>
        /// An array of all the teams that are to be added to the team. The teams must already exist or be defined in other sections of the security contract.
        /// </summary>
        /// <value>An array of all the teams that are to be added to the team. The teams must already exist or be defined in other sections of the security contract.</value>
        [DataMember(Name="teams", EmitDefaultValue=false)]
        public List<string> Teams { get; set; }

        /// <summary>
        /// An array of application data policy names that are to be applied to the team.
        /// </summary>
        /// <value>An array of application data policy names that are to be applied to the team.</value>
        [DataMember(Name="dataPolicies", EmitDefaultValue=false)]
        public List<string> DataPolicies { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SecurityContractDefaultConfigurationTeam {\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Users: ").Append(Users).Append("\n");
            sb.Append("  Teams: ").Append(Teams).Append("\n");
            sb.Append("  DataPolicies: ").Append(DataPolicies).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((SecurityContractDefaultConfigurationTeam)obj);
        }

        /// <summary>
        /// Returns true if SecurityContractDefaultConfigurationTeam instances are equal
        /// </summary>
        /// <param name="other">Instance of SecurityContractDefaultConfigurationTeam to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SecurityContractDefaultConfigurationTeam other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Uuid == other.Uuid ||
                    Uuid != null &&
                    Uuid.Equals(other.Uuid)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
                (
                    Users == other.Users ||
                    Users != null &&
                    other.Users != null &&
                    Users.SequenceEqual(other.Users)
                ) && 
                (
                    Teams == other.Teams ||
                    Teams != null &&
                    other.Teams != null &&
                    Teams.SequenceEqual(other.Teams)
                ) && 
                (
                    DataPolicies == other.DataPolicies ||
                    DataPolicies != null &&
                    other.DataPolicies != null &&
                    DataPolicies.SequenceEqual(other.DataPolicies)
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
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Uuid != null)
                    hashCode = hashCode * 59 + Uuid.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (Users != null)
                    hashCode = hashCode * 59 + Users.GetHashCode();
                    if (Teams != null)
                    hashCode = hashCode * 59 + Teams.GetHashCode();
                    if (DataPolicies != null)
                    hashCode = hashCode * 59 + DataPolicies.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SecurityContractDefaultConfigurationTeam left, SecurityContractDefaultConfigurationTeam right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SecurityContractDefaultConfigurationTeam left, SecurityContractDefaultConfigurationTeam right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
