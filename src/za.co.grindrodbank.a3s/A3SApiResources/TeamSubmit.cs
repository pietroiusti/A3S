/**
 * *************************************************
 * Copyright (c) 2019, Grindrod Bank Limited
 * License MIT: https://opensource.org/licenses/MIT
 * **************************************************
 */
/*
 * A3S
 *
 * API Definition for A3S. This service allows authentication, authorisation and accounting.
 *
 * The version of the OpenAPI document: 1.1.2
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
    /// Model used for creating or updating a team. Team can be optionally associated with a sub-realm by specifying the &#39;subRealmId&#39; of the sub-realm. 
    /// </summary>
    [DataContract]
    public partial class TeamSubmit : IEquatable<TeamSubmit>
    { 
        /// <summary>
        /// Gets or Sets Uuid
        /// </summary>
        [Required]
        [DataMember(Name="uuid", EmitDefaultValue=false)]
        public Guid Uuid { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [Required]
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [Required]
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// The UUIDs of the child teams (in the case of a compound team)
        /// </summary>
        /// <value>The UUIDs of the child teams (in the case of a compound team)</value>
        [DataMember(Name="teamIds", EmitDefaultValue=false)]
        public List<Guid> TeamIds { get; set; }

        /// <summary>
        /// The application data policies that are applied to this team.
        /// </summary>
        /// <value>The application data policies that are applied to this team.</value>
        [DataMember(Name="dataPolicyIds", EmitDefaultValue=false)]
        public List<Guid> DataPolicyIds { get; set; }

        /// <summary>
        /// Gets or Sets TermsOfServiceId
        /// </summary>
        [DataMember(Name="termsOfServiceId", EmitDefaultValue=true)]
        public Guid? TermsOfServiceId { get; set; }

        /// <summary>
        /// The UUID identifier for a sub-realm.
        /// </summary>
        /// <value>The UUID identifier for a sub-realm.</value>
        [DataMember(Name="subRealmId", EmitDefaultValue=false)]
        public Guid SubRealmId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TeamSubmit {\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  TeamIds: ").Append(TeamIds).Append("\n");
            sb.Append("  DataPolicyIds: ").Append(DataPolicyIds).Append("\n");
            sb.Append("  TermsOfServiceId: ").Append(TermsOfServiceId).Append("\n");
            sb.Append("  SubRealmId: ").Append(SubRealmId).Append("\n");
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
            return obj.GetType() == GetType() && Equals((TeamSubmit)obj);
        }

        /// <summary>
        /// Returns true if TeamSubmit instances are equal
        /// </summary>
        /// <param name="other">Instance of TeamSubmit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TeamSubmit other)
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
                    TeamIds == other.TeamIds ||
                    TeamIds != null &&
                    other.TeamIds != null &&
                    TeamIds.SequenceEqual(other.TeamIds)
                ) && 
                (
                    DataPolicyIds == other.DataPolicyIds ||
                    DataPolicyIds != null &&
                    other.DataPolicyIds != null &&
                    DataPolicyIds.SequenceEqual(other.DataPolicyIds)
                ) && 
                (
                    TermsOfServiceId == other.TermsOfServiceId ||
                    TermsOfServiceId != null &&
                    TermsOfServiceId.Equals(other.TermsOfServiceId)
                ) && 
                (
                    SubRealmId == other.SubRealmId ||
                    SubRealmId != null &&
                    SubRealmId.Equals(other.SubRealmId)
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
                    if (TeamIds != null)
                    hashCode = hashCode * 59 + TeamIds.GetHashCode();
                    if (DataPolicyIds != null)
                    hashCode = hashCode * 59 + DataPolicyIds.GetHashCode();
                    if (TermsOfServiceId != null)
                    hashCode = hashCode * 59 + TermsOfServiceId.GetHashCode();
                    if (SubRealmId != null)
                    hashCode = hashCode * 59 + SubRealmId.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(TeamSubmit left, TeamSubmit right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(TeamSubmit left, TeamSubmit right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
